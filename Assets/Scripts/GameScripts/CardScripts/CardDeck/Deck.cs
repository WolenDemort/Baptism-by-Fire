using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Deck : MonoBehaviour
{
    [SerializeField]
    private PlayingDeck _playingDeck;
    [SerializeField]
    private DeckPanel _deckPanel;

    

    public void Start()
    {
        SpawnCard();
    }

    public void SpawnCard()
    {
        _deckPanel.SpawnCard(_playingDeck.AllDeck.Cast<CardSO>());
       
    }
}
