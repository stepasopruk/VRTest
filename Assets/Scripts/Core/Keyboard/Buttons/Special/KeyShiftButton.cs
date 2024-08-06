public sealed class KeyShiftButton : KeySpecialButton
{
    protected override void KeyPress(bool isOn)
    {
        specialKeyHandler.ShiftPress(isOn);
    }
}
