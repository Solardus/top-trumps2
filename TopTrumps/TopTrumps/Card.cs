using System;
using System.Collections.Generic;
using System.Text;

namespace TopTrumps
{
    public class Card
    {
        public string name;
        public int damage;
        public int health;
        public int coolness;
        public int gore;
        public int speed;
    
    
        public Card(string n, int dmg, int hlth, int cool, int g, int s) {
            name = n;
            damage = dmg;
            health = hlth;
            coolness = cool;
            gore = g;
            speed = s;
        }

        // Copy constructor
        public Card(Card c) {
            name = c.name;
            damage = c.damage;
            health = c.health;
            coolness = c.coolness;
            gore = c.gore;
            speed = c.speed;
        }

    
    }
}
