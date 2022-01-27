using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public string levelToLoad = "level01";
    public SceneFader sceneFader;

    public void StartGame()
    {
        sceneFader.FadeTo(levelToLoad);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public GameObject SettingsUI;

    public void ShowSettings()
    {
        SettingsUI.SetActive(true);
    }

    public void HideSettings()
    {
        SettingsUI.SetActive(false);
    }

    public GameObject LevelsUI;

    public void ShowLevels()
    {
        LevelsUI.SetActive(true);
    }

    public void HideLevels()
    {
        LevelsUI.SetActive(false);
    }
}