#if __DEBUG_MODE_AVALIABLE__

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public static class DebugMethods
{
    private static GameObject followerPrefab;
    private static Vector3 posCalc;

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

    [MenuItem("ImplementedTools/Debug Mode/Toggle Undying &#u", false, 1)]
    public static void DebugUndying()
    {
        DebugSwitches.debugUndying = !DebugSwitches.debugUndying;

        Debug.Log("DEBUG MODE: Debug Undying is now " + DebugSwitches.debugUndying);
    }

    [MenuItem("ImplementedTools/Debug Mode/Add Follower &#UP", false, 1)]
    public static void DebugAddFollower()
    {
        followerPrefab = PoolingManager.Instance.GetPooledObject("ExtraFollowers");

        posCalc = PlayerController.partyList[PlayerController.partyList.Count - 1].transform.position;
        posCalc.x -= 15;

        followerPrefab.transform.position = posCalc;

        followerPrefab.SetActive(true);
    }

    [MenuItem("ImplementedTools/Debug Mode/Remove Follower &#DOWN", false, 1)]
    public static void DebugRemoveFollower()
    {
        PlayerController.partyList.Remove(PlayerController.partyList[PlayerController.partyList.Count - 1]);

        PlayerController.partyList[PlayerController.partyList.Count - 1].SetActive(false);
    }

    [MenuItem("ImplementedTools/Debug Mode/Load Level 1 &#1", false, 1)]
    public static void DebugLevel1()
    {
        PlayerController.partyList.Clear();

        SceneTransition.GoToScene(1);
    }

    [MenuItem("ImplementedTools/Debug Mode/Load Level 2 &#2", false, 1)]
    public static void DebugLevel2()
    {
        PlayerController.partyList.Clear();

        SceneTransition.GoToScene(2);
    }

    [MenuItem("ImplementedTools/Debug Mode/Load Level 3 &#3", false, 1)]
    public static void DebugLevel3()
    {
        PlayerController.partyList.Clear();

        SceneTransition.GoToScene(3);
    }
}

#endif