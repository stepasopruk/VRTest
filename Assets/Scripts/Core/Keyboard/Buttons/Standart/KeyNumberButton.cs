using KeyboardVR;
using UnityEngine;

public sealed class KeyNumberButton : KeyButton
{
    [SerializeField] private KeyNumberData keyNumberData;

    protected override void Awake()
    {
        base.Awake();
        Text = keyNumberData.Key.ToString();
    }

    public override void SetKeyLayout(KeyboardLayout keyboardLayout)
    {
        return;
    }
}


