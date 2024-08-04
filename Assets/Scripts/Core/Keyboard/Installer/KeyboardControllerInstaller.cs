using UnityEngine;
using Zenject;

public class KeyboardControllerInstaller : MonoInstaller
{
    [SerializeField] private KeyboardController keyboardController;

    public override void InstallBindings()
    {
        Container
            .BindInterfacesTo<KeyboardController>()
            .FromInstance(keyboardController)
            .AsSingle()
            .NonLazy();
    }
}
