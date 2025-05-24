using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(menuName = "Shop/ShopContent", fileName = "Shop Content")]
public class ShopContent : ScriptableObject
{
    [field: SerializeField] public List<RegularCardSO> regularCards { get;  set; }
    [field: SerializeField] public List<SpellCardSO> spellCards { get; set; }
    [field: SerializeField] public List<KingCardSO> kingCards { get; set; }   
}



