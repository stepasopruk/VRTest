using KeyboardVR;
using UnityEngine;

public sealed class KeySymbolButton : KeyButton
{
    [SerializeField] private KeySymbolData keySymbolData;

    protected override void Awake()
    {
        base.Awake();
        Text = keySymbolData.Key.ToString();
    }

    public override void SetKeyLayout(KeyboardLayout keyboardLayout)
    {
        return;
    }
}


