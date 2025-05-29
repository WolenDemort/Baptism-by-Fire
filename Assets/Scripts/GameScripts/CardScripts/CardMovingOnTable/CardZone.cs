using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using System.Collections.Generic;

public class CardZone : MonoBehaviour, IDropHandler
{
    private ZoneCardEnums buffLines = ZoneCardEnums.EnemyArrowsBuff | ZoneCardEnums.EnemyCatapultsBuff | ZoneCardEnums.EnemySwordsmensBuff | ZoneCardEnums.MyArrowsBuff |  ZoneCardEnums.MySwordsmensBuff | ZoneCardEnums.MyCatapultsBuff;
    public ZoneCardEnums ZoneType;   

    private List<RegularCardScoreControl> cards;

    private Line line;
    private TableZone tableZone;

    public void Awake()
    {
        line = transform.parent.GetComponent<Line>();
        tableZone = transform.parent.parent.GetComponent<TableZone>();
        cards = new();
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (!eventData.pointerDrag.TryGetComponent(out CardController card)) return;
          
        if ((ZoneType & card.GetComponent<CardView>().getCardZone) == 0 || !card.IsDraggable)
            return;
        if ((ZoneType & buffLines) != 0 && transform.childCount>0 )
            return;
        card.transform.SetParent(transform);
              
        tableZone.DropCardOnZone(card);
        //card.checkSpell проверить спелл 
        if (card.GetComponent<ICardSpell>() != null) 
        {
            card.GetComponent<ICardSpell>().Spell();
        }
        if (!card.GetComponent<SpellCardVeiw>())
        {
          //  cards.Add(card.GetComponent<RegularCardScoreControl>());
            line.AddCardOnLine(card.GetComponent<RegularCardScoreControl>());
        }
       
    }

    


}
