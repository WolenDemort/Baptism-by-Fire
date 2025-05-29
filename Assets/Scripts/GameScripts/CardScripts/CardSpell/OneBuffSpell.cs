using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneBuffSpell : MonoBehaviour, ICardSpell
{
    private Line line;

    public void Spell()
    {
        line = transform.GetComponentInParent<Line>();
        line.SetOneBuff(true);
        line.CalculateScore();
    }
}
