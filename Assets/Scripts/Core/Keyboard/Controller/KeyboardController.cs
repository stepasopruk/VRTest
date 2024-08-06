using KeyboardVR;
using System;
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

    private bool _isSymbolKeys;
    public bool IsSymbolKeys
    {
        get => _isSymbolKeys;
        set
        {
            if (_isSymbolKeys == value)
                return;

            _isSymbolKeys = value;
            keyboardView.SwitchKeys(_isSymbolKeys);
        }
    }

    private void Awake()
    {
        _layout = KeyboardLayout.Eng;
    }
}