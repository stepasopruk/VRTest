
public sealed class KeySwitchKeysButton : KeySpecialButton
{
    protected override void KeyPress(bool isOn)
    {
        specialKeyHandler.SwitchKeysPress(isOn);
    }
}
