using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeCaravan
{
  public class Deck
    {

      public int Id;
      public string Name;
      public List<Card> Cards;

      public Deck( int id, string name)
          {

              Id = id;
              Name = name;
              Cards = new List<Card>();
              

          }

      public void FillCards(List<string> cardtexts)
          {

              if (Cards != null)
                  for (int i = 0; i >= cardtexts.Count - 1; i++)
                      Cards.Add(Commands.SelectCard(cardtexts[i]));


          }

    }
}
