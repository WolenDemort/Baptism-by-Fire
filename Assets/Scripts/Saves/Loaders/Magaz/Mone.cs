using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using SimplePrefs;
public class Mone : MonoBehaviour
{
    [SerializeField] 
    TMP_Text Silver;
    [SerializeField]
    TMP_Text Gold;
    void Start()
    {
        DataSaves a = new DataSaves() { silverMoney=int.Parse(Silver.text),goldMoney= int.Parse(Gold.text)};

        GameDataSaveLoader save = new GameDataSaveLoader(new PlayerPrefsSaver() ,new PlayerPrefsLoader());

        save.SaveMoney(a);

      //  Debug.Log(save.LoadMoney().goldMoney);
       // Debug.Log(PlayerPrefs.GetInt("MoneyPleyer_silverMoney"));
    }

   
}
