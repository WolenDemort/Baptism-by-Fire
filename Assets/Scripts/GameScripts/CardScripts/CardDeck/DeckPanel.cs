using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DeckPanel : MonoBehaviour
{

    Hand hand;

    [SerializeField]
    private Transform _armPlayer;
    [SerializeField]
    private DeckFactory deckFactory;
    [SerializeField]
    private int _countCardInArm;

   
    public void HandConstructor(Hand h)
    {
        hand = h;
        StartingHand();
    }



    public void Spawn(List<CardSO> cards) //спавн карт
    {
        
        // Выводим результат
        foreach (CardSO card in cards)
        {
            CardView spawnedCard = deckFactory.Get(card, _armPlayer);
            hand.cardOnHand.Add(spawnedCard);
        }

    }

    public void StartingHand() //начальная игровая рука 
    {       
        
        hand.remainingСards = Shuffle(hand.Cards.AllCards); 
        
        List<CardSO> randomCards = hand.remainingСards.Take(_countCardInArm).ToList();

        Spawn(randomCards);

        hand.remainingСards = ListCut(hand.remainingСards, randomCards);
       
    }


    public void AddCardInArm(int countAddCart) // добавление карты в руку и количество карт
    {
        if (hand.remainingСards.Count != 0)
        {
            if (countAddCart > hand.remainingСards.Count)
            {
                countAddCart = hand.remainingСards.Count;
            }

            List<CardSO> addCards = hand.remainingСards.Take(countAddCart).ToList();
            Spawn(addCards);

            hand.remainingСards = ListCut(hand.remainingСards, addCards);
           
        }
        else
        {
            Debug.Log("Колода пустая");
        }
    }


   
    private List<CardSO> Shuffle(List<CardSO> cards)
    {
        // Алгоритм Fisher-Yates shuffle
        for (int i = cards.Count - 1; i > 0; i--)
        {
            int j = Random.Range(0, i + 1);
            CardSO temp = cards[i];
            cards[i] = cards[j];
            cards[j] = temp;
        }

        return cards;
    }

    public List<CardSO> ListCut(List<CardSO> list1, List<CardSO> list2) //убрать из одного списка другой
    {
        // Группируем элементы второго списка по количеству вхождений
        var counts = list2.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        // Фильтруем первый список
        return list1.GroupBy(x => x).SelectMany(g => g.Take(g.Count() - (counts.ContainsKey(g.Key) ? counts[g.Key] : 0))).ToList();
    }



    public void Clear()
    {
        foreach (CardView item in hand.cardOnHand)
        {
           // item.Click -= OnItemViewClick; напоминание отписываться от ивентов
            Destroy(item.gameObject);
        }
        hand.cardOnHand.Clear();
    }
}
