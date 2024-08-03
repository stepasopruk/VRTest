using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public sealed class KeyboardController : MonoBehaviour
{
    
    private Dictionary<string, UnityAction> actions = new();

    private void Awake()
    {
        InitializeActions();
    }

    public void KeyPress(char key)
    {

    }

    public void KeySpecialPress(string action)
    {
        UnityAction unityAction = actions[action];

        if (unityAction != null)
            unityAction.Invoke();
    }

    private void InitializeActions()
    {
        actions.Add("Shift", Shift);
        actions.Add("SwitchLayout", SwitchLayout);
        actions.Add("SwitchKeys", SwitchKeys);
    }

    private void Shift()
    {

    }

    private void SwitchLayout()
    {

    }

    private void SwitchKeys()
    {

    }
}
