using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        public Deck() //constructor always goes before properties //assigning values to object immediatlye upon creation
        {
            Cards = new List<Card>();
            //nested foreach loop
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            //create deck
            //foreach item in each list suits it will loop 4 times
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }


    }
}

//inside class we have constructor which is a method that is called 
//as soon as object is created
//first thing is instantiate card as an empty list of cards
//creates two more lists which are instantiated
//1 with 13, 1 with 4, * = 52
//each items in faces list looped 4 times
//during each list we create a card and assign suit
//add card to cards list
//"card" only exists in loop