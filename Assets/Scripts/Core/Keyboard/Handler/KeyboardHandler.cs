using Zenject;

public sealed class KeyboardHandler : IKeyHandler, ISpecialKeyHandler, IOperatingKeyHandler
{
    [Inject] private readonly IKeyboardController keyboardController;

    public void KeyPress(char key)
    {

    }

    public void ShiftPress(bool isOn)
    {

    }

    public void SwitchLayoutPress(bool isOn)
    {
        keyboardController.Layout = isOn ? KeyboardVR.KeyboardLayout.Ru : KeyboardVR.KeyboardLayout.Eng;
    }

    public void SwitchKeysPress(bool isOn)
    {
        keyboardController.IsSymbolKeys = !isOn;
    }

    public void BackspacePress()
    {

    }

    public void EnterPress()
    {

    }
}
