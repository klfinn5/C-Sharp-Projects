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
            deck = Shuffle(deck);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        //
        //

        public static Deck Shuffle(Deck deck)
        {
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
