using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordLine : Line
{
    public override void CalculateScore(/*list<RegularCardScoreControl> cards*/)
    {
        base.CalculateScore(/*cards*/);
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
