using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class KingCardShopView : ShopCardView
{


    public KingCardSO kingCardData { get; private set; }

    [SerializeField]
    private TMP_Text spellStory;
    [SerializeField]
    private GameObject LorZone;

    public override void Initialize(CardSO cardSO, Sprite currency)
    {
        if (!(cardSO is KingCardSO))
        {
            throw new System.ArgumentException("Не KingCardSO");
        }
        kingCardData = cardSO as KingCardSO;
        currencyImg.sprite = currency;
        cardImg.sprite = kingCardData.getImgCard;
        nameCard.text = kingCardData.getNameCard;        
        priceCard.text = kingCardData.getCoast.ToString();

        storyCard.text = kingCardData.getStoryCard;
        spellStory.text = kingCardData.getSpellStory;
    }

    public void LorShow()
    {
        if (LorZone.activeSelf)
        {
            LorZone.SetActive(false);
        }
        else {
            LorZone.SetActive(true); ;
        }

    }

   public override void BuyButton()
    {
       
        DiContainer container = DIManager.GetContainer();
        ShoppingSystem shop = container.Resolve<ShoppingSystem>();
        UIMoneyText moneyText = container.Resolve<UIMoneyText>();
        IStorageSystem storageSystem = new SaveSystem();
        if (shop.Buy(kingCardData.getCurrency, kingCardData.getCoast))
        {

            List<string> p = new List<string>();
            p.Add(kingCardData.name);
            storageSystem.SaveOldFile(SaveKey.AllCardsPlayer, p);
            moneyText.UIMoneyUpdate();
            gameObject.SetActive(false);
        }
    }
}
