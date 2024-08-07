using KeyboardVR;
using UnityEngine.InputSystem;

public interface IKeyboardController
{
    KeyboardLayout Layout { get; set; }
    KeyKitType KeySet { get; set; }
}

public interface IKeyboardLayoutController
{
    void SetLayoutKeyboard(KeyboardLayout keyboardLayout);
}

public interface IKeyboardKeyKitController
{
    void SetKeyKitType(KeyKitType keySet);
}