using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlsExplainer : MonoBehaviour
{
    public ColorOnKeyPressed[] keyArray;

    Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    private void OnEnable()
    {
        for (int i = 0; i < keyArray.Length; i++)
        {
            keyArray[i].ControlKeyPressed += UpdateText;
        }
    }

    private void OnDisable()
    {
        for (int i = 0; i < keyArray.Length; i++)
        {
            keyArray[i].ControlKeyPressed -= UpdateText;
        }
    }

    void UpdateText(KeyCode keyInstruction)
    {
        switch (keyInstruction)
        {
            case KeyCode.W:
                text.text = "Jump!";
                break;

            case KeyCode.A:
                text.text = "Move to the left";
                break;

            case KeyCode.D:
                text.text = "Move to the right";
                break;

            case KeyCode.Escape:
                text.text = "Open the pause menu";
                break;
        }
    }
}
