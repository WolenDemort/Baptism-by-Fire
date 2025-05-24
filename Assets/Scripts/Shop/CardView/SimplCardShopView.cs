using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class SimplCardShopView : ShopCardView
{
    [SerializeField]
    private Image lineImg;
    [SerializeField]
    private Image spellImg;
    [SerializeField]
    private TMP_Text scoreCard;

    public RegularCardSO regularCardData { get; private set; }

    public override void Initialize(CardSO cardSO, Sprite currency) //первичная установка данных
    {
        if (!(cardSO is RegularCardSO))
        {
            throw new System.ArgumentException("Не RegularCardSO");
        }
        regularCardData = cardSO as RegularCardSO;

        cardImg.sprite = regularCardData.getImgCard;

        scoreCard.text = regularCardData.getScoreCard.ToString();

        cardImg.sprite = regularCardData.getImgCard;
        nameCard.text = regularCardData.getNameCard;
        storyCard.text = regularCardData.getStoryCard;
        priceCard.text = regularCardData.getCoast.ToString();
        currencyImg.sprite = currency;

        if (regularCardData.getSpells != SpellsChosee.None)
        {
            spellImg.sprite = regularCardData.getImgSpell;
        }
        else
        {
            spellImg.enabled = false;
        }
                
    }

    public override void BuyButton()
    {

        DiContainer container = DIManager.GetContainer();
        ShoppingSystem shop = container.Resolve<ShoppingSystem>();
        UIMoneyText moneyText = container.Resolve<UIMoneyText>();
        IStorageSystem storageSystem = new SaveSystem();
        if (shop.Buy(regularCardData.getCurrency, regularCardData.getCoast))
        {
            List<string> p = new List<string>();
            p.Add(regularCardData.name);
            storageSystem.SaveOldFile(SaveKey.AllCardsPlayer,p);
            moneyText.UIMoneyUpdate();
            gameObject.SetActive(false);
        }
    }
}
