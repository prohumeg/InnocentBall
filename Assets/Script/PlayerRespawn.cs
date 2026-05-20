using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public static Vector3 checkpointPosition;

    private void Start()
    {
        // Scene reload होने पर ball checkpoint पर आए
        transform.position = checkpointPosition;
    }

    public void SetCheckpoint(Vector3 newPosition)
    {
        checkpointPosition = newPosition;
    }

    private void Awake()
    {
        if (checkpointPosition == Vector3.zero)
            checkpointPosition = transform.position;
    }
}