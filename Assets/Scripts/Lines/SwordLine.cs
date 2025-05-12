using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordLine : Line
{
    public override void CalculateScore(List<RegularCardScoreControl> cards)
    {
        base.CalculateScore(cards);
    }


    void Awake()
    {
        base.StartScore();
    }

}
