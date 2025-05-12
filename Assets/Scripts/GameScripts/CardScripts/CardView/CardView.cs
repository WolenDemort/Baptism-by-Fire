using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardView : MonoBehaviour
{

    [SerializeField]
    protected Image imgCard; //изображение карты
    [SerializeField]
    protected Image spellImage;//изображение способности
    protected Dictionary<SpellsChosee, Sprite> spellIcon;
    protected ZoneCardEnums zone;
    protected SpellsChosee spell;
    public CardSO cardData { get; private set; }

    public virtual void Initialize(CardSO card)
    {
       
        cardData=card;
        imgCard.sprite = cardData.getImgCard;
        spell= cardData.getSpells;
        if (spell != SpellsChosee.None)
        {
            spellImage.sprite = cardData.getImgSpell;
        }
        zone = cardData.getZoneLine;
    }
    public ZoneCardEnums getCardZone => zone;
}
