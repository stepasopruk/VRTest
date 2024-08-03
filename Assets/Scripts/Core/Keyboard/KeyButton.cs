using System;
using System.Linq;
using TMPro;
using UnityEngine;
using VRTest.Core.UI;

public sealed class KeyButton : ButtonUIViewBase
{
    public event Action<char> KeyPressed;

    [SerializeField] private TextMeshProUGUI buttonText;

    public char ButtonText 
    { 
        get => buttonText.text.ToCharArray().First(); 
        set => buttonText.text = value.ToString(); 
    }

    protected override void OnClick()
    {
        KeyPressed?.Invoke(ButtonText);
    }
}
