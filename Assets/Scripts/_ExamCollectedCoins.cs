using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _ExamCollectedCoins : MonoBehaviour
{
    private void OnEnable()
    {
        GetComponent<Text>().text = "" + _ExamMethods.coinsCollected;
    }
}
