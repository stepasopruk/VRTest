using KeyboardVR;
using UnityEngine;
using Zenject;

public class KeyboardRowView : MonoBehaviour
{
    [SerializeField] private KeyButton[] keyButtons;
    [SerializeField] private KeyOperationButton[] operationButtons;
    [SerializeField] private KeySpecialButton[] specialButtons;


    private void Awake()
    {

    }

    private void OnDestroy()
    {

    }
}
