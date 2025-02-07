using UnityEngine;


[CreateAssetMenu(menuName = "Card/Regular card", fileName = "Regular card")]
public class RegularCardSO : CardSO//������� ����� ��� ����
{
    [SerializeField] private SpellsChosee spellRegular;//�����������

    [SerializeField] private CardLine line;

    [SerializeField] private bool HeroCard;//������� �� ����� ������(��������� �� �� ��� �����)


    [SerializeField] private int scoreCard;//���� �����


  

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
