using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel : MonoBehaviour
{
    public string MainMenuSceneName = "MainMenu";
    public SceneFader sceneFader;

    public string nextLevel = "Level02";
    public int levelToUnlock = 2;

    public void Menu()
    {
        Time.timeScale = 1f;
        sceneFader.FadeTo(MainMenuSceneName);
    }

    public void Continue()
    {
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
        sceneFader.FadeTo(nextLevel);
    }
}
