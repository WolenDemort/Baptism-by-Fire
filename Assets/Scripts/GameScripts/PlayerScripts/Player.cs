using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Hand hand;
    [SerializeField]
    DeckPanel panel;
    [SerializeField]
    PlayingDeck deck;
    // Start is called before the first frame update
    private void Awake()
    {
        hand = new Hand(deck);
        panel.HandConstructor(hand);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
