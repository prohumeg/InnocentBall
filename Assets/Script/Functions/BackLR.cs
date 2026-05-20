using UnityEngine;
using UnityEngine.SceneManagement;

public class BackLR : MonoBehaviour
{
    public void StartGame()
    {
        Time.timeScale = 1f;   // Game unpause
        SceneManager.LoadScene("LevelR");
    }
}