using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularCardScoreControl : MonoBehaviour
{

    private int originalScore; //����������� ����
    private int currentScore; //������� ����

    RegularCardView card;

    void Awake()
    {
        card = GetComponent<RegularCardView>();
       
    }

    void Start()
    {
        originalScore = card.getOriginalScore;
       


    }

    public void setOriginalScore() //��������� ������������ �����
    {
        currentScore = originalScore;
        card.DrawNewScore(currentScore);
    }

    public void DoubleScore() //���������� ����� � ��� ����
    {
        currentScore = card.getCurrentScore;
        currentScore *= 2;
        card.DrawNewScore(currentScore);
    }

    public void HalfScore() //������� ����� 
    {
        currentScore = card.getCurrentScore;
        currentScore /= 2;
        card.DrawNewScore(currentScore);
    }

    
}
