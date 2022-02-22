using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BollardsBehaviour : MonoBehaviour
{
    public List<GameObject> poleList;

    Vector3 vect3;
    bool hasActed = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player") && !hasActed)
        {
            hasActed = true;
            BollardsUp();
        }
    }

    void BollardsUp()
    {
        vect3.x = 0;
        vect3.y = 4f;
        vect3.z = 0;

        foreach (GameObject pole in poleList)
        {
            pole.transform.position += vect3;
        }

        GetComponent<AudioSource>().Play();
        
        enabled = false;
    }
}