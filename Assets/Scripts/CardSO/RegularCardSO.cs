using Newtonsoft.Json;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName = "Card/Create Card/Regular card", fileName = "Regular card")]
public class RegularCardSO : CardSO//������� ����� ��� ����
{
   
    [SerializeField] private bool HeroCard= false;//������� �� ����� ������(��������� �� �� ��� �����)
    [SerializeField] private int scoreCard;//���� �����
    [SerializeField] private Sprite lineSprite;// ������ �����


   
    public Sprite getLineSpell => lineSprite;
    public bool getHero => HeroCard;
    public int getScoreCard => scoreCard;
}


