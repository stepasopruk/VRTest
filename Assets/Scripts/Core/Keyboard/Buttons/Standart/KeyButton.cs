using KeyboardVR;
using System;
using System.Linq;
using TMPro;
using UnityEngine;
using VRTest.Core.UI;
using Zenject;

public class KeyButton : ButtonUIViewBase
{
    [Inject] private readonly IKeyHandler _keyHandler;

    [SerializeField] private TextMeshProUGUI buttonText;

    private void OnValidate()
    {
        buttonText ??= GetComponentInChildren<TextMeshProUGUI>();
    }

    public string Text
    {
        get => buttonText.text;
        protected set => buttonText.text = value;
    }

    protected override void OnClick() => 
        _keyHandler.KeyPress(buttonText.text.ToCharArray().First());
}


