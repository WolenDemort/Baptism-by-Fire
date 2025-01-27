using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class LoadShopItem : MonoBehaviour
{

    [SerializeField] TMP_Text PriceCard;//цена на карту
    [SerializeField] Image imgCard;//картинка карты
    [SerializeField] Image imgCoast;//картинка валюты

    void Start()
    {
        LoadInformationCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void LoadInformationCard()
    {
        /*PriceCard=SOcard;
         imgCard=SOcard;
         if(CurrencyType)///если валюта обычная или спец
         
         */

    }
}
