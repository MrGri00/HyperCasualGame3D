using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorOnKeyPressed : MonoBehaviour
{
    [SerializeField] KeyCode key;
    [SerializeField] Color colorIfTrue;
    [SerializeField] Color colorIfFalse;

    Text text;
    Color color = new Color();
    float r = 0f;
    float g = 0f;
    float b = 0f;

    private void Awake()
    {
        text = GetComponent<Text>();

        color.a = 255f;
    }

    private void Update()
    {
        if (Input.GetKey(key))
        {
            ColorUtility.TryParseHtmlString("#00FF2D", out color);
            //text.color = colorIfTrue;
        }
        else
        {
            ColorUtility.TryParseHtmlString("#ECECEC", out color);
            text.color = colorIfFalse;
        }

        text.color = color;
    }
}
