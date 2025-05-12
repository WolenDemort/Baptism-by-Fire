using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public abstract class Line : MonoBehaviour, IScoreLine
{
    [SerializeField]
    protected GameObject bigLine;
    [SerializeField]
    protected GameObject buffLine;
    [SerializeField]
    protected TMP_Text lineScore;
    protected int currentScrore;
    [SerializeField]
    ScoreControl globalScore;

    

    public virtual void CalculateScore(List<RegularCardScoreControl> cards) { // подсчет карт
        currentScrore = 0;
                  
        foreach (var card in cards)
        {
            currentScrore += card.CurrentScore;
        }
       
        UpdateScore();
    }

    protected void StartScore()
    {
        currentScrore = 0;
        lineScore.text = currentScrore.ToString();        
    }

    protected void UpdateScore()
    {
        lineScore.text = currentScrore.ToString();
        globalScore.SumScoreUpdate();
    }

    public int Score => currentScrore;
    public GameObject bgLe => bigLine; 
}
