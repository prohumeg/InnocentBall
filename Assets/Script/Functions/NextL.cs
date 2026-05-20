using UnityEngine;
using UnityEngine.SceneManagement;

public class NextL : MonoBehaviour
{
    public void LoadNextLevel()
    {
        Time.timeScale = 1f; // Game unpause
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}