using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowLine : Line 
{
    public override void CalculateScore()
    {
        base.CalculateScore();
    }
    public void DebuffLine()
    {

        SetDebuff(true);
        CalculateScore();

    }
    void Awake()
    {
        base.StartScore();  
    }

   
}
