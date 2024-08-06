public sealed class KeySwitchLayoutButton : KeySpecialButton
{
    protected override void KeyPress(bool isOn)
    {
        specialKeyHandler.SwitchLayoutPress(isOn);
    }
}
