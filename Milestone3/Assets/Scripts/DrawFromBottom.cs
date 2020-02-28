using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawFromBottom : MonoBehaviour
{
    public void OnClickDrawBottom()
    {
        PokerCard drawnCard = (PokerCard)GameManager._deck.RemoveFromBottom();
        Debug.Log("<Name: " + drawnCard.Name + ">, <Suit: " + drawnCard.suit + ">, <Value: " + drawnCard.value + ">");
    }
}
