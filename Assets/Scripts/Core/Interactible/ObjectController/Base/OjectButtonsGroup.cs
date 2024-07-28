using UnityEngine;
using VRTest.Core.UI;

namespace VRTest.Core.Interactible
{
    public abstract class OjectButtonsGroup : MonoBehaviour
    {
        [SerializeField] private ButtonUIEvents buttonUI;
        [SerializeField] private ButtonBNGEvents buttonBNG;

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
}