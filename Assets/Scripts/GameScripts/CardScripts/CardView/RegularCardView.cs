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
   


   

    public virtual void Initialize(RegularCardSO cardSO) //��������� ��������� ������
    {
        imgCard.sprite = cardSO.getImgCard;
       // originalScore = cardSO.getScoreCard;
        DrawNewScore(originalScore);
    }

   
    public void DrawNewScore(int score)
    {
        currentScore = score;
        CardScore.text = currentScore.ToString();
    }



    public int getCurrentScore => currentScore;//�������� �������� 
    public int getOriginalScore => originalScore;//�������� ������������� �����
}
