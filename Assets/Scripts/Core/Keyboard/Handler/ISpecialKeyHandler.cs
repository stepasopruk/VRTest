using KeyboardVR;

public interface ISpecialKeyHandler
{
    void ShiftPress(bool isOn);
    void SwitchLayoutPress(KeyboardLayout keyboardLayout);
    void SwitchKeysPress(KeyKitType keyboardSetKey);
}
