using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardMove : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public  bool IsDraggable=true;
    public Image img;

    Transform trans;
    private Vector3 offset;

   [HideInInspector] public RectTransform parentAfterDrag;
    [HideInInspector] public RectTransform parentDrag;
    private RectTransform rect;

 

    void Start() {

        rect = GetComponent<RectTransform>();
        trans = GetComponent<Transform>();
    }
    
    public void OnBeginDrag(PointerEventData eventData)
    {

        if (!IsDraggable)
            return;
        Vector3 tr = new Vector3(Input.mousePosition.x, Input.mousePosition.y, trans.position.z);
        offset = trans.position - Camera.main.ScreenToWorldPoint(tr);

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


      
       Vector3 tr = new Vector3(Input.mousePosition.x, Input.mousePosition.y,trans.position.z);
        trans.position = Camera.main.ScreenToWorldPoint(tr)+offset;


      




    }


    public void OnEndDrag(PointerEventData eventData)
    {
       
        if (!IsDraggable)    
            return;
 
        rect.SetParent(parentAfterDrag);
        img.raycastTarget = true;      
    }
}
