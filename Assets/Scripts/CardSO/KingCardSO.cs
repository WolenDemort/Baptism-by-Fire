using Newtonsoft.Json;
using UnityEngine;

[ CreateAssetMenu(menuName = "Card/Create Card/King card", fileName = "King card")]

public class KingCardSO : CardSO//����� �������
{
    [TextArea(3, 10)]
    [SerializeField]
    private string spellStory;
    public string getSpellStory => spellStory;
    //public ChoosingFaith ChoosingFaith;// ����(�������)

}
