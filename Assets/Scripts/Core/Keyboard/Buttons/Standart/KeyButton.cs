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

    protected bool _isActive;

    public bool IsActive
    {
        get => _isActive;
        set
        {
            if (value)
                gameObject.SetActive(_isActive);
            else
                gameObject.SetActive(false);
        }
    }

    private void OnValidate()
    {
        buttonText ??= GetComponentInChildren<TextMeshProUGUI>();
    }

    protected override void Awake()
    {
        base.Awake();
        _isActive = gameObject.activeSelf;
    }

    public string Text
    {
        get => buttonText.text;
        protected set => buttonText.text = value;
    }

    protected override void OnClick() => 
        _keyHandler.KeyPress(buttonText.text.ToCharArray().First());
}


