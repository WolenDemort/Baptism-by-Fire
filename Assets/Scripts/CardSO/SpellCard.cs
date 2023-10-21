using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Card/Spell card", fileName = "Spell card")]
public class SpellCard : ScriptableObject//����� ������������
{
    public int idSpellCard;//id ����� �����������

    public string nameSpellCard;//��� �����


    public Sprite imgSpellCard;//������ �����
    public string storySpellCard;//��������

    public AudioClip audioSpellCard;//����� ������ ��� �������������
    public SpellsChosee spellRegular;//����� ����������
    public CurrencyType CurrencyType;//����� ������
    [SerializeField]
    private int coastSpellCard;//���� �������
}
