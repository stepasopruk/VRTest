using KeyboardVR;
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

    public void SwitchLayoutPress(KeyboardLayout keyboardLayout)
    {
        keyboardController.Layout = keyboardLayout;
    }

    public void SwitchKeysPress(KeyKitType keyboardSetKey)
    {
        keyboardController.KeySet = keyboardSetKey;
    }

    public void BackspacePress()
    {

    }

    public void EnterPress()
    {

    }
}
