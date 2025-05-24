using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingSystem 
{
    public Ñurrencies money; 
    private IStorageSystem storageSystem;
    

    public ShoppingSystem()
    {
        money = new Ñurrencies();
        storageSystem = new SaveSystem();
        Load();
    }
          
    public bool Buy(CurrencyType type, int price)
    {
        if (type == CurrencyType.Gold)
        {
            if (money.goldMoney >= price)
            {
               money.goldMoney = money.goldMoney - price;
               Save();
                return true;
            }

            else return false;
        }
        else
        {
            if (money.silverMoney >= price)
            {               
                money.silverMoney = money.silverMoney - price;                
                Save();
                return true;
            }
            else return false;
        }
    }
    public void AddMoney(CurrencyType type, int aaddMoney)
    {
        if (type == CurrencyType.Gold) { 
           money.goldMoney += aaddMoney;                    
        }
       else
       {
           money.silverMoney += aaddMoney;            
       }
        Save();
    }

    public void Save()
    {
       
      storageSystem.SaveNewFile(SaveKey.Money, money);
    }
    public void Load()
    {
        storageSystem.Load<Ñurrencies>(SaveKey.Money, e => {
           
            money.goldMoney = e.goldMoney;
            money.silverMoney = e.silverMoney;         

        });
       
    }

    public int getSilver => money.silverMoney;
    public int getGold => money.goldMoney;
}
public struct Ñurrencies
{
    [JsonProperty(PropertyName = "gold")]
    public int goldMoney { get; set; }
    [JsonProperty(PropertyName = "silver")]
    public int silverMoney { get; set; }
    
}