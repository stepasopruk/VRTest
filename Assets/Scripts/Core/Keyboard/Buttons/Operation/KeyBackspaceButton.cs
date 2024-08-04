public sealed class KeyBackspaceButton : KeyOperationButton
{
    protected override void OnClick()
    {
        base.OnClick();
        _operatingKeyHandler.BackspacePress();
    }
}
