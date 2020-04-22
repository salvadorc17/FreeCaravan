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
    public partial class Game: Form
    {

        public Player Player, Oponent;
        private Duel Duel;
        private Card SelectedCard;
        private Image cover;
        private ISoundEngine Soundengine;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Timer timer1;
        private PictureBox pictureBox2;
        private ToolTip toolTip1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox14;
        private PictureBox pictureBox13;
        private PictureBox pictureBox12;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem addToZone1RedToolStripMenuItem;
        private ToolStripMenuItem addToZone2BlackToolStripMenuItem;
        private ToolStripMenuItem addToZone3RedToolStripMenuItem;
        private ToolStripMenuItem addToZone4BlackToolStripMenuItem;
        private PictureBox pictureBox22;
        private PictureBox pictureBox21;
        private PictureBox pictureBox20;
        private PictureBox pictureBox19;
        private PictureBox pictureBox18;
        private PictureBox pictureBox17;
        private PictureBox pictureBox16;
        private PictureBox pictureBox15;
        private PictureBox pictureBox24;
        private PictureBox pictureBox23;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private PictureBox pictureBox26;
        private PictureBox pictureBox25;
        private PictureBox pictureBox34;
        private PictureBox pictureBox33;
        private PictureBox pictureBox32;
        private PictureBox pictureBox31;
        private PictureBox pictureBox30;
        private PictureBox pictureBox29;
        private PictureBox pictureBox28;
        private PictureBox pictureBox27;
        private Label label28;
        private Label label27;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem drawToolStripMenuItem;
        private ToolStripMenuItem discardToolStripMenuItem;

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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label28 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label27 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToZone1RedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToZone2BlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToZone3RedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToZone4BlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 530);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::FreeCaravan.Properties.Resources.field;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox34);
            this.panel2.Controls.Add(this.pictureBox33);
            this.panel2.Controls.Add(this.pictureBox32);
            this.panel2.Controls.Add(this.pictureBox31);
            this.panel2.Controls.Add(this.pictureBox30);
            this.panel2.Controls.Add(this.pictureBox29);
            this.panel2.Controls.Add(this.pictureBox28);
            this.panel2.Controls.Add(this.pictureBox27);
            this.panel2.Controls.Add(this.pictureBox26);
            this.panel2.Controls.Add(this.pictureBox25);
            this.panel2.Controls.Add(this.pictureBox24);
            this.panel2.Controls.Add(this.pictureBox23);
            this.panel2.Controls.Add(this.pictureBox22);
            this.panel2.Controls.Add(this.pictureBox21);
            this.panel2.Controls.Add(this.pictureBox20);
            this.panel2.Controls.Add(this.pictureBox19);
            this.panel2.Controls.Add(this.pictureBox18);
            this.panel2.Controls.Add(this.pictureBox17);
            this.panel2.Controls.Add(this.pictureBox16);
            this.panel2.Controls.Add(this.pictureBox15);
            this.panel2.Controls.Add(this.pictureBox14);
            this.panel2.Controls.Add(this.pictureBox13);
            this.panel2.Controls.Add(this.pictureBox12);
            this.panel2.Controls.Add(this.pictureBox11);
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Controls.Add(this.pictureBox9);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 520);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox34
            // 
            this.pictureBox34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox34.Location = new System.Drawing.Point(241, 180);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(54, 70);
            this.pictureBox34.TabIndex = 34;
            this.pictureBox34.TabStop = false;
            // 
            // pictureBox33
            // 
            this.pictureBox33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox33.Location = new System.Drawing.Point(350, 180);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(54, 70);
            this.pictureBox33.TabIndex = 33;
            this.pictureBox33.TabStop = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox32.Location = new System.Drawing.Point(460, 180);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(54, 70);
            this.pictureBox32.TabIndex = 32;
            this.pictureBox32.TabStop = false;
            // 
            // pictureBox31
            // 
            this.pictureBox31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox31.Location = new System.Drawing.Point(572, 180);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(54, 70);
            this.pictureBox31.TabIndex = 31;
            this.pictureBox31.TabStop = false;
            // 
            // pictureBox30
            // 
            this.pictureBox30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox30.Location = new System.Drawing.Point(241, 94);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(54, 70);
            this.pictureBox30.TabIndex = 30;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox29
            // 
            this.pictureBox29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox29.Location = new System.Drawing.Point(350, 94);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(54, 70);
            this.pictureBox29.TabIndex = 29;
            this.pictureBox29.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox28.Location = new System.Drawing.Point(460, 94);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(54, 70);
            this.pictureBox28.TabIndex = 28;
            this.pictureBox28.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox27.Location = new System.Drawing.Point(572, 94);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(54, 70);
            this.pictureBox27.TabIndex = 27;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox26
            // 
            this.pictureBox26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox26.Location = new System.Drawing.Point(681, 180);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(54, 70);
            this.pictureBox26.TabIndex = 26;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox25.Location = new System.Drawing.Point(681, 94);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(54, 70);
            this.pictureBox25.TabIndex = 25;
            this.pictureBox25.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox24.Location = new System.Drawing.Point(681, 265);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(54, 70);
            this.pictureBox24.TabIndex = 24;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox23.Location = new System.Drawing.Point(681, 353);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(54, 70);
            this.pictureBox23.TabIndex = 23;
            this.pictureBox23.TabStop = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox22.Location = new System.Drawing.Point(241, 265);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(54, 70);
            this.pictureBox22.TabIndex = 22;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox21.Location = new System.Drawing.Point(347, 265);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(54, 70);
            this.pictureBox21.TabIndex = 21;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox20.Location = new System.Drawing.Point(455, 265);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(54, 70);
            this.pictureBox20.TabIndex = 20;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox19.Location = new System.Drawing.Point(572, 265);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(54, 70);
            this.pictureBox19.TabIndex = 19;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox18.Location = new System.Drawing.Point(241, 353);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(54, 70);
            this.pictureBox18.TabIndex = 18;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox17.Location = new System.Drawing.Point(347, 353);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(54, 70);
            this.pictureBox17.TabIndex = 17;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox16.Location = new System.Drawing.Point(455, 353);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(54, 70);
            this.pictureBox16.TabIndex = 16;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox15.Location = new System.Drawing.Point(572, 353);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(54, 70);
            this.pictureBox15.TabIndex = 15;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Click += new System.EventHandler(this.pictureBox15_Click);
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox14.Location = new System.Drawing.Point(19, 3);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(54, 70);
            this.pictureBox14.TabIndex = 14;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox13.Location = new System.Drawing.Point(126, 3);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(54, 70);
            this.pictureBox13.TabIndex = 13;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.Location = new System.Drawing.Point(241, 3);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(54, 70);
            this.pictureBox12.TabIndex = 12;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(350, 3);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(54, 70);
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(460, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(54, 70);
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(572, 3);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(54, 70);
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(19, 445);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(54, 70);
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(126, 445);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(54, 70);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(241, 445);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(54, 70);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(347, 445);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(54, 70);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(455, 445);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 70);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(572, 445);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 70);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(681, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 70);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::FreeCaravan.Properties.Resources.back;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(5, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 340);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label26, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label25, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label24, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label23, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label22, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label21, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label20, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label18, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label16, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label14, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(188, 263);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(98, 222);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(85, 20);
            this.label26.TabIndex = 42;
            this.label26.Text = "00";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(5, 222);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(85, 20);
            this.label25.TabIndex = 41;
            this.label25.Text = "Grave:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(98, 200);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 20);
            this.label24.TabIndex = 40;
            this.label24.Text = "00";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(5, 200);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(85, 20);
            this.label23.TabIndex = 39;
            this.label23.Text = "Zone1:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(98, 178);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 20);
            this.label22.TabIndex = 38;
            this.label22.Text = "00";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(5, 178);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 20);
            this.label21.TabIndex = 37;
            this.label21.Text = "Zone2:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(98, 156);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 20);
            this.label20.TabIndex = 36;
            this.label20.Text = "00";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(5, 156);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 20);
            this.label19.TabIndex = 35;
            this.label19.Text = "Zone3:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(98, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 20);
            this.label18.TabIndex = 34;
            this.label18.Text = "00";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(5, 134);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 20);
            this.label17.TabIndex = 33;
            this.label17.Text = "Zone4:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(98, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 20);
            this.label16.TabIndex = 32;
            this.label16.Text = "00";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Zone4:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(98, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "00";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Zone3:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(98, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "00";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Zone2:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(98, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "00";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Zone1:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(98, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "00";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Grave:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "00";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "00";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Deck:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Deck:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel3.Controls.Add(this.label28, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 307);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(188, 29);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(97, 2);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(85, 20);
            this.label28.TabIndex = 26;
            this.label28.Text = "None";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel2.Controls.Add(this.label27, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 14);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(188, 25);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(95, 2);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(85, 20);
            this.label27.TabIndex = 26;
            this.label27.Text = "Turn 0";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Computer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(681, 445);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 70);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToZone1RedToolStripMenuItem,
            this.addToZone2BlackToolStripMenuItem,
            this.addToZone3RedToolStripMenuItem,
            this.addToZone4BlackToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(189, 92);
            // 
            // addToZone1RedToolStripMenuItem
            // 
            this.addToZone1RedToolStripMenuItem.Name = "addToZone1RedToolStripMenuItem";
            this.addToZone1RedToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.addToZone1RedToolStripMenuItem.Text = "Add to Zone 1 (Red)";
            this.addToZone1RedToolStripMenuItem.Click += new System.EventHandler(this.addToZone1RedToolStripMenuItem_Click);
            // 
            // addToZone2BlackToolStripMenuItem
            // 
            this.addToZone2BlackToolStripMenuItem.Name = "addToZone2BlackToolStripMenuItem";
            this.addToZone2BlackToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.addToZone2BlackToolStripMenuItem.Text = "Add to Zone 2 (Black)";
            this.addToZone2BlackToolStripMenuItem.Click += new System.EventHandler(this.addToZone2BlackToolStripMenuItem_Click);
            // 
            // addToZone3RedToolStripMenuItem
            // 
            this.addToZone3RedToolStripMenuItem.Name = "addToZone3RedToolStripMenuItem";
            this.addToZone3RedToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.addToZone3RedToolStripMenuItem.Text = "Add to Zone 3 (Red)";
            this.addToZone3RedToolStripMenuItem.Click += new System.EventHandler(this.addToZone3RedToolStripMenuItem_Click);
            // 
            // addToZone4BlackToolStripMenuItem
            // 
            this.addToZone4BlackToolStripMenuItem.Name = "addToZone4BlackToolStripMenuItem";
            this.addToZone4BlackToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.addToZone4BlackToolStripMenuItem.Text = "Add to Zone 4 (Black)";
            this.addToZone4BlackToolStripMenuItem.Click += new System.EventHandler(this.addToZone4BlackToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawToolStripMenuItem,
            this.discardToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(114, 48);
            // 
            // drawToolStripMenuItem
            // 
            this.drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            this.drawToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.drawToolStripMenuItem.Text = "Draw";
            this.drawToolStripMenuItem.Click += new System.EventHandler(this.drawToolStripMenuItem_Click);
            // 
            // discardToolStripMenuItem
            // 
            this.discardToolStripMenuItem.Name = "discardToolStripMenuItem";
            this.discardToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.discardToolStripMenuItem.Text = "Discard";
            // 
            // Game
            // 
            this.BackgroundImage = global::FreeCaravan.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(768, 536);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Game(Player player, Player oponent, ISoundEngine soundengine)
        {

            InitializeComponent();
            Player = player;
            Duel = new Duel();
            Oponent = oponent;
            Soundengine = soundengine;

        }

        public void CleanGame()
        {

            panel1.Hide();
            this.BackgroundImage = null;

        }



        private void GetSelectedCard()
        {
               switch (SelectedCard.Zone)
                    {
                        case 1:

                            addToZone1RedToolStripMenuItem.Visible = true;
                            addToZone2BlackToolStripMenuItem.Visible = false;
                            addToZone3RedToolStripMenuItem.Visible = true;
                            addToZone4BlackToolStripMenuItem.Visible = false;

                            break;

                        case 2:

                            addToZone1RedToolStripMenuItem.Visible = false;
                            addToZone2BlackToolStripMenuItem.Visible = true;
                            addToZone3RedToolStripMenuItem.Visible = false;
                            addToZone4BlackToolStripMenuItem.Visible = true;

                            break;

                        case 3:

                            addToZone1RedToolStripMenuItem.Visible = true;
                            addToZone2BlackToolStripMenuItem.Visible = false;
                            addToZone3RedToolStripMenuItem.Visible = true;
                            addToZone4BlackToolStripMenuItem.Visible = false;

                            break;

                        case 4:

                            addToZone1RedToolStripMenuItem.Visible = false;
                            addToZone2BlackToolStripMenuItem.Visible = true;
                            addToZone3RedToolStripMenuItem.Visible = false;
                            addToZone4BlackToolStripMenuItem.Visible = true;

                            break;

                    }

        }

        private void Game_Load(object sender, EventArgs e)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "textures/bg.jpg"))
                this.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "textures/bg.jpg");

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "textures/cover.png"))
                cover = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "textures/cover.png");

            if (Player != null)
                {
                    label5.Text = Player.MainDeck.Cards.Count.ToString();
                    

                }

            if (Oponent != null)
                {
                    label6.Text = Oponent.MainDeck.Cards.Count.ToString();

                }

            Soundengine.Play2D(AppDomain.CurrentDomain.BaseDirectory + "sound/shuffle.wav");
            Duel.ShuffleDeck(Player.MainDeck.Cards);
            Duel.ShuffleDeck(Player.MainDeck.Cards);
            Duel.DrawHand(Player, Player.MainDeck.Cards, 5);
            Duel.DrawHand(Oponent, Oponent.MainDeck.Cards, 4);
            Duel.DoNewTurn(Player);
            Duel.DoDraw(Player);
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (Player != null)
            {
                if (Player.MainDeck.Cards.Count > 0)
                    pictureBox1.BackgroundImage = cover;
                else
                    pictureBox1.BackgroundImage = null;
                toolTip1.SetToolTip(pictureBox1, "Deck: " + Player.MainDeck.Cards.Count);

                if (Player.Hand[5] != null)
                    {
                    pictureBox3.BackgroundImage = Player.Hand[5].Texture;
                toolTip1.SetToolTip(pictureBox3, Player.Hand[5].Name);
                    }
                else
                {
                    pictureBox3.BackgroundImage = null;
                    toolTip1.SetToolTip(pictureBox3, "");
                }

                if (Player.Hand[4] != null)
                {
                    pictureBox4.BackgroundImage = Player.Hand[4].Texture;
                    toolTip1.SetToolTip(pictureBox4, Player.Hand[4].Name);
                }
                else
                {
                    pictureBox4.BackgroundImage = null;
                    toolTip1.SetToolTip(pictureBox4, "");
                }

                if (Player.Hand[3] != null)
                {
                    pictureBox5.BackgroundImage = Player.Hand[3].Texture;
                    toolTip1.SetToolTip(pictureBox5, Player.Hand[3].Name);
                }
                else
                {
                    pictureBox5.BackgroundImage = null;
                    toolTip1.SetToolTip(pictureBox5, "");
                }

                if (Player.Hand[2] != null)
                {
                    pictureBox6.BackgroundImage = Player.Hand[2].Texture;
                    toolTip1.SetToolTip(pictureBox6, Player.Hand[2].Name);
                }
                else
                {
                    pictureBox6.BackgroundImage = null;
                    toolTip1.SetToolTip(pictureBox6, "");
                }

                if (Player.Hand[1] != null)
                {
                    pictureBox7.BackgroundImage = Player.Hand[1].Texture;
                    toolTip1.SetToolTip(pictureBox7, Player.Hand[1].Name);
                }
                else
                {
                    pictureBox7.BackgroundImage = null;
                    toolTip1.SetToolTip(pictureBox7, "");
                }

                if (Player.Hand[0] != null)
                {
                    pictureBox8.BackgroundImage = Player.Hand[0].Texture;
                    toolTip1.SetToolTip(pictureBox8, Player.Hand[0].Name);
                }
                else
                {
                    pictureBox8.BackgroundImage = null;
                    toolTip1.SetToolTip(pictureBox8, "");
                }

                if (Player.FieldZoneA[0] != null)
                {
                    pictureBox22.BackgroundImage = Player.FieldZoneA[0].Texture;
                    toolTip1.SetToolTip(pictureBox22, Player.FieldZoneA[0].Name);
                }

                if (Player.FieldZoneA[1] != null)
                {
                    pictureBox21.BackgroundImage = Player.FieldZoneA[1].Texture;
                    toolTip1.SetToolTip(pictureBox21, Player.FieldZoneA[1].Name);
                }

                if (Player.FieldZoneA[2] != null)
                {
                    pictureBox20.BackgroundImage = Player.FieldZoneA[2].Texture;
                    toolTip1.SetToolTip(pictureBox20, Player.FieldZoneA[2].Name);
                }

                if (Player.FieldZoneA[3] != null)
                {
                    pictureBox19.BackgroundImage = Player.FieldZoneA[3].Texture;
                    toolTip1.SetToolTip(pictureBox19, Player.FieldZoneA[3].Name);
                }

                if (Player.FieldZoneB[0] != null)
                {
                    pictureBox18.BackgroundImage = Player.FieldZoneB[0].Texture;
                    toolTip1.SetToolTip(pictureBox18, Player.FieldZoneB[0].Name);
                }

                if (Player.FieldZoneB[1] != null)
                {
                    pictureBox17.BackgroundImage = Player.FieldZoneB[1].Texture;
                    toolTip1.SetToolTip(pictureBox17, Player.FieldZoneB[1].Name);
                }

                if (Player.FieldZoneB[2] != null)
                {
                    pictureBox16.BackgroundImage = Player.FieldZoneB[2].Texture;
                    toolTip1.SetToolTip(pictureBox16, Player.FieldZoneB[2].Name);
                }

                if (Player.FieldZoneB[3] != null)
                {
                    pictureBox15.BackgroundImage = Player.FieldZoneB[3].Texture;
                    toolTip1.SetToolTip(pictureBox15, Player.FieldZoneB[3].Name);
                }

                if (Player.SelectedCard != null)
                {
                    pictureBox24.BackgroundImage = Player.SelectedCard.Texture;
                    toolTip1.SetToolTip(pictureBox24, Player.SelectedCard.Name);
                }

                if (Player.ZoneValue[0] > 0)
                    label24.Text = Player.ZoneValue[0].ToString();

                if (Player.ZoneValue[1] > 0)
                    label22.Text = Player.ZoneValue[1].ToString();

                if (Player.ZoneValue[2] > 0)
                    label20.Text = Player.ZoneValue[2].ToString();

                if (Player.ZoneValue[3] > 0)
                    label18.Text = Player.ZoneValue[3].ToString();

                if (Duel != null)
                    label28.Text = Duel.Phase.ToString() + " Phase";

            }

            if (Oponent != null)
            {
                if (Oponent.MainDeck.Cards.Count > 0)
                    pictureBox2.BackgroundImage = cover;
                toolTip1.SetToolTip(pictureBox2, "Deck: " + Oponent.MainDeck.Cards.Count);

                if (Oponent.Hand[5] != null)
                {
                    pictureBox9.BackgroundImage = Oponent.Hand[5].Texture;
                    toolTip1.SetToolTip(pictureBox9, Oponent.Hand[5].Name);
                }

                if (Oponent.Hand[4] != null)
                {
                    pictureBox10.BackgroundImage = Oponent.Hand[4].Texture;
                    toolTip1.SetToolTip(pictureBox10, Oponent.Hand[4].Name);
                }

                if (Oponent.Hand[3] != null)
                {
                    pictureBox11.BackgroundImage = Oponent.Hand[3].Texture;
                    toolTip1.SetToolTip(pictureBox11, Oponent.Hand[3].Name);
                }

                if (Oponent.Hand[2] != null)
                {
                    pictureBox12.BackgroundImage = Oponent.Hand[2].Texture;
                    toolTip1.SetToolTip(pictureBox12, Oponent.Hand[2].Name);
                }

                if (Oponent.Hand[1] != null)
                {
                    pictureBox13.BackgroundImage = Oponent.Hand[1].Texture;
                    toolTip1.SetToolTip(pictureBox13, Oponent.Hand[1].Name);
                }

                if (Oponent.Hand[0] != null)
                {
                    pictureBox14.BackgroundImage = Oponent.Hand[0].Texture;
                    toolTip1.SetToolTip(pictureBox14, Oponent.Hand[0].Name);
                }

                if (Duel != null)
                    label27.Text = "Turn " + Duel.TurnCount.ToString();

                //if (!Duel.PlayerTurn)
                    //Duel.DoComputerTurn(Oponent);
            }


        }

        private void addToZone1RedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedCard != null)
                        {

                    Player.SelectedCard = SelectedCard;
                    for (int i = 0; i <= Player.Hand.Count() - 1; i++)
                        if (Player.Hand[i] == SelectedCard)
                            Player.Hand[i] = null;

                 switch (SelectedCard.CardZone)
                {
                    case "A1":
                        Player.FieldZoneA[0] = Player.SelectedCard;
                        SelectedCard = null;
                        Player.ZoneValue[0] += Player.FieldZoneA[0].Value;
                        break;

                    case "B1":
                        Player.FieldZoneB[0] = Player.SelectedCard;
                        SelectedCard = null;
                        Player.ZoneValue[0] += Player.FieldZoneB[0].Value;
                        break;

                     case "A3":
                        Player.FieldZoneA[2] = Player.SelectedCard;
                        SelectedCard = null;
                        Player.ZoneValue[2] += Player.FieldZoneA[2].Value;
                        break;

                     case "B3":
                        Player.FieldZoneB[2] = Player.SelectedCard;
                        SelectedCard = null;
                        Player.ZoneValue[2] += Player.FieldZoneB[2].Value;
                        break;



                }

                 Duel.DoAction(Player);

                        }

        }

        private void addToZone2BlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedCard != null)
                {

                    Player.SelectedCard = SelectedCard;
                    for (int i = 0; i <= Player.Hand.Count() - 1; i++)
                        if (Player.Hand[i] == SelectedCard)
                            Player.Hand[i] = null;
                    
                    switch (SelectedCard.CardZone)
                {
                    case "A2":
                       Player.FieldZoneA[1] = Player.SelectedCard;
                        SelectedCard = null;
                        Player.ZoneValue[1] += Player.FieldZoneA[1].Value;
                        break;

                    case "B2":
                        Player.FieldZoneB[1] = Player.SelectedCard;
                        SelectedCard = null;
                        Player.ZoneValue[1] += Player.FieldZoneB[1].Value;
                        break;

                    case "A4":
                        Player.FieldZoneA[3] = SelectedCard;
                        SelectedCard = null;
                        Player.ZoneValue[3] += Player.FieldZoneA[3].Value;
                        break;

                    case "B4":
                        Player.FieldZoneB[3] = SelectedCard;
                        SelectedCard = null;
                        Player.ZoneValue[3] += Player.FieldZoneB[3].Value;
                        break;

                }


                    Duel.DoAction(Player);

                }
        }

        private void addToZone3RedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedCard != null)
                 {

                     Player.SelectedCard = SelectedCard;
                     for (int i = 0; i <= Player.Hand.Count() - 1; i++)
                         if (Player.Hand[i] == SelectedCard)
                             Player.Hand[i] = null;

                switch (SelectedCard.CardZone)
                {
                    case "A1":
                        Player.FieldZoneA[0] = Player.SelectedCard;
                        SelectedCard = null;
                        Player.ZoneValue[0] += Player.FieldZoneA[0].Value;
                        break;

                    case "B1":
                        Player.FieldZoneB[0] = Player.SelectedCard;
                        SelectedCard = null;
                        Player.ZoneValue[0] += Player.FieldZoneB[0].Value;
                        break;

                    case "A3":
                        Player.FieldZoneA[2] = SelectedCard;
                        SelectedCard = null;
                        Player.ZoneValue[2] += Player.FieldZoneA[2].Value;
                        break;

                    case "B3":
                        Player.FieldZoneB[2] = SelectedCard;
                        SelectedCard = null;
                        Player.ZoneValue[2] += Player.FieldZoneB[2].Value;
                        break;

                }

                Duel.DoAction(Player);
                 }
        }

        private void addToZone4BlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedCard != null)
                 {

                     Player.SelectedCard = SelectedCard;
                     for (int i = 0; i <= Player.Hand.Count() - 1; i++)
                         if (Player.Hand[i] == SelectedCard)
                             Player.Hand[i] = null;

                switch (SelectedCard.CardZone)
                {
                    case "A2":
                        Player.FieldZoneA[1] = Player.SelectedCard;
                        SelectedCard = null;
                        Player.ZoneValue[1] += Player.FieldZoneA[1].Value;
                        break;

                    case "B2":
                        Player.FieldZoneB[1] = Player.SelectedCard;
                        SelectedCard = null;
                        Player.ZoneValue[1] += Player.FieldZoneB[1].Value;
                        break;

                    case "A4":
                        Player.FieldZoneA[3] = SelectedCard;
                        SelectedCard = null;
                        Player.ZoneValue[3] += Player.FieldZoneA[3].Value;
                        break;

                    case "B4":
                        Player.FieldZoneB[3] = SelectedCard;
                        SelectedCard = null;
                        Player.ZoneValue[3] += Player.FieldZoneB[3].Value;
                        break;

                }

                Duel.DoAction(Player);
                 }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Player.Hand[5] != null && Duel.CanMove)
                {

                    SelectedCard = Player.Hand[5];
                    GetSelectedCard();

                    contextMenuStrip1.Show(Cursor.Position);
                }
        }



        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (Player.Hand[4] != null & Duel.CanMove)
            {

                SelectedCard = Player.Hand[4];
                GetSelectedCard();
                
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            if (Player.Hand[3] != null & Duel.CanMove)
            {

                SelectedCard = Player.Hand[3];
                GetSelectedCard();
                
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            if (Player.Hand[2] != null & Duel.CanMove)
            {

                SelectedCard = Player.Hand[2];
                GetSelectedCard();
               
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            if (Player.Hand[1] != null & Duel.CanMove)
            {

                SelectedCard = Player.Hand[1];
                GetSelectedCard();
               
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            if (Player.Hand[0] != null & Duel.CanMove)
            {

                SelectedCard = Player.Hand[0];
                GetSelectedCard();
                
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void drawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Duel != null)
               if (Duel.Phase == DuelPhase.Draw)
                   Duel.DrawCard(Player, Player.MainDeck.Cards);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Player != null && Duel.CanMove)
                if (Player.MainDeck.Cards.Count > 0)
                contextMenuStrip2.Show(Cursor.Position);

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }



    }
}
