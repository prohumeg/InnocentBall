using UnityEngine;

public class WinZone : MonoBehaviour
{
    public GameObject winPanel;

    public AudioSource winAudio;
    public AudioClip winSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Something Entered");

        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player Won");

            winPanel.SetActive(true);

            if (winAudio != null && winSound != null)
            {
                winAudio.PlayOneShot(winSound);
            }

            Time.timeScale = 0f;
        }
    }
}