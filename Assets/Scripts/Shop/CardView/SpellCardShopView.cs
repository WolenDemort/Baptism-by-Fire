using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class SpellCardShopView : ShopCardView
{
    [SerializeField]
    private Image spellImg;

    public SpellCardSO spellCardData { get; private set; }



    public override void Initialize(CardSO cardSO, Sprite currency)
    {
        if (!(cardSO is SpellCardSO))
        {
            throw new System.ArgumentException("Не SpellCardSO");
        }
        spellCardData = cardSO as SpellCardSO;

        currencyImg.sprite = currency;
        cardImg.sprite = spellCardData.getImgCard;
        nameCard.text = spellCardData.getNameCard;
        storyCard.text = spellCardData.getStoryCard;
        priceCard.text = spellCardData.getCoast.ToString();

        cardImg.sprite = spellCardData.getImgCard;
        spellImg.sprite = spellCardData.getImgSpell;


    }

   public override void BuyButton()
    {
       
        DiContainer container = DIManager.GetContainer();
        ShoppingSystem shop = container.Resolve<ShoppingSystem>();
        UIMoneyText moneyText = container.Resolve<UIMoneyText>();
        IStorageSystem storageSystem = new SaveSystem();
        if (shop.Buy(spellCardData.getCurrency, spellCardData.getCoast))
        {

            List<string> p = new List<string>();
            p.Add(spellCardData.name);
            storageSystem.SaveOldFile(SaveKey.AllCardsPlayer, p);
            moneyText.UIMoneyUpdate();
            gameObject.SetActive(false);

        }
    }
}
