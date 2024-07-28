using UnityEngine;

public abstract class OjectButtonsGroup : MonoBehaviour
{
    [SerializeField] private ButtonUI buttonUI;
    [SerializeField] private ButtonBNG buttonBNG;

    protected virtual void Awake()
    {
        buttonUI.Clicked += Clicked;
        buttonBNG.Clicked += Clicked;
    }

    protected virtual void OnDestroy()
    {
        buttonUI.Clicked -= Clicked;
        buttonBNG.Clicked -= Clicked;
    }

    protected abstract void Clicked();
}
