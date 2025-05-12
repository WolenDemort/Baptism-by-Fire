using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreControl : MonoBehaviour
{
    [SerializeField]
    private TMP_Text sumCardScore;

    [SerializeField]
    Line[] lines;

    private int Score;
   
    

    
    void Start()
    {
        Score = 0;
        sumCardScore.text = "0";
    }  

   
    public void SumScoreUpdate()
    {
        Score = 0;
        foreach( var line in lines)
        {
            Score += line.Score;

        }

        sumCardScore.text = Score.ToString();


    }

    

}
