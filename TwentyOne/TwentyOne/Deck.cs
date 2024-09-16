using System;
using System.Collections.Generic;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
            //List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            //List<string> Faces = new List<string>()
            //{
            //    "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
            //    "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            //};
            //foreach (string face in Faces)
            //{
            //    //foreach (string suit in Suits)
            //    //{
            //    //    Card card = new Card();
            //    //    card.Suit = suit;
            //    //    card.Face = face;
            //    //    Cards.Add(card);
            //    //}
            //}
        }

        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            Random random = new Random(); // Initialize Random once

            for (int i = 0; i < times; i++)
            {
                List<Card> tempList = new List<Card>();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    tempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = tempList;
            }
        }
    }
}
