using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardController : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public bool IsDraggable=true;
    public Image img;

 
    private Vector3 offset;
      
    [HideInInspector] public RectTransform parentAfterDrag;
   
    private RectTransform rect;

 

    void Start() {
        rect = GetComponent<RectTransform>();
       
    }
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (!IsDraggable)
            return;


        Vector3 tr = new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z);
        offset = transform.position - Camera.main.ScreenToWorldPoint(tr);

        parentAfterDrag = (RectTransform)base.transform.parent;
     
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!IsDraggable)
            return;

        rect.SetParent(base.transform.root);
        rect.SetAsLastSibling();
        img.raycastTarget = false;      
        Vector3 tr = new Vector3(Input.mousePosition.x, Input.mousePosition.y,transform.position.z);
        transform.position = Camera.main.ScreenToWorldPoint(tr)+offset;    

    }


    public void OnEndDrag(PointerEventData eventData)
    {       
        if (!IsDraggable)    
            return;
        
        rect.SetParent(parentAfterDrag);
        img.raycastTarget = true;      
    }
}
