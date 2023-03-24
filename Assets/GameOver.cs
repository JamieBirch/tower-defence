using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text RoundsText;
    public string MainMenuSceneName = "MainMenu";

    private void OnEnable()
    {
        RoundsText.text = PlayerStats.Waves.ToString();
    }

    public void Retry ()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu ()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(MainMenuSceneName);
    }
}
