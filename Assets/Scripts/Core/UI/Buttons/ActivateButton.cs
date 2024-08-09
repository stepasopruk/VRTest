using UnityEngine;

namespace VRTest.Core.UI
{
    public sealed class ActivateButton : ButtonUIViewBase
    {
        [SerializeField] private GameObject activeObject;
        [SerializeField] private GameObject inactiveObject;

        private bool isActivate;

        protected override void OnClick()
        {
            isActivate = !isActivate;

            if (activeObject != null)
                activeObject.SetActive(isActivate);

            if (inactiveObject != null)
                inactiveObject.SetActive(!isActivate);
        }
    }
}