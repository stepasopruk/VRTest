using KeyboardVR;

public interface IKeyboardController
{
    KeyboardLayout Layout { get; set; }
    bool IsSymbolKeys { get; set; }
}
