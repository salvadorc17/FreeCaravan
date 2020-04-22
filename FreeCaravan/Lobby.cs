using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IrrKlang;
using System.Drawing;
using System.IO;

namespace FreeCaravan
{
    public partial class Lobby: Form
    {
        public Player player, oponent;
        public Game Game;
        private List<Card> PCards, OCards;
        private List<string> Cardtexts;
        private string playerdeck, optdeck;
        private Main Main;    
        private ISoundEngine soundEngine;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox3;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Label label5;
        private Button button2;
        private Button button1;

        private System.ComponentModel.IContainer components = null;

        #region WindowsForms
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		
		protected void InitializeComponent()
		{
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::FreeCaravan.Properties.Resources.back;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(206, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 350);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(198, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Deck:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(201, 241);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(99, 21);
            this.comboBox3.TabIndex = 14;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(201, 195);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(99, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(236, 110);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(64, 17);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Training";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(167, 248);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(167, 199);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(34, 242);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(127, 20);
            this.textBox3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Player:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(127, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time limit:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Single",
            "LAN"});
            this.comboBox1.Location = new System.Drawing.Point(140, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Game Mode:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Play Game - Setup";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lobby
            // 
            this.ClientSize = new System.Drawing.Size(784, 549);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lobby";
            this.Load += new System.EventHandler(this.Lobby_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        public Lobby(Main main, ISoundEngine soundengine)
        {

            InitializeComponent();
            Main = main;
            soundEngine = soundengine;
            PCards = new List<Card>();
            OCards = new List<Card>();
            Cardtexts = new List<string>();

        }

        private void Clean()
        {
            panel1.Hide();
            this.BackgroundImage = null;
           



        }

         
        private  List<Card> LoadDeckCards(string deckfile)
        {
            List<Card> Cards = new List<Card>();
            Cardtexts.Clear();

            if (comboBox2.SelectedItem != null)
                using (StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "decks/" + deckfile + ".deck"))
            {

                reader.ReadLine();

                for (int i = 0; i <= 9; i++)
                {

                    string card = reader.ReadLine();
                    if (card != null)
                        Cardtexts.Add(card);

                }

            }

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "cards.cdb"))
               Commands.LoadCardDatabase(AppDomain.CurrentDomain.BaseDirectory + "cards.cdb");

            for (int i = 0; i <= Cardtexts.Count - 1; i++)
                    if (Cardtexts[i] != null)
                        {
                           Cards.Add(Commands.SelectCard(Cardtexts[i]));
                           Cards[i].Texture = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "pics/" + Cardtexts[i] + ".png");

                        }

            return Cards;
        }

        private void CreatePlayers()
        {

            PCards.Clear();
            player = new Player(1, "Player", new Deck(1, playerdeck), false);
            PCards = LoadDeckCards(playerdeck);
            player.MainDeck.Cards = PCards;
            //player.MainDeck.FillCards(Cardtexts);

            OCards.Clear();
            oponent = new Player(2, "Computer", new Deck(2, optdeck), true);
            OCards = LoadDeckCards(optdeck);
            oponent.MainDeck.Cards = OCards;

        }


        private void Lobby_Load(object sender, EventArgs e)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "textures/bg.jpg"))
                this.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "textures/bg.jpg");


            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "decks"))
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();

                DirectoryInfo dir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "decks");
                foreach (FileInfo file in dir.GetFiles())
                    if (file.Extension == ".deck")
                        {
                        comboBox2.Items.Add(file.Name.Split('.')[0]);
                        comboBox3.Items.Add(file.Name.Split('.')[0]);

                        }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string current = "";

            if (comboBox1.Items != null)
                current = comboBox1.SelectedItem.ToString();

            switch (current)
                    {
                case "Single":

                            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "options.conf"))


                using (StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "options.conf"))
                {

                    reader.ReadLine();
                    string name = reader.ReadLine().Split('=')[1];
                    string serverip = reader.ReadLine().Split('=')[1];
                    textBox2.Text = serverip;
                   

                }

                   if (player != null)
                        textBox2.Text = player.Name;

                   textBox3.Text = "Computer";
                   checkBox2.Checked = true;
                    break;


                case "LAN":

                    break;

                    }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Game == null)
            {

                
                Clean();
                CreatePlayers();
                soundEngine.Play2D(AppDomain.CurrentDomain.BaseDirectory + "sound/menu.wav");
                Game = new Game(player, oponent, soundEngine);
                Game.TopLevel = false;
                Game.Location = new Point(0, 0);
                this.Controls.Add(Game);
                Game.Show();


            }

            else
            {
                Clean();
                Game.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
                     playerdeck = comboBox2.SelectedItem.ToString();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null)
                optdeck = comboBox3.SelectedItem.ToString();
        }


    }
}
