using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeCaravan
{
    public class Player
    {
        public int Id, Level, Experience;
        public int[] ZoneValue;
        public string Name;
        public Card SelectedCard;
        public Card[] Hand;
        public Card[] FieldZoneA;
        public Card[] FieldZoneB;
        public Deck MainDeck;
        public bool isComputer;

        public Player(int id, string name, Deck deck, bool computer)
            {

                Id = id;
                Name = name;
                MainDeck = deck;
                SelectedCard = null;
                ZoneValue = new int[4];
                Hand = new Card[6];
                FieldZoneA = new Card[4];
                FieldZoneB = new Card[4];
                isComputer = computer;

            }

    }
}
