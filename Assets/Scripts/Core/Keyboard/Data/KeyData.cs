using System;
using System.Linq;
using UnityEngine;

namespace KeyboardVR.Data
{
    [CreateAssetMenu(fileName = "KeyData", menuName = "ScriptableObjects/AddKeyLayoutData", order = 1)]
    public class KeyData : ScriptableObject
    {
        [Serializable]
        public class KeysLayout
        {
            [SerializeField] private KeyboardLayout keyboardLayout;
            [SerializeField] private char[] keyLetters;

            public KeyboardLayout KeyboardLayout => keyboardLayout;
            public char[] KeyLetters => keyLetters;
        }

        [SerializeField] private KeysLayout[] keysLayout;

        public char[] GetKeysLayout(KeyboardLayout keyboardLayout)
            => keysLayout.FirstOrDefault(keys => keys.KeyboardLayout == keyboardLayout).KeyLetters;
    }
}
