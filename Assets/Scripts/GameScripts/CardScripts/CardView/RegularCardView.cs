using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RegularCardView : CardView
{
 

  
    [SerializeField]
    private TMP_Text CardScore; //���� ����� �����
    private int originalScore=4; //����������� ����
    private int currentScore; //������� ����
    [SerializeField]
    private Image lineImage; //����������� �����
   
    public  RegularCardSO regularCardData { get; private set; }



    public virtual void Initialize(RegularCardSO cardSO) //��������� ��������� ������
    {
        if (!(cardSO is RegularCardSO))
        {
            throw new System.ArgumentException("�� RegularCardSO");
        }
        regularCardData = cardSO as RegularCardSO;

        imgCard.sprite = regularCardData.getImgCard;
        originalScore = regularCardData.getScoreCard;
        spells = regularCardData.getSpells;
        if (spells == SpellsChosee.None) DownSpellImg();
        
        DrawNewScore(originalScore);
    }

   
    public void DrawNewScore(int score)
    {
        currentScore = score;
        CardScore.text = currentScore.ToString();
    }

    public void DownSpellImg()
    {
        Transform parent = spellImage.transform.parent;
        parent.GetComponent<GameObject>().SetActive(false);
    }

    public int getCurrentScore => currentScore;//�������� �������� 
    public int getOriginalScore => originalScore;//�������� ������������� �����
}
