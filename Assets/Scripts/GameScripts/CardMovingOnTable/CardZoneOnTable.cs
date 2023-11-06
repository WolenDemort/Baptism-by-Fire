using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardZoneOnTable : MonoBehaviour, IDropHandler
{
    public ZoneCardEnums Type;

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        CardMove card = dropped.GetComponent<CardMove>();

        if (Type == ZoneCardEnums.EnemyArrows || Type == ZoneCardEnums.EnemyCatapults|| Type == ZoneCardEnums.EnemySwordsmens || !card.IsDraggable )
            return;
        
        card.parentAfterDrag= (RectTransform)transform;
        card.parentDrag = (RectTransform)transform;
       

    }

  
}
