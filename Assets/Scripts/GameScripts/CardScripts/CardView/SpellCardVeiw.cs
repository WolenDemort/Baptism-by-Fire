using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpellCardVeiw : CardView
{
       [SerializeField]
    private Image lineImage; //����������� �����
    

    public SpellCardSO spellCardData { get; private set; }



    public virtual void Initialize(SpellCardSO cardSO) 
    {
        if (!(cardSO is SpellCardSO))
        {
            throw new System.ArgumentException("�� SpellCardSO");
        }
        spellCardData = cardSO as SpellCardSO;
        imgCard.sprite = spellCardData.getImgCard;
        spells = cardData.getSpells;
    }
}
