using KeyboardVR;
using System;
using System.Linq;
using TMPro;
using UnityEngine;
using VRTest.Core.UI;
using Zenject;

public abstract class KeyButton : ButtonUIViewBase
{
    [Inject] private readonly IKeyHandler _keyHandler;

    [SerializeField] private TextMeshProUGUI buttonText;

    private void OnValidate()
    {
        buttonText ??= GetComponentInChildren<TextMeshProUGUI>();
    }

    protected string Text
    {
        get => buttonText.text;
        set => buttonText.text = value;
    }

    protected override void OnClick() => 
        _keyHandler.KeyPress(buttonText.text.ToCharArray().First());

    public abstract void SetKeyLayout(KeyboardLayout keyboardLayout);

}


