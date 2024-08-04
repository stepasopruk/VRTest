public sealed class KeyShiftButton : KeySpecialButton
{
    protected override void OnClick()
    {
        base.OnClick();
        specialKeyHandler.ShiftPress(_isOn);
    }
}
