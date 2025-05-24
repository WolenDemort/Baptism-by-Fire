using TMPro;
using UnityEngine;
using Zenject;

public class UIMoneyText : MonoBehaviour
{
    DiContainer container;
    [SerializeField] 
    TMP_Text Silver;
    [SerializeField]
    TMP_Text Gold;
    ShoppingSystem shop;
    void Start()
    {
        container = DIManager.GetContainer();      
        shop =  container.Resolve<ShoppingSystem>();
        UIMoneyUpdate();       
    }

    public void UIMoneyUpdate() {
        Silver.text = shop.getSilver.ToString();
        Gold.text = shop.getGold.ToString();
    }


}
