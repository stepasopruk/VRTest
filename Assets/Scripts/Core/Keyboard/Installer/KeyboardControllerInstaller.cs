using UnityEngine;
using Zenject;

public class KeyboardControllerInstaller : MonoInstaller
{
    [SerializeField] private KeyboardKeyKitController keyboardKeyKitController;
    [SerializeField] private KeyboardLayoutController keyboardLayoutController;

    public override void InstallBindings()
    {
        Container
            .Bind<IKeyboardKeyKitController>()
            .FromInstance(keyboardKeyKitController)
            .AsSingle()
            .NonLazy();

        Container
            .Bind<IKeyboardLayoutController>()
            .FromInstance(keyboardLayoutController)
            .AsSingle()
            .NonLazy();
    }
}
