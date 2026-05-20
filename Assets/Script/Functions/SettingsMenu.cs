using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    [Header("UI References")]
    public GameObject settingsPanel;     // Panel to show/hide
    public Toggle useButtonsToggle;      // Toggle to switch control mode
    public GameObject mobileControls;    // UI (Left, Right, Jump buttons)
    public BallController ballController; // Drag your Ball here

    private bool isOpen = false;

    void Start()
    {
        // Set default values
        settingsPanel.SetActive(false);

        if (useButtonsToggle != null && ballController != null)
        {
            useButtonsToggle.isOn = ballController.useButtons;
            useButtonsToggle.onValueChanged.AddListener(OnToggleChanged);
        }

        UpdateControlMode();
    }

    // ✅ Called by Settings Button
    public void ToggleSettings()
    {
        isOpen = !isOpen;
        settingsPanel.SetActive(isOpen);
    }

    // ✅ Called when toggle value changes
    public void OnToggleChanged(bool useButtons)
    {
        if (ballController == null) return;

        ballController.useButtons = useButtons;
        UpdateControlMode();
    }

    // ✅ Enable/Disable mobile buttons
    private void UpdateControlMode()
    {
        if (mobileControls != null && ballController != null)
        {
            mobileControls.SetActive(ballController.useButtons);
        }
    }
}
