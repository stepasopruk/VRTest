using KeyboardVR;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class KeyboardKeyKitController : MonoBehaviour, IKeyboardKeyKitController
{
    [Serializable]
    private class KeyKit
    {
        [SerializeField] private KeyButton[] activeKeys;
        [SerializeField] private KeyKitType keyKitType;
        public KeyButton[] ActiveKeys => activeKeys;
        public KeyKitType KeyKitType => keyKitType;
    }

    public event Action<KeyKitType> KeySetChanged;

    [SerializeField] private KeyButton[] allKeys;
    [SerializeField] private KeyKit[] keyKits;

    private KeyKitType _keyKitType;

    public void SetKeyKitType(KeyKitType keyKitType)
    {
        if (_keyKitType == keyKitType)
            return;

        _keyKitType = keyKitType;
        SwitchKeykit(_keyKitType);
    }

    private void SwitchKeykit(KeyKitType keySet)
    {
        KeyKit[] activeKeyKits = keyKits.Select(x => x).Where(type => type.KeyKitType == keySet).ToArray();
        HashSet<KeyButton> activeAllKeys = new();

        foreach (KeyKit keyKit in activeKeyKits)
            foreach (KeyButton keyButton in keyKit.ActiveKeys)
                activeAllKeys.Add(keyButton);

        KeyButton[] inactiveAllKeys = allKeys.Except(activeAllKeys).ToArray();

        foreach (KeyButton keyButton in inactiveAllKeys)
            keyButton.gameObject.SetActive(false);

        foreach (KeyButton keyButton in activeAllKeys)
            keyButton.gameObject.SetActive(true);
    }
}