using System;
using System.IO;
using System.Collections.Generic;
namespace Module1Lab
{
    public class Playerhand
    {
        public card[] cardArray = new card[5];

        public Playerhand(){
            card card1 = new card();
            card card2 = new card();
            card card3 = new card();
            card card4 = new card();
            card card5 = new card();
            cardArray = new card[]{card1, card2, card3, card4,card5};
        }         
        
        


    }
}