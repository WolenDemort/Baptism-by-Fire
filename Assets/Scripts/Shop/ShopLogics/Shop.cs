using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] ShopContent _contentItems;
    
    [SerializeField] ShopCategoryButton simpleCardsButton;
    [SerializeField] ShopCategoryButton spellCardsButton;
    [SerializeField] ShopCategoryButton kingCardsButton;
       
    [SerializeField] ShopPanel _shopPanel;

    private IStorageSystem storageSystem;
    
    public void Awake()
    {
       // _contentItems = ScriptableObject.CreateInstance<ShopContent>();
        storageSystem = new SaveSystem();
       // Load();
    }
    public void Start()
    {
        OnSimpleCardsButtonClick();

    }


    public void Save()
    {
        Dictionary<string, string> p = new Dictionary<string, string>();
        foreach (CardSO c in _contentItems.regularCards)
        {

            p.Add(c.name,c.GetType().ToString());
        } 
        foreach (CardSO c in _contentItems.kingCards)
        {

            p.Add(c.name, c.GetType().ToString());
        } 
        foreach (CardSO c in _contentItems.spellCards)
        {

            p.Add(c.name, c.GetType().ToString());
        }

        storageSystem.SaveNewFile(SaveKey.Shop, p);
        
    }
   public void Load()
    {
        storageSystem.Load<Dictionary<string, string>>(SaveKey.Shop, e =>
        {

            _contentItems.regularCards = new List<RegularCardSO>();
            _contentItems.spellCards = new List<SpellCardSO>();
            _contentItems.kingCards = new List<KingCardSO>();
            foreach (KeyValuePair<string, string> s in e)
            {
               
                switch (s.Value)
                {
                    case "RegularCardSO":
                        RegularCardSO r = Resources.Load<RegularCardSO>("Cards/RegularCards/" + s.Key);
                        _contentItems.regularCards.Add(r);
                        break;
                    case "SpellCardSO":
                        SpellCardSO sp = Resources.Load<SpellCardSO>("Cards/SpellCards/" + s.Key);
                        _contentItems.spellCards.Add(sp) ;
                        break; 
                    case "KingCardSO":
                        KingCardSO k = Resources.Load<KingCardSO>("Cards/KingCards/" + s.Key);
                        _contentItems.kingCards.Add(k);
                        break;
                    default:
                        throw new System.Exception("Нет такого типа для магазина");
                }

               
            }

        });
      
   }
    




    private void OnEnable()
    {
        simpleCardsButton.Click += OnSimpleCardsButtonClick;
        spellCardsButton.Click += OnSpellCardsButtonClick;
        kingCardsButton.Click += OnKingCardsButtonClick;
        
    }


    private void OnDisable()
    {
        simpleCardsButton.Click -= OnSimpleCardsButtonClick;
        spellCardsButton.Click -= OnSpellCardsButtonClick;
        kingCardsButton.Click -= OnKingCardsButtonClick;
        
    }



    private void OnSimpleCardsButtonClick()
    {
        simpleCardsButton.Select();
        spellCardsButton.Unselect();       
        kingCardsButton.Unselect();
     
        _shopPanel.Show(_contentItems.regularCards.Cast<CardSO>());
    }
    private void OnSpellCardsButtonClick()
    {
       simpleCardsButton.Unselect();     
        spellCardsButton.Select();
        kingCardsButton.Unselect();      

        _shopPanel.Show(_contentItems.spellCards.Cast<CardSO>());
    }
    private void OnKingCardsButtonClick()
    {
        simpleCardsButton.Unselect();
        spellCardsButton.Unselect();       
        kingCardsButton.Select();

        _shopPanel.Show(_contentItems.kingCards.Cast<CardSO>());
    }
    
   


}
