using UnityEngine;
using UnityEngine.SceneManagement;

public class ReTry: MonoBehaviour
{
    public void RetryLevel()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}