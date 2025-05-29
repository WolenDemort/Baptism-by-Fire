using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class CatapultsDebiff : MonoBehaviour, ICardSpell
{

    CatapultesLine[] lines;

    public void Spell()
    {
        DiContainer container = DIManager.GetContainer();
        lines = container.Resolve<CatapultesLine[]>();
        foreach (CatapultesLine line in lines)
        {
            line.DebuffLine();

        }

    }
}