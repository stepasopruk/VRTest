
using KeyboardVR;
using UnityEngine;

public sealed class KeySwitchKeysButton : KeySpecialButton
{
    [SerializeField] private KeyKitType keyboardSetKey;

    protected override void KeyPress(bool isOn)
    {
        specialKeyHandler.SwitchKeysPress(keyboardSetKey);
    }
}
