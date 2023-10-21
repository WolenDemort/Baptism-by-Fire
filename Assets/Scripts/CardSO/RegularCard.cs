using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Card/Regular card", fileName = "Regular card")]
public class RegularCard : ScriptableObject//������� ����� ��� ����
{
        public int idRegularCard;//id ������� �����

        public string nameRegularCard;//���
        [SerializeField]
        private int scoreRegularCard;//���� �����
        public Sprite imgRegularCard;//��������
        public string storyRegularCard;//��������
        public int countRegularCard;//����������
        public AudioClip audioRegularCard;//�����
        public SpellsChosee spellRegular;//�����������
        public CurrencyType CurrencyType;//��� ������
        [SerializeField]
        private int coastRegularCard;//����
        public bool HeroCard;//������� �� ����� ������(��������� �� �� ��� �����)
    public ChoosingFaith ChoosingFaith;//����(�������)


}
