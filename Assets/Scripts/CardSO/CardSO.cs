using UnityEngine;

public class CardSO : ScriptableObject
{

    [SerializeField] private int idCard;//id карты 
    [SerializeField] private string nameCard;//имя карты
    [SerializeField] private Sprite imgCard;//спрайт карты
    
    [TextArea(3, 10)]
    [SerializeField] private string storyCard;//описание

    [SerializeField] private AudioClip [] audioCard;//аудио эффект при использовании
    [SerializeField] private AudioClip[] audioMesseg;//фразы персонажа

    [SerializeField] private CurrencyType currencyType;//выбор валюты
    [SerializeField] private int coastCard;//цена покупки          

    [SerializeField] private int countCard = 1;//количество
    [SerializeField] private ChoosingFaith choosingFaith;// вера(фракция)

    [SerializeField] private SpellsChosee spellRegular;//способность
    [SerializeField] private Sprite spellSprite;// спрайт способности
    [SerializeField] private ZoneCardEnums ZoneLine;

  

    public ZoneCardEnums getZoneLine => ZoneLine;
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
    public Sprite getImgSpell => spellSprite;
    public SpellsChosee getSpells => spellRegular;








}
