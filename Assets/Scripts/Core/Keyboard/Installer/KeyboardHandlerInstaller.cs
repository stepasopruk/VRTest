using Zenject;

public class KeyboardHandlerInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container
            .BindInterfacesTo<KeyboardHandler>()
            .AsSingle()
            .NonLazy();
    }

}
