using UnityEngine;

public class UpDownMove : MonoBehaviour
{
    public float moveDistance = 2f;   // kitna upar niche jayega
    public float speed = 2f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float newY = startPos.y + Mathf.Sin(Time.time * speed) * moveDistance;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}