using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float moveDistance = 3f;   // kitna distance move karega
    public float speed = 2f;          // speed

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float move = Mathf.PingPong(Time.time * speed, moveDistance);
        transform.position = startPos + new Vector3(move, 0, 0);
    }
}