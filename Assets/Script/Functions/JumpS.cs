using UnityEngine;
using UnityEngine.EventSystems;

public class JumpS : MonoBehaviour, IPointerDownHandler
{
    public BallController ballController;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (ballController != null)
        {
            ballController.JumpButton();
        }
    }
}