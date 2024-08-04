using VRTest.Core.UI;
using Zenject;

public class KeySpecialButton : ButtonUIViewBase
{
    [Inject] protected readonly ISpecialKeyHandler specialKeyHandler;
    protected bool _isOn = false;
    protected override void OnClick() 
    {
        _isOn = !_isOn;
    }
}
