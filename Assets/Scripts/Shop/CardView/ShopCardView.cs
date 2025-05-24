using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Zenject;

public class ShopCardView : MonoBehaviour,IPointerClickHandler
{
    public event Action<ShopCardView> Click;
   
    [SerializeField]
    protected Image cardImg;
    [SerializeField]
    protected Image currencyImg;
    [SerializeField]
    protected TMP_Text nameCard;
    [SerializeField]
    protected TMP_Text storyCard;
    [SerializeField]
    protected TMP_Text priceCard;
    [SerializeField]
    protected Button buyButton;
   
    public CardSO cardData { get; private set; }   
    public virtual void Initialize(CardSO card, Sprite currency)
    {

        cardData = card;
        currencyImg.sprite = currency;
        cardImg.sprite = cardData.getImgCard;
        nameCard.text = cardData.getNameCard;
        storyCard.text = cardData.getStoryCard;
        priceCard.text = cardData.getCoast.ToString();
    }
    private void OnEnable()
    {
        buyButton.onClick.AddListener(BuyButton);
       
    }

    private void OnDisable()
    {
        buyButton.onClick.RemoveListener(BuyButton);

    }
    public virtual void BuyButton()
    {
        
    }


    public void OnPointerClick(PointerEventData eventData) => Click?.Invoke(this);



}
