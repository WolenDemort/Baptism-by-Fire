using Newtonsoft.Json;
using UnityEngine;

[ CreateAssetMenu(menuName = "Card/Create Card/King card", fileName = "King card")]

public class KingCardSO : CardSO//карты королей
{
    [TextArea(3, 10)]
    [SerializeField]
    private string spellStory;
    public string getSpellStory => spellStory;
    //public ChoosingFaith ChoosingFaith;// вера(фракция)

}
