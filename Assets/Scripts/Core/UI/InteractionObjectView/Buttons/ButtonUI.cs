using System;
using System.Collections.Generic;

public class ButtonUI : ButtonUIViewBase, IButtonCliked
{
    public event Action Clicked;

    protected override void OnClick()
    {
        Clicked?.Invoke();
    }
}
