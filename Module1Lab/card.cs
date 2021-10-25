using System;
using System.IO;
using System.Collections.Generic;
namespace Module1Lab
{
    public class card
    {
        public string suit {get;set;}
        public string face {get;set;}

        public card(){
            List<String> Suits = new List<string>(){"Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
            List<String> Faces = new List<string>(){"Clubs", "Diamonds", "Spades", "Hearts"};
            Random r = new Random();
            int selectSuit = r.Next(0, Suits.Count);
            int selectFace = r.Next(0, Faces.Count);
            suit = Suits[selectSuit];
            face = Faces[selectFace];
        }


    }
}