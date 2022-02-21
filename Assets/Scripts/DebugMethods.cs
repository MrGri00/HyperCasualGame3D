using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public static class DebugMethods
{
    private static ScriptableObject followerPrefab;

    [MenuItem("ImplementedTools/Debug Mode/Show Debug Status &#s", false, 1)]
    public static void DebugStatus()
    {
        EditorUtility.DisplayDialog("Debug Mode",
            "Debug Mode is " + DebugSwitches.debugMode +
            "\nDebug Undying is " + DebugSwitches.debugUndying, 
            "Ok");
    }

    [MenuItem("ImplementedTools/Debug Mode/Toggle Debug Mode &#d", false, 1)]
    public static void DebugMode()
    {
        DebugSwitches.debugMode = !DebugSwitches.debugMode;

        Debug.Log("DEBUG MODE: Debug Mode is now " + DebugSwitches.debugMode);
    }

    [MenuItem("ImplementedTools/Debug Mode/Toggle Debug Undying &#u", false, 1)]
    public static void DebugUndying()
    {
        DebugSwitches.debugUndying = !DebugSwitches.debugUndying;

        Debug.Log("DEBUG MODE: Debug Undying is now " + DebugSwitches.debugUndying);
    }

    /*[MenuItem("ImplementedTools/Debug Mode/Add Follower &#+", false, 1)]
    public static void DebugAddFollower()
    {
        if (SceneTransition.GetSceneIndex() != 0 && SceneTransition.GetSceneIndex() != SceneTransition.GetTotalScenes())
        {
            //followerPrefab = Resources.Load("Follower");
        }

        Debug.Log("DEBUG MODE: Added follower");
    }*/
}
