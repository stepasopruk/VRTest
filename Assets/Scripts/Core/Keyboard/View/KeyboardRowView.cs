using KeyboardVR;
using UnityEngine;
using Zenject;

public class KeyboardRowView : MonoBehaviour
{
    [SerializeField] private KeyButton[] keyButtons;
    [SerializeField] private KeyOperationButton[] operationButtons;
    [SerializeField] private KeySpecialButton[] specialButtons;

    [Inject] private readonly ILayoutSwitchEvent layoutSwitch;

    private void Awake()
    {
        layoutSwitch.LayoutChanged += LayoutSwitch_LayoutChanged;
    }

    private void OnDestroy()
    {
        layoutSwitch.LayoutChanged -= LayoutSwitch_LayoutChanged;
    }

    private void LayoutSwitch_LayoutChanged(KeyboardLayout layout)
    {
        foreach (KeyButton key in keyButtons)
            key.SetKeyLayout(layout);
    }
}
