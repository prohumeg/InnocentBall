using UnityEngine;
using UnityEngine.EventSystems;

public class ImageButton : MonoBehaviour, IPointerClickHandler
{
    [Header("Reference to Settings Menu")]
    public SettingsMenu settingsMenu;

    // 🖱️ Jab image par click ho
    public void OnPointerClick(PointerEventData eventData)
    {
        if (settingsMenu != null)
            settingsMenu.ToggleSettings();
    }
}
