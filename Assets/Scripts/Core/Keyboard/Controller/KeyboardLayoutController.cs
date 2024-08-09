using KeyboardVR;
using System;
using System.Linq;
using UnityEngine;

public class KeyboardLayoutController : MonoBehaviour, IKeyboardLayoutController
{
    [SerializeField] private KeyLetterButton[] letterkeys;

    public event Action<KeyboardLayout> LayoutChanged;

    private KeyboardLayout _layout;

    private void OnValidate()
    {
        letterkeys ??= FindObjectsOfType<KeyLetterButton>().ToArray();
    }

    public void SetLayoutKeyboard(KeyboardLayout layout)
    {
        if (_layout == layout)
            return;

        _layout = layout;
        SwitchLayout(_layout);
    }


    private void SwitchLayout(KeyboardLayout layout)
    {
        foreach (KeyLetterButton keyLetterButton in letterkeys)
            keyLetterButton.SetKeyLayout(layout);

        LayoutChanged?.Invoke(_layout);
    }
}
