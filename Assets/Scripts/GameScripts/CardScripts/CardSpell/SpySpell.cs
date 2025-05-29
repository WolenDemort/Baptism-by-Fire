using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
public class SpySpell : MonoBehaviour, ICardSpell
{
    [Inject] private DeckPanel deckPanel;
    public void Awake()
    {
        DiContainer container = DIManager.GetContainer();
        deckPanel = container.Resolve<DeckPanel>();
    }
    public void Spell()
    {
        deckPanel.AddCardInArm(1);
    }
   
}
