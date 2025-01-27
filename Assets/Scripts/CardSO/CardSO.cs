using UnityEngine;

public class CardSO : ScriptableObject
{

    public int idCard;//id карты 
    public string nameCard;//имя карты
    public Sprite imgCard;//спрайт карты
    public string storyCard;//описание

    public AudioClip [] audioCard;//аудио эффект при использовании
    public AudioClip[] audioMesseg;//фразы персонажа

    public CurrencyType CurrencyType;//выбор валюты
    [SerializeField]
    private int coastCard;//цена покупки
            
    [SerializeField]
    private int scoreCard;//очки карты
   
    public int countCard;//количество
    public ChoosingFaith ChoosingFaith;// вера(фракция)
   

}
