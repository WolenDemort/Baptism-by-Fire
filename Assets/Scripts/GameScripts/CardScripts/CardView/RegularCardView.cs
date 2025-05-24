using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RegularCardView : CardView
{

    [SerializeField]
    private TMP_Text CardScore; //���� ����� �����
    private int originalScore; //����������� ���� 
    [SerializeField]
    private Image lineImage; //����������� �����
    
    

    public  RegularCardSO regularCardData { get; private set; }

    public override void Initialize(CardSO cardSO) //��������� ��������� ������
    {
        if (!(cardSO is RegularCardSO))
        {
            throw new System.ArgumentException("�� RegularCardSO");
        }
        regularCardData = cardSO as RegularCardSO;

        imgCard.sprite = regularCardData.getImgCard;
       
        originalScore = regularCardData.getScoreCard;
        zone = regularCardData.getZoneLine;
        
       spell = regularCardData.getSpells;
        if (spell != SpellsChosee.None)
        {
            spellImage.sprite = regularCardData.getImgSpell;
        }
        else
        {
            spellImage.enabled = false;
        }


        UpdateScoreView(originalScore);
    }

    public void UpdateScoreView(int score)
    {
        CardScore.text = score.ToString();
    }

    public int OriginalScore => originalScore;//�������� ������������� �����

   
}
