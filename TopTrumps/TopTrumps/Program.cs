using System.Collections.Generic;
using System;

namespace TopTrumps
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // SET UP THE GAME
            Deck theDeck = new Deck();       

            List<Card> player1 = new List<Card>();
            List<Card> player2 = new List<Card>();

            player1.Add(theDeck.DealCard());
            player2.Add(theDeck.DealCard());
            player1.Add(theDeck.DealCard());
            player2.Add(theDeck.DealCard());
            player1.Add(theDeck.DealCard());
            player2.Add(theDeck.DealCard());
            player1.Add(theDeck.DealCard());
            player2.Add(theDeck.DealCard());
            player1.Add(theDeck.DealCard());
            player2.Add(theDeck.DealCard());


            while(true)
            {
                int player1chose = -1;
                int player2chose = -1;
                int player1stat = -1;
                int player2stat = -1;
                // Player 1 Draw card
                Console.WriteLine("PLAYER ONE TURN - CARDS REMANING {0}\n", player1.Count);
                Card player1Card = player1[0];
                // Player 1 chooses a stat - pick stat, 1 - 5
                Console.WriteLine("Name: {0}", player1Card.name);
                Console.WriteLine("1 - Coolness: {0}", player1Card.coolness);
                Console.WriteLine("2 - Damage: {0}", player1Card.damage);
                Console.WriteLine("3 - Gore: {0}", player1Card.gore);
                Console.WriteLine("4 - Speed: {0}", player1Card.speed);
                Console.WriteLine("5 - Health: {0}", player1Card.health);
                Console.Write("Pick A Stat: ");
                player1chose = Convert.ToInt32(Console.ReadLine());

                switch(player1chose)
                {
                    case 1:
                        player1stat = player1Card.coolness;
                        break;

                    case 2:
                        player1stat = player1Card.damage;
                        break;

                    case 3:
                        player1stat = player1Card.gore;
                        break;

                    case 4:
                        player1stat = player1Card.speed;
                        break;

                    case 5:
                        player1stat = player1Card.health;
                        break;
                }
                //Player 2 Turn
                Card player2Card = player2[0];

                switch (player1chose)
                {
                    case 1:
                        player2stat = player2Card.coolness;
                        break;

                    case 2:
                        player2stat = player2Card.damage;
                        break;

                    case 3:
                        player2stat = player2Card.gore;
                        break;

                    case 4:
                        player2stat = player2Card.speed;
                        break;

                    case 5:
                        player2stat = player2Card.health;
                        break;
                }

                if(player1stat == player2stat)
                {
                    Console.WriteLine("Draw!");
                }
                else if(player1stat > player2stat)
                {
                    Console.WriteLine("Player 1 Wins!");
                    player1.Add(new Card(player2[0]));
                    player2.RemoveAt(0);
                    Card swapingcard = new Card(player1[0]);
                    player1.RemoveAt(0);
                    player1.Add(swapingcard);
                    if(player2.Count == 0)
                    {
                        Console.WriteLine("PLAYER ONE WINS THE GAME");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Player 2 Wins!");
                    player2.Add(new Card(player1[0]));
                    player1.RemoveAt(0);
                    Card swapingcard = new Card(player2[0]);
                    player2.RemoveAt(0);
                    player2.Add(swapingcard);
                    if (player1.Count == 0)
                    {
                        Console.WriteLine("PLAYER TWO WINS THE GAME");
                        break;
                    }
                }




                //PLAYER 2 TURN!!!
                Console.WriteLine("PLAYER TWO TURN - CARDS REMANING {0}\n", player2.Count);
                player2Card = player2[0];
                // Player 1 chooses a stat - pick stat, 1 - 5
                Console.WriteLine("Name: {0}", player2Card.name);
                Console.WriteLine("1 - Coolness: {0}", player2Card.coolness);
                Console.WriteLine("2 - Damage: {0}", player2Card.damage);
                Console.WriteLine("3 - Gore: {0}", player2Card.gore);
                Console.WriteLine("4 - Speed: {0}", player2Card.speed);
                Console.WriteLine("5 - Health: {0}", player2Card.health);
                Console.Write("Pick A Stat: ");
                player2chose = Convert.ToInt32(Console.ReadLine());

                switch (player2chose)
                {
                    case 1:
                        player2stat = player2Card.coolness;
                        break;

                    case 2:
                        player2stat = player2Card.damage;
                        break;

                    case 3:
                        player2stat = player2Card.gore;
                        break;

                    case 4:
                        player2stat = player2Card.speed;
                        break;

                    case 5:
                        player2stat = player2Card.health;
                        break;
                }
                //Player 2 Turn
                player2Card = player2[0];

                switch (player2chose)
                {
                    case 1:
                        player1stat = player1Card.coolness;
                        break;

                    case 2:
                        player1stat = player1Card.damage;
                        break;

                    case 3:
                        player1stat = player1Card.gore;
                        break;

                    case 4:
                        player1stat = player1Card.speed;
                        break;

                    case 5:
                        player1stat = player1Card.health;
                        break;
                }

                if (player2stat == player1stat)
                {
                    Console.WriteLine("Draw!");
                }
                else if (player1stat > player2stat)
                {
                    Console.WriteLine("Player 1 Wins!");
                    player1.Add(new Card(player2[0]));
                    player2.RemoveAt(0);
                    Card swapingcard = new Card(player1[0]);
                    player1.RemoveAt(0);
                    player1.Add(swapingcard);
                    if (player2.Count == 0)
                    {
                        Console.WriteLine("PLAYER ONE WINS THE GAME");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Player 2 Wins!");
                    player2.Add(new Card(player1[0]));
                    player1.RemoveAt(0);
                    Card swapingcard = new Card(player2[0]);
                    player2.RemoveAt(0);
                    player2.Add(swapingcard);
                    if (player1.Count == 0)
                    {
                        Console.WriteLine("PLAYER TWO WINS THE GAME");
                        break;
                    }
                }
                //Next Rounds

                /*
                * 4: "Scorpion"
                * 1) Damage = 100
                * 2) Health = 50...etc
                */

                // Player 2 chooses a card

                // Compare stats of player 1's and player 2's card

                // pick winner

                // award winner losers card



                // Player 2 chooses a card
                // Player 2 chooses a stat

                // Player 1 chooses a card

                // Compare stats of player 1's and player 2's card

                // pick winner

                // award winner losers card
            }



        }
    }
}
