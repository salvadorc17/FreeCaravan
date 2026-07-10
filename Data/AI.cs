using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeCaravan
{
   public class AI
    {

       public Duel Duel;
       public Card SelectedCard;

       public AI(Duel duel)
           {

               Duel = duel;
               SelectedCard = null;

           }

       public Card AISelectCard(Player oponent)
           {

               Card Card = null;
               List<Card> Hand = new List<Card>();

           if (oponent.Hand.Count() > 0)
               {
           for (int i = 0; i <= oponent.Hand.Count() - 1; i++)
               if (oponent.Hand[i] != null)
               Hand.Add(oponent.Hand[i]);

           Random rnd = new Random();
           int random = rnd.Next(0, Hand.Count - 1);

           Card = Hand[random];

               }
           return Card;

           }

       public void AIDoAction(Player oponent)
           {

           if (oponent != null)
               {

                   SelectedCard = AISelectCard(oponent);

                   for (int i = 0; i <= oponent.Hand.Count() - 1; i++)
                       if (oponent.Hand[i] == SelectedCard)
                           oponent.Hand[i] = null;

               switch (SelectedCard.CardZone)
                        {
                   case "A1":

                       oponent.FieldZoneA[0] = SelectedCard;
                        SelectedCard = null;
                        oponent.ZoneValue[0] += oponent.FieldZoneA[0].Value;

                         break;

                   case "B1":
                        
                        oponent.FieldZoneB[0] = oponent.SelectedCard;
                        SelectedCard = null;
                        oponent.ZoneValue[0] += oponent.FieldZoneB[0].Value;
                        break;

                   case "A2":
                        oponent.FieldZoneA[1] = oponent.SelectedCard;
                        SelectedCard = null;
                        oponent.ZoneValue[1] += oponent.FieldZoneA[1].Value;
                        break;

                   case "B2":
                        oponent.FieldZoneB[1] = oponent.SelectedCard;
                        SelectedCard = null;
                        oponent.ZoneValue[1] += oponent.FieldZoneB[1].Value;
                        break;

                   

                    case "A3":
                        oponent.FieldZoneA[2] = SelectedCard;
                        SelectedCard = null;
                        oponent.ZoneValue[2] += oponent.FieldZoneA[2].Value;
                        break;

                    case "B3":
                        oponent.FieldZoneB[2] = SelectedCard;
                        SelectedCard = null;
                        oponent.ZoneValue[2] += oponent.FieldZoneB[2].Value;

                        break;
                    case "A4":

                        oponent.FieldZoneA[3] = SelectedCard;
                        SelectedCard = null;
                        oponent.ZoneValue[3] += oponent.FieldZoneA[3].Value;
                        break;

                    case "B4":
                        oponent.FieldZoneB[3] = SelectedCard;
                        SelectedCard = null;
                        oponent.ZoneValue[3] += oponent.FieldZoneB[3].Value;
                        break;
                        }
               }

           }



    }
}
