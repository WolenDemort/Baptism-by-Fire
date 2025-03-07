using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Card/PlayingDeck", fileName = "Playing Deck")]
public class PlayingDeck : ScriptableObject
{
   
   [SerializeField] private List<CardSO> _allCards;
    public IEnumerable<CardSO> AllDeck => _allCards;
   
}

