using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeCaravan
{
   public class Duel
    {


       public AI AI;
       public int TurnCount;
       public DuelPhase Phase;
       public bool PlayerTurn, CanMove, AIMove;

       public Duel()
        {
            TurnCount = 0;
            Phase = DuelPhase.Draw;
            PlayerTurn = true;
            CanMove = false;
            AI = new AI(this);
        }

       public void ShuffleDeck(List<Card> list)
       {
           int n = list.Count - 1;
           Random rnd = new Random();
           while (n > 1)
           {
               int k = (rnd.Next(0, n));
               n--;
               Card value = list[k];
               list[k] = list[n];
               list[n] = value;
           }
       }

       public void DrawHand(Player player, List<Card> list, int totalcards)
       {
           List<Card> Hand = new List<Card>();

           if (list != null)
           {
               int count = 0;
               int n = list.Count - 1;
               while (n >= 0)
               {

                   Card value = list[n];
                   Hand.Add(value);

                   if (count < totalcards)
                       list.RemoveAt(n);
                   n--;
                   count++;

               }

               for (int i = totalcards; i >= 0; i--)
                   if (Hand[i] != null)
                       player.Hand[i] = Hand[i];

           }

       }

       public void DrawCard(Player player, List<Card> list)
       {
           
           Card value = null;

           if (list != null)
           {
               int count = 0;
               int n = list.Count - 1;

              value = list[n];

              if (count < 1)
                   list.RemoveAt(n);
                   count++;

               

           }

           if (player.Hand[0] == null)
               player.Hand[0] = value;
           else if (player.Hand[1] == null)
               player.Hand[1] = value;
           else if (player.Hand[2] == null)
               player.Hand[2] = value;
           else if (player.Hand[3] == null)
               player.Hand[3] = value;
           else if (player.Hand[4] == null)
               player.Hand[4] = value;
           else if (player.Hand[5] == null)
               player.Hand[5] = value;


           if (PlayerTurn)
               DoDraw(player);
           else
                {
                Phase = DuelPhase.Draw;
                DoComputerDraw(player);
                }
       }

       public void EndTurn(Player player)
        {

            
            Phase = DuelPhase.End;

            DoEndTurn(player);

        }

       public void DoNewTurn(Player player)
        {
           
           if (PlayerTurn)
               {

               if (Phase == DuelPhase.Start)
                   DrawCard(player, player.MainDeck.Cards);


               }

         
        }

       public void DoDraw(Player player)
         {

             if (PlayerTurn)
             {


                 if (Phase == DuelPhase.Draw)
                      {
                     Phase = DuelPhase.Action;
                     CanMove = true;
                      }

             }


         }


       public void DoAction(Player player)
           {
           
           if (PlayerTurn)
               {

               

                   if (Phase == DuelPhase.Action)
                        {
                   CanMove = false;
                   EndTurn(player);
                        }
                }

            }

         public void DoEndTurn(Player player)
         {

             if (PlayerTurn)
             {



                 if (Phase == DuelPhase.End)
                     {
                     CanMove = false;
                     PlayerTurn = false;
                     TurnCount += 1;
                     Phase = DuelPhase.Start;
                     }

             }


         }

         public void DoComputerEnd(Player player)
         {

             if (!PlayerTurn)
             {



                 if (Phase == DuelPhase.End)
                 {
                     PlayerTurn = true;
                     TurnCount += 1;
                     Phase = DuelPhase.Start;
                 }

             }


         }

       public void DoComputerTurn(Player oponent)
           {

           if (!PlayerTurn)
                 {
                     
                 
                    if (Phase == DuelPhase.Start)
                              {
                             DrawCard(oponent, oponent.MainDeck.Cards);
                             
                              }

                     }
                     

                 }

       public void DoComputerDraw(Player oponent)
       {

           if (!PlayerTurn)
           {


               if (Phase == DuelPhase.Draw)
               {
                   Phase = DuelPhase.Action;

                   DoComputerAction(oponent);
                   
               }

           }

       }

       public void DoComputerAction(Player oponent)
       {

           if (!PlayerTurn)
           


               if (Phase == DuelPhase.Action)
               {
                   AI.AIDoAction(oponent);
                   AIMove = false;
                   DoComputerEnd(oponent);
               }
           }

       }

     }


   public enum DuelPhase
   {

       Start = 0,
       Draw = 1,
       Action = 2,
       End = 3


   }

