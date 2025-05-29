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



    public void Spawn(List<CardSO> cards) //����� ����
    {
        
        // ������� ���������
        foreach (CardSO card in cards)
        {
            CardView spawnedCard = deckFactory.Get(card, _armPlayer);
            hand.cardOnHand.Add(spawnedCard);
        }

    }

    public void StartingHand() //��������� ������� ���� 
    {       
        
        hand.remaining�ards = Shuffle(hand.Cards.AllCards); 
        
        List<CardSO> randomCards = hand.remaining�ards.Take(_countCardInArm).ToList();

        Spawn(randomCards);

        hand.remaining�ards = ListCut(hand.remaining�ards, randomCards);
       
    }


    public void AddCardInArm(int countAddCart) // ���������� ����� � ���� � ���������� ����
    {
        if (hand.remaining�ards.Count != 0)
        {
            if (countAddCart > hand.remaining�ards.Count)
            {
                countAddCart = hand.remaining�ards.Count;
            }

            List<CardSO> addCards = hand.remaining�ards.Take(countAddCart).ToList();
            Spawn(addCards);

            hand.remaining�ards = ListCut(hand.remaining�ards, addCards);
           
        }
        else
        {
            Debug.Log("������ ������");
        }
    }


   
    private List<CardSO> Shuffle(List<CardSO> cards)
    {
        // �������� Fisher-Yates shuffle
        for (int i = cards.Count - 1; i > 0; i--)
        {
            int j = Random.Range(0, i + 1);
            CardSO temp = cards[i];
            cards[i] = cards[j];
            cards[j] = temp;
        }

        return cards;
    }

    public List<CardSO> ListCut(List<CardSO> list1, List<CardSO> list2) //������ �� ������ ������ ������
    {
        // ���������� �������� ������� ������ �� ���������� ���������
        var counts = list2.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        // ��������� ������ ������
        return list1.GroupBy(x => x).SelectMany(g => g.Take(g.Count() - (counts.ContainsKey(g.Key) ? counts[g.Key] : 0))).ToList();
    }



    public void Clear()
    {
        foreach (CardView item in hand.cardOnHand)
        {
           // item.Click -= OnItemViewClick; ����������� ������������ �� �������
            Destroy(item.gameObject);
        }
        hand.cardOnHand.Clear();
    }
}
