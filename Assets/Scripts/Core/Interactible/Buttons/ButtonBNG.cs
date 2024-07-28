using System;

public class ButtonBNG : ButtonBNGViewBase, IButtonCliked
{
    public event Action Clicked;

    protected override void OnButtonDown()
    {
        Clicked?.Invoke();
    }
}
