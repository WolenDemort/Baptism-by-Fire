using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DeckPanel : MonoBehaviour
{
    private List<CardView> _deck = new List<CardView>();
   

    List<CardSO> allCards;
    List<CardSO> remaining�ards;


    [SerializeField]
    private Transform _armPlayer;
    [SerializeField]
    private DeckFactory deckFactory;
    [SerializeField]
    private int _countCardInArm;

    public void SpawnCard(IEnumerable<CardSO> cards)
    {
        allCards = cards.ToList();
        StartingHandd();
    }


    public void Spawn(List<CardSO> cards)
    {
        // Clear();

        // ������� ���������
        foreach (CardSO card in cards)
        {
            CardView spawnedCard = deckFactory.Get(card, _armPlayer);
            _deck.Add(spawnedCard);
        }

    }

    public void StartingHandd()
    {
       
        remaining�ards = Shuffle(allCards);         
        List<CardSO> randomCards = remaining�ards.Take(_countCardInArm).ToList();
        Spawn(randomCards);
        remaining�ards = ListCUt(remaining�ards, randomCards);
        foreach (CardSO card in remaining�ards)
        {
            Debug.Log(card.getNameCard);
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

    public List<CardSO> ListCUt(List<CardSO> list1, List<CardSO> list2) //������ �� ������ ������ ������
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
