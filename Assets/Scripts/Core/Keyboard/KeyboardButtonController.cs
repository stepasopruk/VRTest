using System.Collections.Generic;
using UnityEngine;

public class KeyboardButtonController : MonoBehaviour
{
    [SerializeField] private KeyboardController keyboardController;
    [SerializeField] private List<KeyboardRow> rows;

    private void Awake()
    {
        foreach (KeyboardRow row in rows)
        {
            foreach (KeyButton keyButton in row.KeysButton)
                keyButton.KeyPressed += KeyButton_KeyPressed;

            foreach (KeySpecialButton keySpecialButton in row.KeysSpecialButtons)
                keySpecialButton.KeyPressed += KeySpecialButton_KeyPressed;
        }
    }

    private void OnDestroy()
    {
        foreach (KeyboardRow row in rows)
        {
            foreach (KeyButton keyButton in row.KeysButton)
                keyButton.KeyPressed -= KeyButton_KeyPressed;

            foreach (KeySpecialButton keySpecialButton in row.KeysSpecialButtons)
                keySpecialButton.KeyPressed -= KeySpecialButton_KeyPressed;
        }
    }

    private void KeySpecialButton_KeyPressed(string action) => 
        keyboardController.KeySpecialPress(action);

    private void KeyButton_KeyPressed(char key) => 
        keyboardController.KeyPress(key);

}
