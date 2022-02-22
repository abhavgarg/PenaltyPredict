using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    public void MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void PlayGame()
    {

        SceneManager.LoadScene("GameScene");
    }

    public void Result()
    {
        SceneManager.LoadScene("Result");
    }

    public void GoalieScene()
    {
        SceneManager.LoadScene("GoalieScene");
    }

    public void ScoreScene()
    {
        SceneManager.LoadScene("ScoreScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}