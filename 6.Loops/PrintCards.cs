//Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).

using System;

class PrintCards
{
    static void Main()
    {
        string[] cards = new string[13] {"Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King","Ace"};
        string[] colors = new string[4] {"Clubs","Diamonds","Hearts","Spades"};
        for (int i = 0; i < colors.Length; i++)
        {
            for (int j = 0; j < cards.Length; j++)
            {
                Console.WriteLine("{0} of {1}",cards[j],colors[i]);
            }
        }
    }
}
