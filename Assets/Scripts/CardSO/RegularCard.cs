using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Card/Regular card", fileName = "Regular card")]
public class RegularCard : ScriptableObject//обычные карты для игры
{
        public int idRegularCard;//id обычной карты

        public string nameRegularCard;//имя
        [SerializeField]
        private int scoreRegularCard;//очки карты
        public Sprite imgRegularCard;//картинка
        public string storyRegularCard;//описание
        public int countRegularCard;//количество
        public AudioClip audioRegularCard;//аудио
        public SpellsChosee spellRegular;//способность
        public CurrencyType CurrencyType;//тип валюты
        [SerializeField]
        private int coastRegularCard;//цена
        public bool HeroCard;//явлется ли карта героем(действуют ли на нее баффы)
    public ChoosingFaith ChoosingFaith;//вера(фракция)


}
