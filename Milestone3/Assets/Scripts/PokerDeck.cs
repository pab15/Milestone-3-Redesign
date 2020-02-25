using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokerDeck : Deck
{
    public PokerDeck()
    {
        var materials = PokerCardFactory.GetInstance().Materials;
        foreach (var material in materials)
        {
            PokerCard new_card = new PokerCard();
            new_card.Name = material.Key;
            new_card.SetCardSuit();
            new_card.SetCardValue();
            AddToTop(
                        new_card
                    ) ;
        }
    }
}
