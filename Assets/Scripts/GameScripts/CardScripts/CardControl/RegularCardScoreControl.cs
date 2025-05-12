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
        originalScore = card.OriginalScore;
        currentScore = originalScore;
    }

    public void setOriginalScore() //��������� ������������ �����
    {
        currentScore = originalScore;
       
    }

    public void setBuffScore()
    {
        currentScore *= 2;
        card.UpdateScoreView(currentScore);

    }

    public int CurrentScore => currentScore;//�������� �������� 
    public int OriginalScore => originalScore;//�������� ������������� �����
}
