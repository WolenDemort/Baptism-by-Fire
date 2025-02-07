using UnityEngine;

public class CardSO : ScriptableObject
{

    [SerializeField] private int idCard;//id карты 
    [SerializeField] private string nameCard;//имя карты
    [SerializeField] private Sprite imgCard;//спрайт карты
    [SerializeField] private string storyCard;//описание

    [SerializeField] private AudioClip [] audioCard;//аудио эффект при использовании
    [SerializeField] private AudioClip[] audioMesseg;//фразы персонажа

    [SerializeField] private CurrencyType currencyType;//выбор валюты
    [SerializeField]
    private int coastCard;//цена покупки
            
   

    [SerializeField] private int countCard;//количество
    [SerializeField] private ChoosingFaith choosingFaith;// вера(фракция)




    public int getIdCards =>idCard;
    public string getNameCard => nameCard;
    public Sprite getImgCard => imgCard;
    public string getStoryCard=> storyCard;
    public AudioClip[] getAudioCard => audioCard;
    public AudioClip[] getAudioMessege => audioMesseg;
    public CurrencyType getCurrency => currencyType;
    public int getCoast => coastCard;
   
    public int getCountCard => countCard;
    public ChoosingFaith getFaith => choosingFaith;










}
