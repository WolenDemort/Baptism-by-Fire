using UnityEngine;


[CreateAssetMenu(menuName = "Card/Regular card", fileName = "Regular card")]
public class RegularCardSO : CardSO//обычные карты для игры
{
    [SerializeField] private SpellsChosee spellRegular;//способность

    [SerializeField] private CardLine line;

    [SerializeField] private bool HeroCard;//явлется ли карта героем(действуют ли на нее баффы)


    [SerializeField] private int scoreCard;//очки карты


  

    public SpellsChosee getSpells => spellRegular;
    public CardLine getLine => line;
    public bool getHero => HeroCard;

    public int getScoreCard => scoreCard;
}

[System.Flags]
public enum CardLine
{
    None = 0,
    Sword = 1 << 0,
    Archer = 1 << 1,
    Catapults = 1 << 2
   
}
