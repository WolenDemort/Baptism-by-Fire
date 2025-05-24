using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Shop/Shop Factory", fileName = "Shop factory")]
public class ShopFactory : ScriptableObject
{
    [SerializeField] private ShopCardView _simpleCarShopPref;
    [SerializeField] private ShopCardView _spellCarShopdPref;
    [SerializeField] private ShopCardView _kingCardShopPref;

    [SerializeField] private Sprite gold;
    [SerializeField] private Sprite silver;
    public ShopCardView Get(CardSO shopItem, Transform parent)
    {

        ShopCardView instance;
        Sprite currency;
        if (shopItem.getCurrency == CurrencyType.Gold)
        {
            currency = gold;
        }
        else
        {
            currency = silver;
        }

        switch (shopItem)
        {

            case RegularCardSO:
                instance = Instantiate(_simpleCarShopPref, parent);
                break;

            case SpellCardSO:
                instance = Instantiate(_spellCarShopdPref, parent);
                break;
            case KingCardSO:
                instance = Instantiate(_kingCardShopPref, parent);
                break;
            default:
                throw new System.Exception("Нет такого типа для магазина");
        }

        instance.Initialize(shopItem, currency);
        return instance;
    }

}