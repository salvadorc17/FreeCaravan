using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IrrKlang;
using System.IO;
using System.Drawing;

namespace FreeCaravan
{
    public partial class Options: Form
    {

        private Main Main;
        private Player Player;
        private Image[] coverimage;
        private bool[] coverselected, avatarselected;
        private string cover, avatar;
        private ISoundEngine soundEngine;
        private ISound Music;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TrackBar trackBar1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ToolTip toolTip1;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private ComboBox comboBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label7;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(28, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 393);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackgroundImage = global::FreeCaravan.Properties.Resources.back;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.53556F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.46444F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 464F));
            this.tableLayoutPanel3.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 356);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(700, 30);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 20);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImage = global::FreeCaravan.Properties.Resources.back;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.6129F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.3871F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox5, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox6, 3, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 159);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(700, 196);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(332, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(98, 85);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(5, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cover:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(5, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Avatar:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(116, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 85);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(221, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 85);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(116, 102);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 71);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(221, 102);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 71);
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(332, 102);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 71);
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::FreeCaravan.Properties.Resources.back;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.14286F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.85714F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.trackBar1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 1, 4);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 159);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(5, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Language:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(5, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Server IP:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(5, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nickname:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(5, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Volume:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(132, 98);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(320, 25);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 19);
            this.comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(5, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Music:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 22);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "english",
            "spanish"});
            this.comboBox2.Location = new System.Drawing.Point(132, 131);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 19);
            this.comboBox2.TabIndex = 11;
            // 
            // Options
            // 
            this.ClientSize = new System.Drawing.Size(784, 549);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        public Options(Main main, ISoundEngine soundengine, ISound music)
            {

                InitializeComponent();
                Main = main;
                soundEngine = soundengine;
                Music = music;
                coverselected = new bool[3];
                avatarselected = new bool[3];
                coverimage = new Image[3];
                comboBox1.Items.Clear();
                comboBox1.Items.Add("music");

            }

        private void Options_Load(object sender, EventArgs e)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "textures/bg.jpg"))
                this.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "textures/bg.jpg");

            if (Music != null)
                {
                trackBar1.Value = (int)Music.Volume;
                toolTip1.SetToolTip(trackBar1, Music.Volume.ToString());

                }

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "textures/avatar.jpg"))
                {
                    avatar = AppDomain.CurrentDomain.BaseDirectory + "textures/avatar.jpg";
                pictureBox1.BackgroundImage = Image.FromFile(avatar);

                }

            for (int i = 1; i <= 3; i++)
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "textures/cover" + i + ".png"))
                    {


                        cover = "AppDomain.CurrentDomain.BaseDirectory +textures/cover" + i + ".png";
                        coverimage[0] = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "textures/cover.png");
                        coverimage[1] = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "textures/cover2.png");
                        coverimage[2] = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "textures/cover3.png");

                    }

            if (coverimage[0] != null)
                pictureBox4.BackgroundImage = Commands.BitmapToGray(coverimage[0]);

            if (coverimage[1] != null)
                pictureBox5.BackgroundImage = Commands.BitmapToGray(coverimage[1]);

            if (coverimage[2] != null)
                pictureBox6.BackgroundImage = Commands.BitmapToGray(coverimage[2]);


            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "options.conf"))


                using (StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "options.conf"))
                {

                    reader.ReadLine();
                    string name = reader.ReadLine().Split('=')[1];
                    Player = new Player(1, name, null, false);
                    string serverip = reader.ReadLine().Split('=')[1];
                    textBox2.Text = serverip;
                    string music = reader.ReadLine().Split('=')[1];
                    comboBox1.SelectedItem = music;
                    int volume = Convert.ToInt32(reader.ReadLine().Split('=')[1]);
                    trackBar1.Value = volume;
                    string language = reader.ReadLine().Split('=')[1];
                    comboBox2.SelectedItem = language;


                }

            if (Player != null)
            textBox1.Text = Player.Name;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (Music != null)
                {
                    Music.Volume = trackBar1.Value;
                    toolTip1.SetToolTip(trackBar1, Music.Volume.ToString());

                }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (coverselected[0] == false)
             {


                 pictureBox4.BackgroundImage = coverimage[0];
                 pictureBox5.BackgroundImage = Commands.BitmapToGray(coverimage[1]);
                 pictureBox6.BackgroundImage = Commands.BitmapToGray(coverimage[2]);
                 coverselected[1] = false;
                 coverselected[2] = false;
                 coverselected[0] = true;
            
             }
            else
            {


                pictureBox4.BackgroundImage = Commands.BitmapToGray(coverimage[0]);
                coverselected[0] = false;

            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (coverselected[1] == false)
            {


                pictureBox5.BackgroundImage = coverimage[1];
                pictureBox4.BackgroundImage = Commands.BitmapToGray(coverimage[0]);
                pictureBox6.BackgroundImage = Commands.BitmapToGray(coverimage[2]);
                coverselected[0] = false;
                coverselected[2] = false;
                coverselected[1] = true;

            }
            else
            {


                pictureBox5.BackgroundImage = Commands.BitmapToGray(coverimage[1]);
                coverselected[1] = false;

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (coverselected[2] == false)
            {


                pictureBox6.BackgroundImage = coverimage[2];
                pictureBox4.BackgroundImage = Commands.BitmapToGray(coverimage[0]);
                pictureBox5.BackgroundImage = Commands.BitmapToGray(coverimage[1]);
                coverselected[0] = false;
                coverselected[1] = false;
                coverselected[2] = true;

            }
            else
            {


                pictureBox6.BackgroundImage = Commands.BitmapToGray(coverimage[2]);
                coverselected[2] = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Player != null)
                using (StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "options.conf"))
                {

                    writer.WriteLine("--Fallout Caravan options file");
                    string name = textBox1.Text;
                    writer.WriteLine("nickname=" + name);
                    string serverip = textBox2.Text;
                    writer.WriteLine("serverip=" + serverip);
                    string music = comboBox1.SelectedItem.ToString();
                    writer.WriteLine("music=" + music);
                    int volume = trackBar1.Value;
                    writer.WriteLine("volume=" + volume);
                    string language = comboBox2.SelectedItem.ToString();
                    writer.WriteLine("language=" + language);
                    writer.WriteLine("avatar=" + avatar);
                    writer.WriteLine("cover=" + cover);

                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Hide();
            Main.panel1.Show();
            Main.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "textures/bg.jpg");
        }


    }
}
