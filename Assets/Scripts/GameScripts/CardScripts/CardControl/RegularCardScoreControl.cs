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
        originalScore = card.OriginalScore;
        currentScore = originalScore;
    }

    public void setOriginalScore() //установка изначального счета
    {
        currentScore = originalScore;
       
    }

    public void setBuffScore()
    {
        currentScore *= 2;
        card.UpdateScoreView(currentScore);

    }

    public int CurrentScore => currentScore;//передача текущего 
    public int OriginalScore => originalScore;//передача оригинального счета
}
