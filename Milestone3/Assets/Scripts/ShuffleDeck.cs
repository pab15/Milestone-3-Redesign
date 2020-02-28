using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuffleDeck : MonoBehaviour
{
    public void OnClickShuffleDeck()
    {
        GameManager._deck.Shuffle();
        foreach(PokerCard card in GameManager._deck.Cards)
        {
            Debug.Log("<Name: " + card.Name + ">, <Suit: " + card.suit + "> , <Value: " + card.value + ">");
        }
        Debug.Log(GameManager._deck.Cards.Count);
    }
}
