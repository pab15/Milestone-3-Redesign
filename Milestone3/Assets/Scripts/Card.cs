using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Card
{
    public string Name { get; set; }
    public bool isFaceUp { get; set; }

    public Card()
    {
        Name = "";
        isFaceUp = false;
    }

    public void Flip()
    {
        if (isFaceUp == false)
        {
            isFaceUp = true;
        }
        else
        {
            isFaceUp = false;
        }
    }
}

