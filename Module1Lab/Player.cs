using System;
using System.IO;
using System.Collections.Generic;
namespace Module1Lab
{
    public class Player
    {
        string name {get; set;}

       public Playerhand hand {get;set;}

        public Player(string NAME){
            name=NAME;
            hand = new Playerhand();
        }

        public void display(){
            Console.WriteLine($"{name} has these cards: ");
            for (int i=0; i<5; i++){
                Console.WriteLine($"{hand.cardArray[i].suit} {hand.cardArray[i].face}");
            }
        }

    }
}