using System;

public class PokerCard : Card
{
    public string suit { get; set; }
    public int value { get; set; }

    public void SetCardSuit()
    {
        string[] split_card = Name.Split('_');
        suit = split_card[2];
    }
    public void SetCardValue()
    {
        string[] split_card = Name.Split('_');
        try
        {
            value = Int32.Parse(split_card[0]);
        }
        catch (FormatException)
        {
            if (split_card[0] == "ace")
            {
                value = 11;
            }
            else
            {
                value = 10;
            }
        }
    }
}
