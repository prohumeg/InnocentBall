using UnityEngine;
using UnityEngine.SceneManagement;

public class BackLR : MonoBehaviour
{
    public void StartGame()
    {
        // 1. चेकपॉइंट रीसेट (डेटा क्लियर हो जाएगा)
        PlayerRespawn.ResetCheckpoint();

        // 2. लेवल लोड
        SceneManager.LoadScene("LevelR");
    }
}