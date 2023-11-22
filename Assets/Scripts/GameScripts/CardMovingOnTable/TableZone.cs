using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TableZone : MonoBehaviour
{
   public  UnityEvent<CardController> OnCardDroped;
   public void DropCardOnZone(CardController card) { card.IsDraggable = false; Debug.Log("is false"); OnCardDroped.Invoke(card);  }

  // public void TakeCardFromZone(CardController card, CardZone zone) { }
     
   
}
