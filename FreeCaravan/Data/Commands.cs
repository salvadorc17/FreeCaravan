using System;
using System.Collections.Generic;
using System.Text;
using Mono.Data.Sqlite;
using System.Data;
using System.Drawing;

namespace FreeCaravan
{
   public static class Commands
    {

       public static string Dbfile;

       public static List<Card> LoadCardDatabase(string path)
           {
               List<Card> Cards = new List<Card>();


               Dbfile = path;
               string constring = "data source=" + Dbfile;
               SqliteConnection con = new SqliteConnection(constring);
               string query = null;
               query = "SELECT * FROM data";
               con.Open();
               SqliteCommand sql = new SqliteCommand(query, con);
               SqliteDataReader reader = sql.ExecuteReader();
               
               while (reader.Read())
              {
                   int id = Convert.ToInt32(reader["id"]);
                  string name = reader["Name"].ToString();
                  string type = reader["Type"].ToString();
                  string rank = reader["Rank"].ToString();
                  int val = Convert.ToInt32(reader["Value"]);
                  int zone = Convert.ToInt32(reader["Zone"]);

                  Cards.Add(new Card(id, (Type)Enum.Parse(typeof(Type), type), (Rank)Enum.Parse(typeof(Rank), rank), val, zone, false));
              }
               con.Close();
               return Cards;

           }

       public static Card SelectCard(string cardid)
       {
           Card card = null;

           string constring = "data source=" + Dbfile;
           SqliteConnection con = new SqliteConnection(constring);
           string query = null;
           query = "SELECT * FROM data WHERE (id LIKE @id)";
           string search = "%" + cardid + "%";
           SqliteCommand sql = new SqliteCommand(query, con);
           sql.Parameters.AddWithValue("@id", search);
           DataSet ds = new DataSet();
           con.Open();
           SqliteDataAdapter DataAdapter1 = new SqliteDataAdapter();
           DataAdapter1.SelectCommand = sql;
           DataAdapter1.Fill(ds, "data");

           
           
           int id = Convert.ToInt32(cardid);
           string cardname = ds.Tables[0].Rows[0][1].ToString();
           Type type = (Type)Enum.Parse(typeof(Type), ds.Tables[0].Rows[0][2].ToString());
           Rank rank = (Rank)Enum.Parse(typeof(Rank), ds.Tables[0].Rows[0][3].ToString());
           int value = Convert.ToInt32(ds.Tables[0].Rows[0][4].ToString());
           int zone = Convert.ToInt32(ds.Tables[0].Rows[0][5].ToString());
           con.Close();

           card = new Card(id, type, rank, value, zone, false);


           return card;

       }

       public static string SelectbyId(string cardid)
       {
           string constring = "data source=" + Dbfile;
           SqliteConnection con = new SqliteConnection(constring);
           string query = null;
           query = "SELECT id, name FROM data WHERE (id LIKE @id)";
           string search = "%" + cardid + "%";
           SqliteCommand sql = new SqliteCommand(query, con);
           sql.Parameters.AddWithValue("@id", search);
           DataSet ds = new DataSet();
           con.Open();
           SqliteDataAdapter DataAdapter1 = new SqliteDataAdapter();
           DataAdapter1.SelectCommand = sql;
           DataAdapter1.Fill(ds, "data");

           string cardname = ds.Tables[0].Rows[0][1].ToString();
           con.Close();


           return cardname;

       }

      


       public static string SelectbyIdName(string name)
       {
           string constring = "data source=" + Dbfile;
           SqliteConnection con = new SqliteConnection(constring);
           string query = null;
           query = "SELECT id, name FROM data WHERE (name LIKE @name)";
           string search = name;
           SqliteCommand sql = new SqliteCommand(query, con);
           sql.Parameters.AddWithValue("@name", search);
           DataSet ds = new DataSet();
           con.Open();
           SqliteDataAdapter DataAdapter1 = new SqliteDataAdapter();
           DataAdapter1.SelectCommand = sql;
           DataAdapter1.Fill(ds, "data");

           string cardid = ds.Tables[0].Rows[0][0].ToString();
           con.Close();


           return cardid;

       }

       public static string SelectbyType(string cardid)
       {
           string constring = "data source=" + Dbfile;
           SqliteConnection con = new SqliteConnection(constring);
           string query = null;
           query = "SELECT id, type FROM data WHERE (id LIKE @id)";
           string search = "%" + cardid + "%";
           SqliteCommand sql = new SqliteCommand(query, con);
           sql.Parameters.AddWithValue("@id", search);
           DataSet ds = new DataSet();
           con.Open();
           SqliteDataAdapter DataAdapter1 = new SqliteDataAdapter();
           DataAdapter1.SelectCommand = sql;
           DataAdapter1.Fill(ds, "texts");

           string cardtype = ds.Tables[0].Rows[0][1].ToString();
           con.Close();


           return cardtype;

       }

       public static string SelectbyRank(string cardid)
       {
           string constring = "data source=" + Dbfile;
           SqliteConnection con = new SqliteConnection(constring);
           string query = null;
           query = "SELECT id, rank FROM data WHERE (id LIKE @id)";
           string search = "%" + cardid + "%";
           SqliteCommand sql = new SqliteCommand(query, con);
           sql.Parameters.AddWithValue("@id", search);
           DataSet ds = new DataSet();
           con.Open();
           SqliteDataAdapter DataAdapter1 = new SqliteDataAdapter();
           DataAdapter1.SelectCommand = sql;
           DataAdapter1.Fill(ds, "texts");

           string cardrank = ds.Tables[0].Rows[0][1].ToString();
           con.Close();


           return cardrank;

       }

       public static int SelectbyValue(string cardid)
       {
           string constring = "data source=" + Dbfile;
           SqliteConnection con = new SqliteConnection(constring);
           string query = null;
           query = "SELECT id, value FROM data WHERE (id LIKE @id)";
           string search = "%" + cardid + "%";
           SqliteCommand sql = new SqliteCommand(query, con);
           sql.Parameters.AddWithValue("@id", search);
           DataSet ds = new DataSet();
           con.Open();
           SqliteDataAdapter DataAdapter1 = new SqliteDataAdapter();
           DataAdapter1.SelectCommand = sql;
           DataAdapter1.Fill(ds, "texts");

           int cardvalue = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString());
           con.Close();


           return cardvalue;

       }

       public static int SelectbyZone(string cardid)
       {
           string constring = "data source=" + Dbfile;
           SqliteConnection con = new SqliteConnection(constring);
           string query = null;
           query = "SELECT id, zone FROM data WHERE (id LIKE @id)";
           string search = "%" + cardid + "%";
           SqliteCommand sql = new SqliteCommand(query, con);
           sql.Parameters.AddWithValue("@id", search);
           DataSet ds = new DataSet();
           con.Open();
           SqliteDataAdapter DataAdapter1 = new SqliteDataAdapter();
           DataAdapter1.SelectCommand = sql;
           DataAdapter1.Fill(ds, "texts");

           int cardzone = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString());
           con.Close();


           return cardzone;

       }

       public static Image BitmapToGray(Image bt)
       {

           Bitmap bitmap = new Bitmap(bt, bt.Size);
           for (int y = 0; y < bitmap.Height; y++)
           {
               for (int x = 0; x < bitmap.Width; x++)
               {
                   Color c = bitmap.GetPixel(x, y);

                   int r = c.R;
                   int g = c.G;
                   int b = c.B;
                   int avg = (r + g + b) / 3;
                   bitmap.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
               }
           }


           return bitmap;

       }

    }
}
