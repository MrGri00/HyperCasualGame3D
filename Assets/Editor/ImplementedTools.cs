using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class ImplementedTools : Editor
{
    [MenuItem("ImplementedTools/Toggle Active &#a", false, 1)] // & = alt, # = shift, a
    public static void ToggleActive()
    {
        Transform[] selectedElements = Selection.GetTransforms(SelectionMode.TopLevel | SelectionMode.Editable);

        if (selectedElements.Length > 0)
        {
            for (int i = 0; i < selectedElements.Length; i++)
            {
                selectedElements[i].gameObject.SetActive(!selectedElements[i].gameObject.activeSelf);
            }
        }
        else
            EditorUtility.DisplayDialog("Error", "You must select at least one (1) element in the scene", "Ok");
    }
}
