using UnityEngine;
using UnityEngine.SceneManagement;

public class BackM : MonoBehaviour
{
    public void StartGame()
    {
        Time.timeScale = 1f;   // Game unpause
        SceneManager.LoadScene("Loby");
    }
}