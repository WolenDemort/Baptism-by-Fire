using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ArrowDebuff :MonoBehaviour, ICardSpell
{

    ArrowLine[] lines;

    public void Spell()
    {
        DiContainer container = DIManager.GetContainer();
        lines = container.Resolve<ArrowLine[]>();
        foreach (ArrowLine line in lines)
        {
            line.DebuffLine();

        }

    }

}
