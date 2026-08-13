using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using IrrKlang;

namespace FreeCaravan
{
    
    public partial class Main : Form
    {

        private ISoundEngine soundEngine;
        private ISound Music;
        public Game Game;
        public Help Help;
        private Lobby GameLobby;
        private DeckEdit deckEditor;
        private Options optionsEditor;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        public Panel panel2;
        public Panel panel1;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;     
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem playGameToolStripMenuItem;
        private ToolStripMenuItem editDeckToolStripMenuItem;
        private ToolStripMenuItem watchReplaToolStripMenuItem;
        private Button button5;
        private ToolStripMenuItem optionsToolStripMenuItem;
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchReplaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 536);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::FreeCaravan.Properties.Resources.back;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(200, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 282);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(109, 183);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Options";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(109, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Exit Game";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(109, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Edit Deck";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Watch Replay";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Play Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Game Mode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImage = global::FreeCaravan.Properties.Resources.back;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playGameToolStripMenuItem,
            this.editDeckToolStripMenuItem,
            this.watchReplaToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Visible = false;
            // 
            // playGameToolStripMenuItem
            // 
            this.playGameToolStripMenuItem.Name = "playGameToolStripMenuItem";
            this.playGameToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.playGameToolStripMenuItem.Text = "Play Game";
            this.playGameToolStripMenuItem.Click += new System.EventHandler(this.playGameToolStripMenuItem_Click);
            // 
            // editDeckToolStripMenuItem
            // 
            this.editDeckToolStripMenuItem.Name = "editDeckToolStripMenuItem";
            this.editDeckToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.editDeckToolStripMenuItem.Text = "Edit Deck";
            this.editDeckToolStripMenuItem.Click += new System.EventHandler(this.editDeckToolStripMenuItem_Click);
            // 
            // watchReplaToolStripMenuItem
            // 
            this.watchReplaToolStripMenuItem.Name = "watchReplaToolStripMenuItem";
            this.watchReplaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.watchReplaToolStripMenuItem.Text = "Watch Replay";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "FreeCaravan v 1.0";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

         }

        #endregion

        public Main()
        {
            

            InitializeComponent();
            soundEngine = new ISoundEngine();


            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "textures/bg.jpg"))
                panel2.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "textures/bg.jpg");

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "sound/music.mp3"))
                Music = soundEngine.Play2D(AppDomain.CurrentDomain.BaseDirectory + "sound/music.mp3");

            

            
        }

        public void CleanMain()
        {

            panel1.Hide();
            panel2.BackgroundImage = null;
            menuToolStripMenuItem.Visible = true;
        }


        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("FreeCaravan created by salvadorc17. 2020");

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (deckEditor == null)
            {
                CleanMain();
                soundEngine.Play2D(AppDomain.CurrentDomain.BaseDirectory + "sound/menu.wav");
                deckEditor = new DeckEdit(this, soundEngine);
                deckEditor.TopLevel = false;
                deckEditor.Location = new Point(0, 0);
                panel2.Controls.Add(deckEditor);
                deckEditor.Show();
                

            }

            else
            {

                CleanMain();
                deckEditor.Show();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (optionsEditor == null)
                {
                CleanMain();
                soundEngine.Play2D(AppDomain.CurrentDomain.BaseDirectory + "sound/menu.wav");
                optionsEditor = new Options(this, soundEngine, Music);
                optionsEditor.TopLevel = false;
                optionsEditor.Location = new Point(0, 0);
                panel2.Controls.Add(optionsEditor);
                optionsEditor.Show();


                }
            else
                {

                    CleanMain();
                optionsEditor.Show();



                }

        }

        private void editDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (optionsEditor != null)
                    optionsEditor.Hide();

            if (GameLobby != null)
                GameLobby.Hide();



            if (deckEditor == null)
            {
                CleanMain();
                soundEngine.Play2D(AppDomain.CurrentDomain.BaseDirectory + "sound/menu.wav");
                deckEditor = new DeckEdit(this, soundEngine);
                deckEditor.TopLevel = false;
                deckEditor.Location = new Point(0, 0);
                panel2.Controls.Add(deckEditor);
                deckEditor.Show();


            }

            else
            {

                CleanMain();
                deckEditor.Show();
                deckEditor.CleanSelectedCards();
                deckEditor.ReloadCardList();
                deckEditor.ClearPictureCards();


            }

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deckEditor != null)
                deckEditor.Hide();

            if (GameLobby != null)
                GameLobby.Hide();


            if (optionsEditor == null)
            {
                CleanMain();
                soundEngine.Play2D(AppDomain.CurrentDomain.BaseDirectory + "sound/menu.wav");
                optionsEditor = new Options(this, soundEngine, Music);
                optionsEditor.TopLevel = false;
                optionsEditor.Location = new Point(0, 0);
                panel2.Controls.Add(optionsEditor);
                optionsEditor.Show();


            }
            else
            {

                CleanMain();
                optionsEditor.Show();



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GameLobby == null)
            {
                CleanMain();
                soundEngine.Play2D(AppDomain.CurrentDomain.BaseDirectory + "sound/menu.wav");
                GameLobby = new Lobby(this, soundEngine);
                GameLobby.TopLevel = false;
                GameLobby.Location = new Point(0, 0);
                panel2.Controls.Add(GameLobby);
                GameLobby.Show();


            }

            else
            {

                CleanMain();
                GameLobby.Show();

            }
        }

        private void playGameToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (deckEditor != null)
                deckEditor.Hide();


            if (optionsEditor != null)
                optionsEditor.Hide();


            if (GameLobby == null)
            {
                //CleanMain();
                soundEngine.Play2D(AppDomain.CurrentDomain.BaseDirectory + "sound/menu.wav");
                GameLobby = new Lobby(this, soundEngine);
                GameLobby.TopLevel = false;
                GameLobby.Location = new Point(0, 0);
                panel2.Controls.Add(GameLobby);
                GameLobby.Show();


            }
            else
            {
                this.Game = GameLobby.Game;

                if (Game != null)
                    Game.CleanGame();

                CleanMain();
                GameLobby.Show();

                


            }
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GameLobby != null)
            if (Game == null)
            {

                Help = new Help(null);
                Help.Show();


            }

            else
            {
                Help = new Help(GameLobby.player);
                Help.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


    }
}
