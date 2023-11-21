using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TableZone : MonoBehaviour
{
   public  UnityEvent<CardMove> OnCardDroped;
    public void DropCardOnZone(CardMove cardMove) { OnCardDroped.Invoke(cardMove); }

}
