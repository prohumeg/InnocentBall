using UnityEngine;

public class LoseZone : MonoBehaviour
{
    public GameObject losePanel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            losePanel.SetActive(true);
            Time.timeScale = 0f; // Game pause
        }
    }
}