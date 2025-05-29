using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleBuffSpell : MonoBehaviour, ICardSpell
{
    private Line line; 

    public void Spell()
    {
        line = transform.GetComponentInParent<Line>();
        line.SetDoubleBuff(true);
        line.CalculateScore();
    }
}

