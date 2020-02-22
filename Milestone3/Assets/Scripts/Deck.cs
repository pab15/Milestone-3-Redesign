using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;


public class Tuple<T, U>
{
    public T Item1 { get; private set; }
    public U Item2 { get; private set; }

    public Tuple(T item1, U item2)
    {
        Item1 = item1;
        Item2 = item2;
    }
}

public static class Tuple
{
    public static Tuple<T, U> Create<T, U>(T item1, U item2)
    {
        return new Tuple<T, U>(item1, item2);
    }
}
public class Deck 
{
    protected LinkedList<Card> Cards { get; set; }

    public Deck()
    {
        Cards = new LinkedList<Card>();
    }

    public void AddToTop(Card card)
    {
        Cards.AddLast(card);
    } 

    public Card RemoveFromTop()
    {
        Card topCard = Cards.Last();
        Cards.RemoveLast();
        return topCard;

    }

    public void AddToBottom(Card card)
    {
        Cards.AddFirst(card);
    }

    public Card RemoveFromBottom()
    {
        Card bottomCard = Cards.First();
        Cards.RemoveFirst();
        return bottomCard;

    }

    public Tuple<LinkedList<Card>, LinkedList<Card>> Cut()
    {
        int whereToCut = (Cards.Count)/ 2;

        LinkedList<Card> firstHalf = new LinkedList<Card>();
        LinkedList<Card> secondHalf = new LinkedList<Card>();

        int count = 0;
        while (count < whereToCut && Cards.First() != null)
        {
            Card first_card = Cards.First();
            Cards.RemoveFirst();
            firstHalf.AddLast(first_card);
            count++;
        }
        while (Cards.Count > 0)
        {
            Card first_card = Cards.First();
            Cards.RemoveFirst();
            secondHalf.AddLast(first_card);
        }

        return Tuple.Create(firstHalf, secondHalf);
    }

    public void Shuffle()
    {
        for (int i = 1; i < 1001; i++)
        {
            Tuple<LinkedList<Card>, LinkedList<Card>> cutDeck = Cut();
            LinkedList<Card> topHalf = cutDeck.Item1;
            LinkedList<Card> bottomHalf = cutDeck.Item2;
            Random random_int = new Random();
            int generated = random_int.Next(0, 5);
            if (generated % 3 == 0)
            {
                while (topHalf.Count > 0 && bottomHalf.Count > 0)
                {
                    Card firstBottom = bottomHalf.First();
                    Cards.AddLast(firstBottom);
                    bottomHalf.RemoveFirst();
                    Card lastTop = topHalf.Last();
                    Cards.AddLast(lastTop);
                    topHalf.RemoveLast();
                }
            }
            else if (generated % 4 == 0)
            {
                while (topHalf.Count > 0 && bottomHalf.Count > 0)
                {
                    Card lastBottom = bottomHalf.Last();
                    Cards.AddLast(lastBottom);
                    bottomHalf.RemoveLast();
                    Card firstTop = topHalf.First();
                    Cards.AddLast(firstTop);
                    topHalf.RemoveFirst();
                }
            }
            else if (generated % 2 == 0)
            {
                while(topHalf.Count > 0 && bottomHalf.Count > 0)
                {
                    Card firstBottom = bottomHalf.First();
                    Cards.AddLast(firstBottom);
                    bottomHalf.RemoveFirst();
                    Card firstTop = topHalf.First();
                    Cards.AddLast(firstTop);
                    topHalf.RemoveFirst();
                }
            }
            else if (generated % 2 == 1)
            {
                while (topHalf.Count > 0 && bottomHalf.Count > 0)
                {
                    Card lastBottom = bottomHalf.Last();
                    Cards.AddLast(lastBottom);
                    bottomHalf.RemoveLast();
                    Card lastTop = topHalf.Last();
                    Cards.AddLast(lastTop);
                    topHalf.RemoveLast();
                }
            }
        }
    }

    public void BottomCutToTop(Tuple<LinkedList<Card>, LinkedList<Card>> splitDeck)
    {
        LinkedList<Card> list1 = splitDeck.Item2;
        LinkedList<Card> list2 = splitDeck.Item1;
        while (list1.Count > 0)
        {
            Card toPush = list1.First();
            list1.RemoveFirst();
            Cards.AddLast(toPush);
        }
        while (list2.Count > 0)
        {
            Card toPush = list2.First();
            list2.RemoveFirst();
            Cards.AddLast(toPush);
        }
    }
}
