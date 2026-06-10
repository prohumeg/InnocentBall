using UnityEngine;
using UnityEngine.SceneManagement;

public class ReTry : MonoBehaviour
{
    public void RetryLevel()
    {
        // 1. चेकपॉइंट को डिलीट करें
        PlayerRespawn.ResetCheckpoint();

        // 2. लेवल रीलोड करें
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}