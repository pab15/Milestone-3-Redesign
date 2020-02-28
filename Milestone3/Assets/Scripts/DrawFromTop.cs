using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawFromTop : MonoBehaviour
{
    public void OnClickDrawTop()
    {
        PokerCard drawnCard = (PokerCard)GameManager._deck.RemoveFromTop();
        Debug.Log("<Name: " + drawnCard.Name + ">, <Suit: " + drawnCard.suit + ">, <Value: " + drawnCard.value + ">");
    }
}
