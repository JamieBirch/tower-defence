using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool GameIsOver;

    public GameObject gameOverUI;

    public string nextLevel = "Level02";
    public int levelToUnlock;

    public SceneFader sceneFader;

    private void Start()
    {
        GameIsOver = false;
    }
    void Update()
    {
        if (GameIsOver)
        {
            return;
        }

        if (PlayerStats.Lives <=0)
        {
            EndGame();
        }
    }

    void EndGame ()
    {
        GameIsOver = true;
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void WinLevel()
    {
        Debug.Log("LEVEL WON!");
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
        sceneFader.FadeTo(nextLevel);
    }
}
