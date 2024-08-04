public sealed class KeyEnterButton : KeyOperationButton
{
    protected override void OnClick() 
    {
        base.OnClick();
        _operatingKeyHandler.EnterPress();
    }
}
