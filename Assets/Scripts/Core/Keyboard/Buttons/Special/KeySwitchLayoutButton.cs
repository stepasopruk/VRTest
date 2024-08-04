public sealed class KeySwitchLayoutButton : KeySpecialButton
{
    protected override void OnClick()
    {
        base.OnClick();
        specialKeyHandler.SwitchLayoutPress(_isOn);
    }
}
