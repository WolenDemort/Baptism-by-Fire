using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RegularCardView : CardView
{
 

  
    [SerializeField]
    private TMP_Text CardScore; //поле очков карты
    private int originalScore=4; //изначальный счет
    private int currentScore; //текущий счет
    [SerializeField]
    private Image lineImage; //изображение линии
   
    public  RegularCardSO regularCardData { get; private set; }



    public virtual void Initialize(RegularCardSO cardSO) //первичная установка данных
    {
        if (!(cardSO is RegularCardSO))
        {
            throw new System.ArgumentException("Не RegularCardSO");
        }
        regularCardData = cardSO as RegularCardSO;

        imgCard.sprite = regularCardData.getImgCard;
        originalScore = regularCardData.getScoreCard;
        spells = regularCardData.getSpells;
        if (spells == SpellsChosee.None) DownSpellImg();
        
        DrawNewScore(originalScore);
    }

   
    public void DrawNewScore(int score)
    {
        currentScore = score;
        CardScore.text = currentScore.ToString();
    }

    public void DownSpellImg()
    {
        Transform parent = spellImage.transform.parent;
        parent.GetComponent<GameObject>().SetActive(false);
    }

    public int getCurrentScore => currentScore;//передача текущего 
    public int getOriginalScore => originalScore;//передача оригинального счета
}
