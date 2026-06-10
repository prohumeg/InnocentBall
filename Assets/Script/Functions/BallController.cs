using UnityEngine;

public class BallController : MonoBehaviour
{
    [Header("Movement Settings")]
    private float keyboardInput = 0f;
    private float buttonInput = 0f;
    public float moveSpeed = 6f;
    public float jumpForce = 7f;

    private Rigidbody2D rb;
    private bool isGrounded = true;
    private float moveInput = 0f;

    [Header("Control Mode")]
    public bool useButtons = true;
    public AudioSource jumpAudio;
    public AudioClip jumpSound;

    public AudioSource rollAudio;
    public AudioClip rollSound;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 2f;
        rb.freezeRotation = true;
        rollAudio.clip = rollSound;
    }

    private void Update()
    {
        // Keyboard input
        keyboardInput = 0f;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            keyboardInput = -1f;
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            keyboardInput = 1f;

        // Final movement = keyboard + button
        float finalInput = keyboardInput != 0 ? keyboardInput : buttonInput;

        moveInput = finalInput;

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && isGrounded)
            Jump();

        if (Mathf.Abs(moveInput) > 0.1f && isGrounded)
        {
            if (!rollAudio.isPlaying)
                rollAudio.Play();
        }
        else
        {
            rollAudio.Stop();
        }
    }
    void Awake()
    {
        // यह पक्का करेगा कि गेम शुरू होते ही पुराना चेकपॉइंट हट जाए
        PlayerPrefs.DeleteAll();
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (!collision.collider.isTrigger)
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (!collision.collider.isTrigger)
        {
            isGrounded = false;
        }
    }

    // 🔹 Mobile Buttons (ye keyboard ko override karenge jab press honge)
    public void MoveLeftDown()
    {
        buttonInput = -1f;
    }

    public void MoveRightDown()
    {
        buttonInput = 1f;
    }

    public void StopMoving()
    {
        buttonInput = 0f;
    }

    public void JumpButton()
    {
        if (isGrounded)
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        isGrounded = false;

        GetComponent<AudioSource>().PlayOneShot(jumpSound);
    }
}