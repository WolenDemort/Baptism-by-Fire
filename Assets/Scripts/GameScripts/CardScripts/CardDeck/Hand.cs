using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand 
{

    public List<CardView> cardOnHand { get; set; } = new();//������� ����� � ����
    public PlayingDeck Cards { get; private set; }//������
    public List<CardSO> remaining�ards { get; set; } = new(); //���������� ����� �� ������

    public Hand(PlayingDeck deck)
    {
        Cards = deck;

    }
    public Hand()
    {

    }

}
