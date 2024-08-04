public sealed class KeySwitchKeysButton : KeySpecialButton
{
    protected override void OnClick()
    {
        base.OnClick();
        specialKeyHandler.SwitchKeysPress(_isOn);
    }
}
