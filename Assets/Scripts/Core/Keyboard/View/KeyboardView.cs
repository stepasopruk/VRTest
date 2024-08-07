using KeyboardVR;
using UnityEngine;

public sealed class KeyboardView : MonoBehaviour
{
    [SerializeField] private KeyLetterButton[] letterkeys;
    [SerializeField] private KeyNumberButton[] numberKeys;
    [SerializeField] private KeySymbolButton[] symbolKeys;


    public void SwitchLayout(KeyboardLayout layout)
    {
        foreach (KeyLetterButton keyLetterButton in letterkeys)
            keyLetterButton.SetKeyLayout(layout);
    }

    public void SwitchKeys(KeyKitType keyboardSetKey)
    {
        
    }

}
