using KeyboardVR;
using UnityEngine;

public sealed class KeySwitchLayoutButton : KeySpecialButton
{
    [SerializeField] private KeyboardLayout keyboardLayout;

    protected override void KeyPress(bool isOn)
    {
        specialKeyHandler.SwitchLayoutPress(keyboardLayout);
    }
}
