using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
public class EnemyControl : MonoBehaviour
{

    Hand hand;
    [SerializeField]
    DeckPanel panel;


    [SerializeField]
    PlayingDeck[] enemyDecks;

    [SerializeField]
    ScoreControl enemyScore;
    [SerializeField]
    ScoreControl playerScore;

    [Inject(Id = "playerSwordLine")]
    SwordLine playerSwordLine;
    [Inject(Id = "playerArrowLine")]
    ArrowLine playerArrowLine;
    [Inject(Id = "playerCatapultsLine")]
    CatapultesLine playerCatapultsLine;
    [Inject(Id = "enemySwordLine")]
    SwordLine enemySwordLine;
    [Inject(Id = "enemyrArrowLine")]
    ArrowLine enemyArrowLine;
    [Inject(Id = "enemyCatapultsLine")]
    CatapultesLine enemyCatapultsLine;


    void Start()
    {     
        hand=new Hand(enemyDecks[0]);
        panel.HandConstructor(hand);
    }
    /// <summary>
    /// ошибка
    /// </summary>
    public void Turn()
    {
        
        int rand= Random.Range(0, 1);
        CardView cardFromDrop = hand.cardOnHand[rand];
       
        SetCardPositon(cardFromDrop);
      
        hand.cardOnHand.Remove(cardFromDrop);
    }


    public void SetCardPositon(CardView cardFromDrop)
    {
        try
        {
            if (cardFromDrop.getCardZone.HasFlag(ZoneCardEnums.MySwordsmens))
            {

                cardFromDrop.transform.SetParent(playerSwordLine.BigLine.transform);
            }
            if (cardFromDrop.getCardZone.HasFlag(ZoneCardEnums.MySwordsmensBuff))
            {
                cardFromDrop.transform.SetParent(playerSwordLine.BuffLine.transform);
            }
            if (cardFromDrop.getCardZone.HasFlag(ZoneCardEnums.EnemySwordsmens))
            {
                cardFromDrop.transform.SetParent(enemySwordLine.BigLine.transform);
            }
            if (cardFromDrop.getCardZone.HasFlag(ZoneCardEnums.EnemySwordsmensBuff))
            {
                cardFromDrop.transform.SetParent(enemySwordLine.BuffLine.transform);
            }

            if (cardFromDrop.getCardZone.HasFlag(ZoneCardEnums.MyArrows))
            {
                cardFromDrop.transform.SetParent(playerArrowLine.BigLine.transform);
            }
            if (cardFromDrop.getCardZone.HasFlag(ZoneCardEnums.MyArrowsBuff))
            {
                cardFromDrop.transform.SetParent(playerArrowLine.BuffLine.transform);
            }
            if (cardFromDrop.getCardZone.HasFlag(ZoneCardEnums.EnemyArrows))
            {
                cardFromDrop.transform.SetParent(enemyArrowLine.BigLine.transform);
            }
            if (cardFromDrop.getCardZone.HasFlag(ZoneCardEnums.EnemyArrowsBuff))
            {
                cardFromDrop.transform.SetParent(enemyArrowLine.BuffLine.transform);
            }

            if (cardFromDrop.getCardZone.HasFlag(ZoneCardEnums.MyCatapults))
            {
                cardFromDrop.transform.SetParent(playerCatapultsLine.BigLine.transform);
            }
            if (cardFromDrop.getCardZone.HasFlag(ZoneCardEnums.MyCatapultsBuff))
            {
                cardFromDrop.transform.SetParent(playerCatapultsLine.BuffLine.transform);
            }
            if (cardFromDrop.getCardZone.HasFlag(ZoneCardEnums.EnemyCatapults))
            {
                cardFromDrop.transform.SetParent(enemyCatapultsLine.BigLine.transform);
            }
            if (cardFromDrop.getCardZone.HasFlag(ZoneCardEnums.EnemyCatapultsBuff))
            {
                cardFromDrop.transform.SetParent(enemyCatapultsLine.BuffLine.transform);
            }

        }
        catch
        {
            Debug.Log(cardFromDrop.cardData.name);
        }

    }


    public PlayingDeck RandDeck()
    {
        int rand = Random.Range(0, enemyDecks.Length);
       return enemyDecks[rand];

    }

    public void CardMove()
    {


    }
}
