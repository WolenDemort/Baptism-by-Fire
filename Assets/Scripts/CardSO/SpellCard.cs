using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Card/Spell card", fileName = "Spell card")]
public class SpellCard : ScriptableObject//карты способностей
{
    public int idSpellCard;//id карты способности

    public string nameSpellCard;//имя карты


    public Sprite imgSpellCard;//спрайт карты
    public string storySpellCard;//описание

    public AudioClip audioSpellCard;//аудио эффект при использовании
    public SpellsChosee spellRegular;//выбор спосбности
    public CurrencyType CurrencyType;//выбор валюты
    [SerializeField]
    private int coastSpellCard;//цена покупки
}
