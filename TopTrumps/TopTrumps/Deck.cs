using System;
using System.Collections.Generic;
using System.Text;

namespace TopTrumps
{

    public class Deck
    {

        public List<Card> deck = new List<Card>();
        
        public Deck ()
        {
            Card card = new Card("Erron Black", 92, 27, 22, 95, 20);
            deck.Add(card);
            card = new Card("D’vorah", 78, 27, 50, 41, 54);
            deck.Add(card);
            card = new Card("Kotal Kahn", 20, 3, 60, 19, 5);
            deck.Add(card);
            card = new Card("Kung Lao", 91, 50, 11, 73, 65);
            deck.Add(card);
            card = new Card("Noob Saibot", 43, 90, 59, 79, 49);
            deck.Add(card);
            card = new Card("Robocop", 50, 71, 48, 100, 79);
            deck.Add(card);
            card = new Card("Terminator", 95, 28, 21, 100, 79);
            deck.Add(card);
            card = new Card("Spawn", 80, 70, 100, 80, 50);
            deck.Add(card);
            card = new Card("SubZero", 90, 52, 95, 30, 35);
            deck.Add(card);
            card = new Card("Scorpion", 95, 55, 90, 30, 30);
            deck.Add(card);
        }

        public Card DealCard()
        {
            Random rndcard = new Random();
            int i = rndcard.Next(0, deck.Count);
            Card theCard = new Card(deck[i].name, deck[i].damage, deck[i].health, deck[i].coolness, deck[i].gore, deck[i].speed);
            deck.RemoveAt(i);
            return theCard;
        }
    }
}
