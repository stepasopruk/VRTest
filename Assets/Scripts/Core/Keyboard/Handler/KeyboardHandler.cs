using Zenject;

public sealed class KeyboardHandler : IKeyHandler, ISpecialKeyHandler, IOperatingKeyHandler
{
    [Inject] private readonly IKeyboardLayout keyboardLayout;

    public void KeyPress(char key)
    {

    }

    public void ShiftPress(bool isOn)
    {

    }

    public void SwitchLayoutPress(bool isOn)
    {
        if (isOn)
            keyboardLayout.Layout = KeyboardVR.KeyboardLayout.Ru;
        else
            keyboardLayout.Layout = KeyboardVR.KeyboardLayout.Eng;
    }

    public void SwitchKeysPress(bool isOn)
    {

    }

    public void BackspacePress()
    {

    }

    public void EnterPress()
    {

    }
}
