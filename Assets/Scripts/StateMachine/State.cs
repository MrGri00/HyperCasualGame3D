using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachine
{
    [CreateAssetMenu(menuName = "StateMachine/State")]
    public class State : ScriptableObject
    {
        public Action[] actions;

        public Transition[] transitions;

        public void UpdateState(FatherController controller)
        {
            DoActions(controller);
            CheckTransitions(controller);
        }

        private void DoActions(FatherController controller)
        {
            for(int i = 0; i < actions.Length; i++)
            {
                actions[i].Act(controller);
            }
        }

        private bool AllDecisionsTrue(Transition currentTrans, FatherController controller)
        {
            for (int i = 0; i < currentTrans.decisions.Length; i++)
            {
                if (currentTrans.decisions[i].Decide(controller) == false)
                {
                    return false;
                }
            }

            return true;
        }

        private void CheckTransitions(FatherController controller)
        {
            for(int i = 0; i < transitions.Length; i++)
            {
                if(AllDecisionsTrue(transitions[i], controller))
                {
                    controller.Transition(transitions[i].trueState);
                    return;
                }
                else
                {
                    controller.Transition(transitions[i].falseState);
                }
            }
        }
    }
}