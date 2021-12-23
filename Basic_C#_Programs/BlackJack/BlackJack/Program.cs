using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args) //args parameter //static method used without first creating object of class
        {

            Deck deck = new Deck(); //data type then variable =
            int timesShuffled = 0;
            //deck = Shuffle(deck);
            deck = Shuffle(deck, out timesShuffled, 3); 
            //shuffle more than once == deck = Shuffle(deck, 3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled: {0}", timesShuffled); //stating how many times shuffled
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        //verified that deck was shuffled certain amt, throw out value back to var already defined
        //overloaded method = optional 
        /*public static Deck Shuffle(Deck deck, int times = 1)*/ //times default value  = 1, optional parameter
        {
            timesShuffled = 0;
            for (int i = 0, i < times, i++)
            {
                timesShuffled++; //adding one //shuffle more than once
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }

                deck.Cards = TempList;
                return deck;
            }
            
        }

        ////shuffle more than once
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}


    }
}



//notes
//objects backbone of object oriented programming
//state; giving classes properties
//object doesnt exist until we create it, a plan does first


//object of data type card assigned to variable cardOne
//camelcase cardOne preferred naming method

//give properties value

//assigned string queen to property face of object cardOne
//wrench = property
