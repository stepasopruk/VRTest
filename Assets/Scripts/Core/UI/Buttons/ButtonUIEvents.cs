using System;

namespace VRTest.Core.UI
{
    public sealed class ButtonUIEvents : ButtonUIViewBase, IButtonCliked
    {
        public event Action Clicked;

        protected override void OnClick()
        {
            Clicked?.Invoke();
        }
    }
}