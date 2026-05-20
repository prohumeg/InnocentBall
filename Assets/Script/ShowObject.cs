using UnityEngine;

public class ShowObject : MonoBehaviour
{
    public GameObject objectToShow;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            objectToShow.SetActive(true);
        }
    }
}