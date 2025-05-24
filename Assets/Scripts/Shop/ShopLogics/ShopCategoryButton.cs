using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class ShopCategoryButton : MonoBehaviour
{
    public event Action Click;

    [SerializeField] Button _button;
    [SerializeField] Image _image;
    [SerializeField] Color _selectColor;
    [SerializeField] Color _unSelectColor;

    private void OnEnable() => _button.onClick.AddListener(OnClick);
    private void OnDisable() => _button.onClick.RemoveListener(OnClick);

    public void Select() => _image.color = _selectColor;
    public void Unselect() => _image.color = _unSelectColor;

    private void OnClick() => Click?.Invoke();

    public void ScrollReturnOnHorizontal(GameObject gameObject)
    {
        ScrollRect _scroll = gameObject.GetComponent<ScrollRect>();
        _scroll.horizontalNormalizedPosition = 0;
    }

    public void ScrollReturnOnVertical(GameObject gameObject)
    {
        ScrollRect _scroll = gameObject.GetComponent<ScrollRect>();
        _scroll.verticalNormalizedPosition = 1;
    }
    
}
