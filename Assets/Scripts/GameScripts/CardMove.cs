using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardMove : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
   [SerializeField]
   private Camera MainCamera;


    
    public void OnBeginDrag(PointerEventData eventData)
    {
       
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 newPos = MainCamera.ScreenToWorldPoint(eventData.position);
        newPos.z = 0;       
        transform.position = newPos;
        Debug.Log(transform.position);
    }
       

    public void OnEndDrag(PointerEventData eventData)
    {
       
       
    }
}
