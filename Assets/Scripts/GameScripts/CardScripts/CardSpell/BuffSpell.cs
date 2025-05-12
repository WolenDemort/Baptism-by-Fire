using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffSpell : CardSpell
{
    private Line line;
    private GameObject bgLine;

    public override void Spell()
    {
        line = transform.GetComponentInParent<Line>();
        bgLine = line.bgLe;
        foreach (Transform child in bgLine.transform)
        {
            child.GetComponent<RegularCardScoreControl>().setBuffScore();

        }
        Debug.Log("i work");
    }
}

