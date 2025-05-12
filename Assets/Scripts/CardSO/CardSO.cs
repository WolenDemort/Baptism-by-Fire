using UnityEngine;

public class CardSO : ScriptableObject
{

    [SerializeField] private int idCard;//id ����� 
    [SerializeField] private string nameCard;//��� �����
    [SerializeField] private Sprite imgCard;//������ �����
    
    [TextArea(3, 10)]
    [SerializeField] private string storyCard;//��������

    [SerializeField] private AudioClip [] audioCard;//����� ������ ��� �������������
    [SerializeField] private AudioClip[] audioMesseg;//����� ���������

    [SerializeField] private CurrencyType currencyType;//����� ������
    [SerializeField] private int coastCard;//���� �������          

    [SerializeField] private int countCard = 1;//����������
    [SerializeField] private ChoosingFaith choosingFaith;// ����(�������)

    [SerializeField] private SpellsChosee spellRegular;//�����������
    [SerializeField] private Sprite spellSprite;// ������ �����������
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
