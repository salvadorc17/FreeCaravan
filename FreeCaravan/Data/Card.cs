using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FreeCaravan
{
    public class Card
    {

        public string Name, CardZone;
        public int ID, X, Y, Value, Zone; 
        public bool FaceUp, IsNumber;
        public Image Texture;
        public Rectangle Bounds;
        public Type Type;
        public Rank Rank;

        public Card(int id, Type type, Rank rank, int val, int zone, bool faceup)
              {
                  ID = id;
                  Type = type;
                  Rank = rank;
                  FaceUp = faceup;
                  Value = val;
                  Zone = zone;
                  

                  
                  X = 0;
                  Y = 0;
                  Bounds = new Rectangle(X, Y, 54, 70);
                  IsNumber = IsNumberCard();
                  CardZone = GetCardZone();
                  

                  Name = Enum.Parse(typeof(Rank), rank.ToString(), false) + " of " +
                            Enum.GetName(typeof(Type), type) + " (" + CardZone + ")";

              }

        public bool IsNumberCard()
        {

            bool isNumber = true;


            if (Rank == Rank.Ace)
                isNumber = false;
            else if (Rank == Rank.Jack)
                isNumber = false;
            else if (Rank == Rank.Queen)
                isNumber = false;
            else if (Rank == Rank.King)
                isNumber = false;


            return isNumber;
        
        
        }

        public string GetCardZone()
        {

            string CardZone = "";
        
        switch (Type)
            {
        
            case Type.Diamonds:


                    if (IsNumber == true)
                        CardZone = "B";
                    else
                        CardZone = "A";

                    Zone = 1;

                    break;

            case Type.Clubs:


                    if (IsNumber == true)
                        CardZone = "B";
                    else
                        CardZone = "A";

                    Zone = 2;

                    break;

            case Type.Hearths:


                    if (IsNumber == true)
                        CardZone = "B";
                    else
                        CardZone = "A";

                    Zone = 3;

                    break;

            case Type.Spades:


                    if (IsNumber == true)
                        CardZone = "B";
                    else
                        CardZone = "A";

                    Zone = 4;

                    break;


            }


        return CardZone + Zone;
        }

    }
}
