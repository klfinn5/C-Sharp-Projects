using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        //constructor method 
        public Card() //default values
        {
            Suit = "Spades";
            Face = "Two";
        }

        public string Suit { get; set; } //only two things you can do with property
        public string Face { get; set; }

    }
}


//state; giving classes properties
//dont do anything frfr

//the card class has a property of data stype string called suit
//you can get or set this property
//public = accessible to other parts of program
//you dont need many properties 1 or 2 are fine
//a class is a model 
//design for an object
//objects = cookie, class = cookie cutter