using KeyboardVR;
using UnityEditor.VersionControl;
using UnityEngine;

public class KeyboardController : MonoBehaviour, IKeyboardController
{
    [SerializeField] private KeyboardView keyboardView;

    private KeyboardLayout _layout;
    public KeyboardLayout Layout
    {
        get => _layout;
        set
        {
            if (_layout == value) 
                return;

            _layout = value;
            keyboardView.SwitchLayout(_layout);
        }
    }

    private KeyKitType _setKey;
    public KeyKitType KeySet
    {
        get => _setKey;
        set
        {
            if (_setKey == value)
                return;

            _setKey = value;
            keyboardView.SwitchKeys(_setKey);
        }
    }

    private void Awake()
    {
        _layout = KeyboardLayout.Eng;
    }
}
