using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class _ExamMethods : MonoBehaviour
{
    private GameObject refGameObject;
    private Vector3 vect3;

    public static int coinsCollected = 0;

    public void E1_AddFollowers(int numFollowers)
    {
        vect3 = transform.position;
        vect3.x += 3;
        vect3.z = (numFollowers / 2) * -1;

        for (int i = 0; i < numFollowers; i++)
        {
            refGameObject = PoolingManager.Instance.GetPooledObject("ExtraFollowers");

            refGameObject.transform.position = vect3;

            vect3.z += numFollowers / 4;

            refGameObject.SetActive(true);

            refGameObject.GetComponent<OnCollisionAlly>().OnCollision();

            refGameObject = null;
        }
    }

    public void E2_AddSpeed()
    {
        foreach (GameObject g in PlayerController.partyList)
        {
            g.gameObject.GetComponent<MovementBehaviour3D>().MultiplySpeedFor(5f, 3f);
        }
    }

    public void E3_LoseFollowers()
    {
        StartCoroutine(KillFollowers());
    }

    IEnumerator KillFollowers()
    {
        for (int i = 1; i < PlayerController.partyList.Count; i++)
        {
            PlayerController.partyList[i].GetComponent<HealthManager>().ReduceHealth(
                PlayerController.partyList[i].GetComponent<HealthManager>().GetMaxHealth());
        }

        return null;
    }

    public static void E4_EndTeleport()
    {
        PlayerController.partyList[0].transform.position = new Vector3(-600f, 3f, 0f);
    }

    public void E5_CoinCollected(int val)
    {
        coinsCollected += val;
    }
}