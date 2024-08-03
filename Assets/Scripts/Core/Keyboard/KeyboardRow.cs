using System.Collections.Generic;
using UnityEngine;

public class KeyboardRow : MonoBehaviour
{
    [SerializeField] private List<KeyButton> keysButtons;
    [SerializeField] private List<KeySpecialButton> keysSpecialButtons;

    public KeyButton[] KeysButton => keysButtons.ToArray();
    public KeySpecialButton[] KeysSpecialButtons => keysSpecialButtons.ToArray();
}
