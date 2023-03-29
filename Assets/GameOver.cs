using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text RoundsText;
    public string MainMenuSceneName = "MainMenu";
    public SceneFader sceneFader;

    private void OnEnable()
    {
        RoundsText.text = PlayerStats.Waves.ToString();
    }

    public void Retry ()
    {
        Time.timeScale = 1f;
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
    }

    public void Menu ()
    {
        Time.timeScale = 1f;
        sceneFader.FadeTo(MainMenuSceneName);
    }
}
