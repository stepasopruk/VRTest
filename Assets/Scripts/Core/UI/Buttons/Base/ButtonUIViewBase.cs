using UnityEngine;
using UnityEngine.UI;

namespace VRTest.Core.UI
{
    [RequireComponent(typeof(Button))]
    public abstract class ButtonUIViewBase : MonoBehaviour
    {
        protected Button _button;

        protected virtual void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(OnClick);
        }

        protected virtual void OnDestroy()
        {
            _button.onClick.RemoveListener(OnClick);
        }

        protected abstract void OnClick();
    }
}