using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand 
{

    public List<CardView> cardOnHand { get; set; } = new();//текущие карты в руке
    public PlayingDeck Cards { get; private set; }//колода
    public List<CardSO> remainingСards { get; set; } = new(); //оставшиеся карты из колоды

    public Hand(PlayingDeck deck)
    {
        Cards = deck;

    }
    public Hand()
    {

    }

}
