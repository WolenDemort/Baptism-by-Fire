using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ CreateAssetMenu(menuName = "Card/King card", fileName = "King card")]
public class KingCard : ScriptableObject//����� �������
{
   

        public int idKingCard;// id ����� ������

        public string nameKingCard;// ��� ����� ������
   
       
        public Sprite imgKingCard;// ��������
        public string storyRegularCard;// ��������
       
        public AudioClip audioKingCard;//����� ����
        public SpellsChosee spellRegular;//�����������
        public CurrencyType CurrencyType;//��� ������
        [SerializeField]
        private int coastKingCard;//����
    public ChoosingFaith ChoosingFaith;// ����(�������)




}
