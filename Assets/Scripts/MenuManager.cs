using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] List<GameObject> menuList = new List<GameObject>();

    private void OnEnable()
    {
        PlayerDeath.GameOver += OpenGameOverMenu;
        InputSystemKeyboard3D.PauseGame += OpenPauseMenu;
        FinishLine.LevelFinished += OpenVictoryMenu;
    }

    private void OnDisable()
    {
        PlayerDeath.GameOver -= OpenGameOverMenu;
        InputSystemKeyboard3D.PauseGame -= OpenPauseMenu;
        FinishLine.LevelFinished -= OpenVictoryMenu;
    }

    public void OpenMenu(string menuName)
    {
        foreach (GameObject menu in menuList)
        {
            menu.SetActive(false);

            if (menu.name.Equals(menuName))
                menu.SetActive(true);
        }
    }

    public void CloseAllMenus()
    {
        foreach (GameObject menu in menuList)
        {
            menu.SetActive(false);
        }

        Time.timeScale = 1f;
    }

    public void OpenVictoryMenu()
    {
        OpenMenu("VictoryMenu");

        Time.timeScale = 0f;
    }

    public void OpenGameOverMenu()
    {
        OpenMenu("GameOverMenu");
    }

    public void OpenPauseMenu()
    {
        if (GetCurrentMenu() == "PauseMenu")
        {
            CloseAllMenus();
        }
        else if (GetCurrentMenu() == "")
        {
            OpenMenu("PauseMenu");
            Time.timeScale = 0f;
        }
    }

    public string GetCurrentMenu()
    {
        foreach (GameObject menu in menuList)
        {
            if (menu.activeInHierarchy == true)
            {
                return menu.name;
            }
        }

        return "";
    }
}
