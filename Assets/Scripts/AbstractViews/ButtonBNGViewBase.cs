using BNG;
using UnityEngine;

[RequireComponent(typeof(Button))]
public abstract class ButtonBNGViewBase : MonoBehaviour
{
    protected Button _button;

    protected virtual void Awake()
    {
        _button = GetComponent<Button>();
        _button.onButtonDown.AddListener(OnButtonDown);
        _button.onButtonUp.AddListener(OnButtonUp);
    }

    protected virtual void OnDestroy()
    {
        _button.onButtonDown.RemoveListener(OnButtonDown);
        _button.onButtonUp.RemoveListener(OnButtonUp);
    }

    protected abstract void OnButtonDown();

    protected virtual void OnButtonUp() { }

}
