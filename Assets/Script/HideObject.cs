using UnityEngine;

public class HideObject : MonoBehaviour
{
    public GameObject objectToHide;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            objectToHide.SetActive(false);
        }
    }
}