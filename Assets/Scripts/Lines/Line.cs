using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public abstract class Line : MonoBehaviour, IScoreLine
{
    [SerializeField]
    protected Transform bigLine;
    [SerializeField]
    protected Transform buffLine;
    [SerializeField]
    protected TMP_Text lineScore;
    protected int currentScrore;
    [SerializeField]
    ScoreControl globalScore;

    protected List<RegularCardScoreControl> cardOnLine=new();

    protected bool doubleBuff = false;
    protected bool oneBuff = false;
    protected bool debuff = false;

    public virtual void AddCardOnLine(RegularCardScoreControl card)
    {
        cardOnLine.Add(card);
        CalculateScore();
    }
    public virtual void RemoveCardOnLine(RegularCardScoreControl card)
    {
        cardOnLine.Remove(card);
        CalculateScore();
    }
    public virtual void CalculateScore() { // подсчет карт
        currentScrore = 0;
                  
        foreach (var card in cardOnLine)
        {
            int temp = 0;
            if (debuff)
            {
                card.OnDebuffScore();
                temp = card.CurrentScore();

            }
            else
            {
                card.OffDebuffScore();
                temp = card.CurrentScore();
            }
            if (oneBuff)
            {
                card.OneBuffScore();
                temp = card.CurrentScore();
               
            }
            if (doubleBuff)
            {
                card.OnDoubleBuffScore();
                temp = card.CurrentScore();
               
            }
            else
            {
                temp = card.CurrentScore();
                
            }
            currentScrore += temp;
        }
       
        UpdateScore();
    }

    protected void StartScore()
    {
        currentScrore = 0;
        lineScore.text = currentScrore.ToString();        
    }
    public void SetDebuff(bool status)
    {
        debuff = status;
    }
    public void SetDoubleBuff(bool status)
    {
        doubleBuff = status;
    } 
    public void SetOneBuff(bool status)
    {
        oneBuff = status;
    }

    protected void UpdateScore()
    {
        lineScore.text = currentScrore.ToString();
        globalScore.SumScoreUpdate();
    }

    public int Score => currentScrore;
    public Transform BigLine => bigLine; 
    public Transform BuffLine => buffLine; 



}
