using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public static Vector3 checkpointPosition;

    private void Start()
    {
        // अगर कोई चेकपॉइंट सेव है, तो वहां स्पॉन हो
        if (checkpointPosition != Vector3.zero)
        {
            transform.position = checkpointPosition;
        }
    }

    public void SetCheckpoint(Vector3 newPosition)
    {
        checkpointPosition = newPosition;
    }

    // नया फंक्शन: चेकपॉइंट को पूरी तरह मिटाने के लिए
    public static void ResetCheckpoint()
    {
        checkpointPosition = Vector3.zero;
    }
}