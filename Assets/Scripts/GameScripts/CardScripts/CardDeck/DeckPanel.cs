using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DeckPanel : MonoBehaviour
{
    private List<CardView> _deck = new List<CardView>();//������� ������ �� �����
   

    List<CardSO> allCards;//��� ������� ����� 
    List<CardSO> remaining�ards; //���������� ����� �� ������


    [SerializeField]
    private Transform _armPlayer;
    [SerializeField]
    private DeckFactory deckFactory;
    [SerializeField]
    private int _countCardInArm;

    public void SetAllCardsInPlayingDeck(IEnumerable<CardSO> cards)
    {
        allCards = cards.ToList();
        StartingHand();
    }


    public void Spawn(List<CardSO> cards) //����� ����
    {
        
        // ������� ���������
        foreach (CardSO card in cards)
        {
            CardView spawnedCard = deckFactory.Get(card, _armPlayer);
            _deck.Add(spawnedCard);
        }

    }

    public void StartingHand() //��������� ������� ���� 
    {       
        remaining�ards = Shuffle(allCards); 
        
        List<CardSO> randomCards = remaining�ards.Take(_countCardInArm).ToList();

        Spawn(randomCards);

        remaining�ards = ListCut(remaining�ards, randomCards);
       
    }


    public void AddCardInArm(int countAddCart) // ���������� ����� � ���� � ���������� ����
    {
        if (remaining�ards.Count != 0)
        {
            if (countAddCart > remaining�ards.Count)
            {
                countAddCart = remaining�ards.Count;
            }

            List<CardSO> addCards = remaining�ards.Take(countAddCart).ToList();
            Spawn(addCards);

            remaining�ards = ListCut(remaining�ards, addCards);
           
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
        foreach (CardView item in _deck)
        {
           // item.Click -= OnItemViewClick; ����������� ������������ �� �������
            Destroy(item.gameObject);
        }
        _deck.Clear();
    }
}
