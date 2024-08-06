using UnityEngine;
using Zenject;

public class KeyboardControllerInstaller : MonoInstaller
{
    [SerializeField] private KeyboardController keyboardController;

    public override void InstallBindings()
    {
        Container
            .Bind<IKeyboardController>()
            .FromInstance(keyboardController)
            .AsSingle()
            .NonLazy();
    }
}
