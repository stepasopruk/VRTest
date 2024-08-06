using KeyboardVR;
using UnityEngine;
using Zenject;

public sealed class KeyLetterButton : KeyButton
{
    [SerializeField] private KeyLetterData keyLetterData;

    public void SetKeyLayout(KeyboardLayout keyboardLayout)
    {
        ActiveButton(keyboardLayout);
        Text = keyLetterData.GetKeyLayout(keyboardLayout).KeyLetter.ToString();
    }

    public void SetShiftKey(bool isOn) =>
        Text = isOn ? Text.ToUpper() : Text.ToLower();

    private void ActiveButton(KeyboardLayout keyboardLayout)
    {
        if (keyLetterData.GetKeyLayout(keyboardLayout).KeyboardLayout == keyboardLayout)
            gameObject.SetActive(true);
        else
            gameObject.SetActive(false);
    }
}


