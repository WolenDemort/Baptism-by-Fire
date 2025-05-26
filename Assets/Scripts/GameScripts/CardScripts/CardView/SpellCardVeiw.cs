using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpellCardVeiw : CardView
{     
    
    public SpellCardSO spellCardData { get; private set; }

    public override void Initialize(CardSO cardSO) 
    {
        if (!(cardSO is SpellCardSO))
        {
            throw new System.ArgumentException("Не SpellCardSO");
        }
        spellCardData = cardSO as SpellCardSO;
        imgCard.sprite = spellCardData.getImgCard;
        zone = spellCardData.getZoneLine;
        spell = spellCardData.getSpells;
        spellImage.sprite = spellCardData.getImgSpell;
       
    }
   
}
