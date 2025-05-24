using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class UIInstaller : MonoInstaller
{
    [SerializeField]
    UIMoneyText money;
    public override void InstallBindings()
    {
        Container.Bind<UIMoneyText>().FromInstance(money).AsSingle().NonLazy();
        Container.Bind<ShoppingSystem>().AsSingle().NonLazy();
        DIManager.SetContainer(Container);


    }
}
