using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SwordDebuff : MonoBehaviour, ICardSpell
{

    SwordLine [] lines;

    public void Spell(){
        DiContainer container= DIManager.GetContainer();
        lines=container.Resolve<SwordLine[]>();
        foreach(SwordLine line in lines)
        {
            line.DebuffLine();
            
        }
       
    }
}
