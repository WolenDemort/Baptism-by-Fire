using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularCardScoreControl : MonoBehaviour
{

    private int originalScore; //изначальный счет
    private int currentScore; //текущий счет

    RegularCardView card;

    void Awake()
    {
        card = GetComponent<RegularCardView>();
       
    }

    void Start()
    {
        originalScore = card.getOriginalScore;
       


    }

    public void setOriginalScore() //установка изначального счета
    {
        currentScore = originalScore;
        card.DrawNewScore(currentScore);
    }

    public void DoubleScore() //увеличение счета в два раза
    {
        currentScore = card.getCurrentScore;
        currentScore *= 2;
        card.DrawNewScore(currentScore);
    }

    public void HalfScore() //деление счета 
    {
        currentScore = card.getCurrentScore;
        currentScore /= 2;
        card.DrawNewScore(currentScore);
    }

    
}
