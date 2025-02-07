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
   


   

    public virtual void Initialize(RegularCardSO cardSO) //первичная установка данных
    {
        imgCard.sprite = cardSO.getImgCard;
       // originalScore = cardSO.getScoreCard;
        DrawNewScore(originalScore);
    }

   
    public void DrawNewScore(int score)
    {
        currentScore = score;
        CardScore.text = currentScore.ToString();
    }



    public int getCurrentScore => currentScore;//передача текущего 
    public int getOriginalScore => originalScore;//передача оригинального счета
}
