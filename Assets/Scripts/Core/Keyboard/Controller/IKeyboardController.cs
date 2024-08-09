using KeyboardVR;
using UnityEngine.InputSystem;

public interface IKeyboardController
{
    KeyboardLayout Layout { get; set; }
    KeyKitType KeySet { get; set; }
}
