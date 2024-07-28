using System;

namespace VRTest.Core.Interactible
{
    public class ButtonBNGEvents : ButtonBNGViewBase, IButtonCliked
    {
        public event Action Clicked;

        protected override void OnButtonDown()
        {
            Clicked?.Invoke();
        }
    }
}