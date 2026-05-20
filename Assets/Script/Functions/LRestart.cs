using UnityEngine;
using UnityEngine.SceneManagement;

public class LRestart : MonoBehaviour
{
    public void RestartGame()
    {
        Time.timeScale = 1f; // Game unpause
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}