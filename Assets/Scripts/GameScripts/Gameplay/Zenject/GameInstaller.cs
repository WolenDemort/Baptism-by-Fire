using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
public class GameInstaller : MonoInstaller
{
    [SerializeField]
    DeckPanel deckPanel;
    [SerializeField]
    SwordLine[] swLines;
    [SerializeField]
    ArrowLine[] arLines;
    [SerializeField]
    CatapultesLine[] cpLines;



    [SerializeField]
    SwordLine playerSwordLine;
    [SerializeField]
    ArrowLine playerArrowLine;
    [SerializeField]
    CatapultesLine playerCatapultsLine;
    [SerializeField]
    SwordLine enemySwordLine;
    [SerializeField]
    ArrowLine enemyArrowLine;
    [SerializeField]
    CatapultesLine enemyCatapultsLine;






    public override void InstallBindings()
    {
        /* Container.Bind<EventBus>().FromNew().AsSingle();
         Container.Bind<ShopItemView>().FromNew().AsSingle().NonLazy();
         //таймер
         Container.Bind<Timer>().FromInstance(timerPref).AsSingle().NonLazy();
         */
        Container.Bind<DeckPanel>().FromInstance(deckPanel).AsSingle().NonLazy();
        Container.Bind<SwordLine[]>().FromInstance(swLines).AsSingle().NonLazy();
        Container.Bind<ArrowLine[]>().FromInstance(arLines).AsSingle().NonLazy();
        Container.Bind<CatapultesLine[]>().FromInstance(cpLines).AsSingle().NonLazy();

        Container.Bind<SwordLine>().WithId("playerSwordLine").FromInstance(playerSwordLine).NonLazy();
        Container.Bind<SwordLine>().WithId("enemySwordLine").FromInstance(enemySwordLine).NonLazy();
        Container.Bind<ArrowLine>().WithId("playerArrowLine").FromInstance(playerArrowLine).NonLazy();
        Container.Bind<ArrowLine>().WithId("enemyrArrowLine").FromInstance(enemyArrowLine).NonLazy();
        Container.Bind<CatapultesLine>().WithId("playerCatapultsLine").FromInstance(playerCatapultsLine).NonLazy();
        Container.Bind<CatapultesLine>().WithId("enemyCatapultsLine").FromInstance(enemyCatapultsLine).NonLazy();

        DIManager.SetContainer(Container);
    }
}
