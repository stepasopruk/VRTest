using UnityEngine;

[CreateAssetMenu(fileName = "KeyNumberData", menuName = "ScriptableObjects/AddKeyNumberData", order = 1)]
public class KeyNumberData : ScriptableObject
{
    [SerializeField] private char key;
    public char Key => key;
}
