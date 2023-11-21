using UnityEngine;
using UnityEngine.EventSystems;

public class CardZoneOnTable : MonoBehaviour, IDropHandler
{
    public ZoneCardEnums Type;

    public void OnDrop(PointerEventData eventData)
    {
        if(!eventData.pointerDrag.TryGetComponent(out CardMove card)) return;

        if (Type == ZoneCardEnums.EnemyArrows || Type == ZoneCardEnums.EnemyCatapults|| Type == ZoneCardEnums.EnemySwordsmens || !card.IsDraggable )
            return;
        
        card.parentAfterDrag= (RectTransform)transform;
        card.parentDrag = (RectTransform)transform;


        transform.parent.GetComponent<TableZone>().DropCardOnZone(card);
         
    }

  


}
