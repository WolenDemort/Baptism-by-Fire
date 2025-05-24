using Newtonsoft.Json;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName = "Card/Create Card/Regular card", fileName = "Regular card")]
public class RegularCardSO : CardSO//обычные карты для игры
{
   
    [SerializeField] private bool HeroCard= false;//явлется ли карта героем(действуют ли на нее баффы)
    [SerializeField] private int scoreCard;//очки карты
    [SerializeField] private Sprite lineSprite;// спрайт линии


   
    public Sprite getLineSpell => lineSprite;
    public bool getHero => HeroCard;
    public int getScoreCard => scoreCard;
}


