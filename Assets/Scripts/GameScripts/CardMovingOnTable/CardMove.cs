using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardMove : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public  bool IsDraggable;
    public Image img;
  
   [HideInInspector] public RectTransform parentAfterDrag;
    [HideInInspector] public RectTransform parentDrag;
    private RectTransform rect;
    void Start() {

        rect = GetComponent<RectTransform>();    
    }
    
    public void OnBeginDrag(PointerEventData eventData)
    {

        if (!IsDraggable)
            return;

        parentAfterDrag = (RectTransform)transform.parent;
       IsDraggable = parentAfterDrag.GetComponent<CardZoneOnTable>().Type == ZoneCardEnums.MyHand; 
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!IsDraggable)
            return;
      
        rect.SetParent(transform.root);
        rect.SetAsLastSibling();
        img.raycastTarget = false;      

        rect.anchoredPosition+= eventData.delta;    
    }


    public void OnEndDrag(PointerEventData eventData)
    {
       
        if (!IsDraggable)    
            return;
 
        rect.SetParent(parentAfterDrag);
        img.raycastTarget = true;      
    }
}
