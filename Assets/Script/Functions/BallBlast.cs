using UnityEngine;
using UnityEngine.SceneManagement;

public class BallBlast : MonoBehaviour
{
    public GameObject blastEffect;
    public AudioClip blastSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Trap"))
        {
            Instantiate(blastEffect, transform.position, Quaternion.identity);

            AudioSource.PlayClipAtPoint(blastSound, transform.position, 2f);

            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Rigidbody2D>().simulated = false;

            Invoke("RestartLevel", 2f);
        }
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}