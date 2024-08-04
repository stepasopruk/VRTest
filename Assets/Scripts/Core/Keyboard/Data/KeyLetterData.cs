using KeyboardVR;
using System;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "KeyLetterData", menuName = "ScriptableObjects/AddKeyLetterData", order = 1)]
public class KeyLetterData : ScriptableObject
{
    [SerializeField] private KeyLayout[] keysLayout;

    public KeyLayout GetKeyLayout(KeyboardLayout keyboardLayout)
    {
        KeyLayout keyLayout = keysLayout.FirstOrDefault(keys => keys.KeyboardLayout == keyboardLayout);

        if (keyLayout == null)
            keyLayout = keysLayout.First();

        return keyLayout;
    }
}

[Serializable]
public class KeyLayout
{
    [SerializeField] private KeyboardLayout keyboardLayout;
    [SerializeField] private char keyLetter;

    public KeyboardLayout KeyboardLayout => keyboardLayout;
    public char KeyLetter => keyLetter;
}