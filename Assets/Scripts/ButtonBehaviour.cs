using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonBehaviour : MonoBehaviour
{
    MenuManager menuManager = null;

    private void Awake()
    {
        menuManager = GetComponent<MenuManager>();
    }

    public void SettingsButton()
    {
        if (menuManager.GetCurrentMenu() != "SettingsMenu")
            menuManager.OpenMenu("SettingsMenu");

        else
            menuManager.OpenMenu("PauseMenu");
    }

    public void RestartButton()
    {
        SceneTransition.ReloadScene();

        PlayerController.partyList.Clear();

        Time.timeScale = 1f;
    }

    public void MenuButton()
    {
        SceneTransition.GoToScene(0);
    }

    public void ExitButton()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif

        Application.Quit();
    }

    public void AdvanceSceneButton()
    {
        Time.timeScale = 1f;

        PlayerController.partyList.Clear();

        SceneTransition.NextScene();
    }

    public void CreditsButton()
    {
        SceneTransition.GoToScene("Credits");
    }

    public void ControlsButton()
    {
        if (menuManager.GetCurrentMenu() != "ControlsMenu")
            menuManager.OpenMenu("ControlsMenu");

        else
            menuManager.CloseAllMenus();
    }

    public void CoinsButton(GameObject coinPanel)
    {
        coinPanel.SetActive(false);
    }
}

