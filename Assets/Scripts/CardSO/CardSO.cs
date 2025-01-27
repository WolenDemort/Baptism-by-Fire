using UnityEngine;

public class CardSO : ScriptableObject
{

    public int idCard;//id ����� 
    public string nameCard;//��� �����
    public Sprite imgCard;//������ �����
    public string storyCard;//��������

    public AudioClip [] audioCard;//����� ������ ��� �������������
    public AudioClip[] audioMesseg;//����� ���������

    public CurrencyType CurrencyType;//����� ������
    [SerializeField]
    private int coastCard;//���� �������
            
    [SerializeField]
    private int scoreCard;//���� �����
   
    public int countCard;//����������
    public ChoosingFaith ChoosingFaith;// ����(�������)
   

}
