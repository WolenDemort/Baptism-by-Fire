using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularCardScoreControl : MonoBehaviour
{
    private int originalScore; //изначальный счет
    private int currentScore; //текущий счет
    private int buffPlusCount = 0;
    private int buffMultiCount = 1;   
    private bool isDoubleBuff = false;
    private bool isOneBuff = false;
    private bool isDebuff = false;
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



    public void OnDoubleBuffScore()
    {
        if (!isDoubleBuff)
        {
            buffMultiCount *= 2;
            card.UpdateScoreView(CurrentScore());
            isDoubleBuff = true;
        }
    }


    public void OffDoubleBuffScore()
    {
        if (isDoubleBuff)
        {
            buffMultiCount /= 2;
            card.UpdateScoreView(CurrentScore());
            isDoubleBuff = false;
        }
    }
    public void OneBuffScore()
    {
        if (!isOneBuff) {
            buffPlusCount += 1;
            card.UpdateScoreView(CurrentScore());
            isOneBuff = true;
        }
    }

    public void OffOneBuffScore()
    {
        if (isDoubleBuff)
        {
            buffPlusCount -= 1;
            card.UpdateScoreView(CurrentScore());
            isOneBuff = false;
        }

    }
    public void OnDebuffScore()
    {
       
        if (!isDebuff)
        {
            currentScore = 1;
            card.UpdateScoreView(CurrentScore());
            isDebuff = true;
        }
    }
    public void OffDebuffScore()
    {

        if (isDebuff)
        {
            currentScore = originalScore;
            card.UpdateScoreView(CurrentScore());
            isDebuff = false;
        }
    }
    public int CurrentScore() {
       
        return (currentScore+buffPlusCount)*buffMultiCount;
    } 
    public int OriginalScore => originalScore;//передача оригинального счета
}
