using VRTest.Core.UI;
using Zenject;

public abstract class KeySpecialButton : ButtonUIViewBase
{
    [Inject] protected readonly ISpecialKeyHandler specialKeyHandler;

    private bool _isOn = false;

    protected override void OnClick()
    {
        _isOn = !_isOn;
        KeyPress(_isOn);
    }

    protected abstract void KeyPress(bool isOn);
}
