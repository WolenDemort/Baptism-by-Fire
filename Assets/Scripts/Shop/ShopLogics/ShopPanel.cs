using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPanel : MonoBehaviour
{
    private List<ShopCardView> _shopItem = new List<ShopCardView>();

    [SerializeField] Transform _itemParent;   
    [SerializeField] ShopFactory _factory;

    private IStorageSystem storageSystem;
    public void Awake()
    {
      storageSystem = new SaveSystem();        
    }

   
    public void Show(IEnumerable<CardSO> items)
    {
        List<string> list = new List<string>();
        storageSystem.Load<List<string>>(SaveKey.AllCardsPlayer, e=> { list.AddRange(e); });

        Clear();
        foreach (CardSO item in items)
        {
            if (!list.Contains(item.name))
            {
            ShopCardView shopItem = _factory.Get(item, _itemParent);
            shopItem.Click += OnItemViewClick;
            _shopItem.Add(shopItem);
            }                   
        }
    }


    private void OnItemViewClick(ShopCardView obj)
    {
        if ((obj is KingCardShopView))
        {
            KingCardShopView k;
            k = obj as KingCardShopView;
            k.LorShow();
        }
        else
        {
            Debug.Log("Не явялется идолом");
        }
    }
   
    public void Clear()
    {

        foreach (ShopCardView item in _shopItem)
        {
            item.Click -= OnItemViewClick;
            Destroy(item.gameObject);

        }
        _shopItem.Clear();

    }
    
}
