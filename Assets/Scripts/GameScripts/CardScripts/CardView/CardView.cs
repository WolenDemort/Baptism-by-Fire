using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardView : MonoBehaviour
{

    [SerializeField]
    protected Image imgCard; //����������� �����
    [SerializeField]
    protected Image spellImage;//����������� �����������

    protected SpellsChosee spells;
    public CardSO cardData { get; private set; }

    public virtual void Initialize(CardSO card)
    {
        cardData=card;
        imgCard.sprite = cardData.getImgCard;
       spells= cardData.getSpells;
    }

}
