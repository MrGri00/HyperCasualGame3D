using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorOnKeyPressed : MonoBehaviour
{
    public Action<KeyCode> ControlKeyPressed = delegate { };

    public KeyCode key;

    Text text;
    Color color = new Color();

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
            ControlKeyPressed(key);
        }
        else
        {
            ColorUtility.TryParseHtmlString("#ECECEC", out color);
            ControlKeyPressed(KeyCode.None);
        }

        text.color = color;
    }
}
