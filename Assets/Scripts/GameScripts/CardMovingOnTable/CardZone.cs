using UnityEngine;
using UnityEngine.EventSystems;

public class CardZone : MonoBehaviour, IDropHandler
{
    
    public ZoneCardEnums ZoneType;

    public void OnDrop(PointerEventData eventData)
    {
        if (!eventData.pointerDrag.TryGetComponent(out CardController card)) return;

        if (ZoneType == ZoneCardEnums.EnemyArrows || ZoneType == ZoneCardEnums.EnemyCatapults || ZoneType == ZoneCardEnums.EnemySwordsmens || !card.IsDraggable)
            return;


        card.transform.SetParent(this.transform);
        transform.parent.GetComponent<TableZone>().DropCardOnZone(card);

    }




}
