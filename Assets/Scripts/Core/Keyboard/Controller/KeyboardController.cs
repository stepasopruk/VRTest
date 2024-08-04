using KeyboardVR;
using System;
using UnityEngine;

public class KeyboardController : MonoBehaviour, IKeyboardLayout, ILayoutSwitchEvent
{
    public event Action<KeyboardLayout> LayoutChanged;

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
            LayoutChanged?.Invoke(_layout);
        }
    }

    private void Awake()
    {
        _layout = KeyboardLayout.Eng;
    }
}