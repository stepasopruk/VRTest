using System;

public class ButtonBNGEvents : ButtonBNGViewBase, IButtonCliked
{
    public event Action Clicked;

    protected override void OnButtonDown()
    {
        Clicked?.Invoke();
    }
}
