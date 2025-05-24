using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using UnityEditor;

public class TestSave : MonoBehaviour
{

    public List<CardSO> card;
    private IStorageSystem storageSystem;


    // Start is called before the first frame update
    void Start()
    {

        storageSystem = new SaveSystem();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SaveD()
    {
        List<string> p = new List<string>();
        foreach (CardSO c in card)
        {

            p.Add(c.name);
        }

        storageSystem.SaveOldFile(SaveKey.Test, p);
        card.Clear();
    }
    public void LoadD()
    {
        storageSystem.Load<List<string>>(SaveKey.Test, e =>
        {

            foreach (string s in e)
            {

                CardSO c = Resources.Load<CardSO>("Cards/RegularCards/" + s);
                card.Add(c);

            }

        });
        CheckData();
    }
    public void CheckData()
    {
        foreach (CardSO i in card)
        {

            Debug.Log(i.GetType());
        }
    }

  /*  public void Save()
    {
        Dictionary<string, string> p = new Dictionary<string, string>();
        foreach (CardSO c in _contentItems.regularCards)
        {

            p.Add(c.name, c.GetType().ToString());
        }
        foreach (CardSO c in _contentItems.kingCards)
        {

            p.Add(c.name, c.GetType().ToString());
        }
        foreach (CardSO c in _contentItems.spellCards)
        {

            p.Add(c.name, c.GetType().ToString());
        }

        storageSystem.Save(SaveKey.Shop, p);

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
                        _contentItems.spellCards.Add(sp);
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

    }*/
}
