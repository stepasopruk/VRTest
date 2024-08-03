using System;
using UnityEngine;
using VRTest.Core.UI;

public class KeySpecialButton : ButtonUIViewBase
{
    public event Action<string> KeyPressed;

    [SerializeField] private string actionName;

    protected override void OnClick()
    {
        KeyPressed?.Invoke(actionName);
    }
}
