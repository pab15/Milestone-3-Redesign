using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddDeck : MonoBehaviour
{
    public void OnClickAddDeck()
    {
        PokerDeck deckToAdd = new PokerDeck();
        GameManager._deck.Merge(deckToAdd);
        Debug.Log(GameManager._deck.Cards.Count);
    }
}
