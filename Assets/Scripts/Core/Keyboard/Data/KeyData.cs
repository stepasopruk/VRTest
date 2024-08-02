using System;
using System.Collections.Generic;
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
            [SerializeField] private List<char> keyLetters;

            public KeyboardLayout KeyboardLayout => keyboardLayout;
            public List<char> KeyLetters => keyLetters;

            private List<char> _keyUpLetters;
            public List<char> KeyUpLetters 
            {
                get
                {
                    if(_keyUpLetters == null)
                    {
                        _keyUpLetters = new List<char>();
                        keyLetters.ForEach(x => _keyUpLetters.Add(x.ToString().ToUpper().First()));
                    }

                    return _keyUpLetters;
                }
            }
        }


        [SerializeField] private List<char> keysSymbol;
        [SerializeField] private List<KeysLayout> keysLayout;

        public KeysLayout GetKeysLayout(KeyboardLayout keyboardLayout)
            => keysLayout.FirstOrDefault(keys => keys.KeyboardLayout == keyboardLayout);
    }
}
