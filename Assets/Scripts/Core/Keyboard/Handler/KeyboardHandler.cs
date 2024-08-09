using KeyboardVR;
using Zenject;

public sealed class KeyboardHandler : IKeyHandler, ISpecialKeyHandler, IOperatingKeyHandler
{
    [Inject] private readonly IKeyboardLayoutController keyboardLayoutController;
    [Inject] private readonly IKeyboardKeyKitController keyboardKeyKitController;

    public void KeyPress(char key)
    {

    }

    public void ShiftPress(bool isOn)
    {

    }

    public void SwitchLayoutPress(KeyboardLayout keyboardLayout)
    {
        keyboardLayoutController.SetLayoutKeyboard(keyboardLayout);
    }

    public void SwitchKeysPress(KeyKitType keyboardKeyKit)
    {
        keyboardKeyKitController.SetKeyKitType(keyboardKeyKit);
    }

    public void BackspacePress()
    {

    }

    public void EnterPress()
    {

    }
}
