using UnityEngine;

[CreateAssetMenu(fileName = "KeySymbolData", menuName = "ScriptableObjects/AddKeySymbolData", order = 1)]
public class KeySymbolData : ScriptableObject
{
    [SerializeField] private char key;
    public char Key => key;
}