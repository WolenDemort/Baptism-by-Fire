using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Card/Deck/Deck Factory", fileName = "Deck factory")]
public class DeckFactory : ScriptableObject
{
    [SerializeField] private CardView _regularCardPref;
    [SerializeField] private CardView _spellCardPref;

    public CardView Get(CardSO deckItem, Transform parent)
    {

        CardView instance;
        switch (deckItem)
        {
            case RegularCardSO:
                instance = Instantiate(_regularCardPref, parent);
                break;

            case SpellCardSO:
                instance = Instantiate(_spellCardPref, parent);
                break;

            default:
                throw new System.Exception("Нет такого типа для магазина");
        }

        instance.Initialize(deckItem);
        return instance;
    }

}