using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Card
{
    public Card() { }
    public Card(int number,char suit) {
    this.number=number;
    this.suit = suit;
    }
    string skin;
    char suit { get; }
    int number { get; }
}

