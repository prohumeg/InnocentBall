using UnityEngine;

public class TrapDisappear : MonoBehaviour
{
    public Transform ball;
    public float triggerDistance = 2f;
    public AudioClip hideSound;

    private SpriteRenderer sr;
    private Collider2D col;
    private bool hasDisappeared = false;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();
    }

    void Update()
    {
        if (hasDisappeared) return;

        float dist = Vector2.Distance(transform.position, ball.position);

        if (dist < triggerDistance)
        {
            hasDisappeared = true;

            // Hide trap
            sr.enabled = false;
            if (col != null)
                col.enabled = false;

            // Play sound (cut nahi hoga)
            AudioSource.PlayClipAtPoint(hideSound, transform.position, 1.5f);
        }
    }
}