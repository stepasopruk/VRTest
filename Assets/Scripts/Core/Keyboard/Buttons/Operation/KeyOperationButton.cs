using VRTest.Core.UI;
using Zenject;

public class KeyOperationButton : ButtonUIViewBase
{
    [Inject] protected readonly IOperatingKeyHandler _operatingKeyHandler;

    protected override void OnClick() { }
}
