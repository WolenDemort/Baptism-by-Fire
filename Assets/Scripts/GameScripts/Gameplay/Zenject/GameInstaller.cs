using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
public class GameInstaller : MonoInstaller
{
    [SerializeField]
    DeckPanel deckPanel;
    public override void InstallBindings()
    {
        /* Container.Bind<EventBus>().FromNew().AsSingle();
         Container.Bind<ShopItemView>().FromNew().AsSingle().NonLazy();
         //таймер
         Container.Bind<Timer>().FromInstance(timerPref).AsSingle().NonLazy();
         */
        Container.Bind<DeckPanel>().FromInstance(deckPanel).AsSingle().NonLazy();
        DIManager.SetContainer(Container);
    }
}
