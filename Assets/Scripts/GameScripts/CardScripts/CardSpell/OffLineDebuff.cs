using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class OffLineDebuff :MonoBehaviour, ICardSpell
{

    Line[] lines;

    public void Spell()
    {
        DiContainer container = DIManager.GetContainer();
        lines = container.Resolve<SwordLine[]>();
        foreach (Line line in lines)
        {
            line.SetDebuff(false);            
        }
        lines = container.Resolve<ArrowLine[]>();
        foreach (Line line in lines)
        {
            line.SetDebuff(false);            
        }
        lines = container.Resolve<CatapultesLine[]>();
        foreach (Line line in lines)
        {
            line.SetDebuff(false);           
        }
    }
}
