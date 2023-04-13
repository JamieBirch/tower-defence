using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool GameIsOver;

    public GameObject gameOverUI;
    public GameObject completeLevelUI;

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
        GameIsOver = true;
        completeLevelUI.SetActive(true);
        //Time.timeScale = 0f;
    }
}
