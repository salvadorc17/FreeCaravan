using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using IrrKlang;

namespace FreeCaravan
{
    public partial class DeckEdit : Form
    {
        private Main Main;
        private ISoundEngine soundEngine;
        private List<Card> CardList;
        private Card[] Cards;
        private List<string> Cardtexts;
        private bool[] Cardselected;
        private ImageList imageList1;
        private ToolTip toolTip1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label11;
        private Label label8;
        private PictureBox pictureBox10;
        private Label label7;
        private PictureBox pictureBox9;
        private Label label6;
        private PictureBox pictureBox8;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox7;
        private Label label9;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private ListView listView1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox21;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private PictureBox pictureBox46;
        private PictureBox pictureBox45;
        private PictureBox pictureBox44;
        private PictureBox pictureBox43;
        private PictureBox pictureBox42;
        private PictureBox pictureBox41;
        private PictureBox pictureBox40;
        private PictureBox pictureBox22;
        private PictureBox pictureBox23;
        private PictureBox pictureBox24;
        private PictureBox pictureBox25;
        private PictureBox pictureBox26;
        private PictureBox pictureBox27;
        private PictureBox pictureBox28;
        private PictureBox pictureBox29;
        private PictureBox pictureBox30;
        private PictureBox pictureBox31;
        private PictureBox pictureBox32;
        private PictureBox pictureBox33;
        private PictureBox pictureBox34;
        private PictureBox pictureBox35;
        private PictureBox pictureBox36;
        private PictureBox pictureBox37;
        private PictureBox pictureBox38;
        private PictureBox pictureBox39;
        private Button button5;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeckEdit));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(54, 70);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(506, 5);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(21, 18);
            this.pictureBox10.TabIndex = 11;
            this.pictureBox10.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox10, "Hearths");
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(432, 5);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(21, 18);
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox9, "Diamonds");
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(349, 5);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(21, 18);
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox8, "Spades");
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(272, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(21, 18);
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox7, "Clubs");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 545);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.39751F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.60248F));
            this.tableLayoutPanel1.Controls.Add(this.listView1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 481);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(582, 6);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(172, 469);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox46, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox45, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox44, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox43, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox42, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox41, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox40, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox6, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox11, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox12, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox13, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox14, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox15, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox16, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox18, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox17, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox19, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox20, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox21, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox22, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox23, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox24, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox25, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox26, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox27, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox28, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox29, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox30, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox31, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox32, 6, 3);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox33, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox34, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox35, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox36, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox37, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox38, 5, 4);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox39, 6, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(547, 462);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // pictureBox46
            // 
            this.pictureBox46.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox46.Location = new System.Drawing.Point(471, 386);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(54, 68);
            this.pictureBox46.TabIndex = 42;
            this.pictureBox46.TabStop = false;
            // 
            // pictureBox45
            // 
            this.pictureBox45.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox45.Location = new System.Drawing.Point(315, 386);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Size = new System.Drawing.Size(54, 68);
            this.pictureBox45.TabIndex = 41;
            this.pictureBox45.TabStop = false;
            // 
            // pictureBox44
            // 
            this.pictureBox44.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox44.Location = new System.Drawing.Point(237, 386);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Size = new System.Drawing.Size(54, 68);
            this.pictureBox44.TabIndex = 40;
            this.pictureBox44.TabStop = false;
            // 
            // pictureBox43
            // 
            this.pictureBox43.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox43.Location = new System.Drawing.Point(159, 386);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(54, 68);
            this.pictureBox43.TabIndex = 39;
            this.pictureBox43.TabStop = false;
            // 
            // pictureBox42
            // 
            this.pictureBox42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox42.Location = new System.Drawing.Point(81, 386);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(54, 68);
            this.pictureBox42.TabIndex = 38;
            this.pictureBox42.TabStop = false;
            // 
            // pictureBox41
            // 
            this.pictureBox41.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox41.Location = new System.Drawing.Point(3, 386);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(54, 68);
            this.pictureBox41.TabIndex = 37;
            this.pictureBox41.TabStop = false;
            // 
            // pictureBox40
            // 
            this.pictureBox40.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox40.Location = new System.Drawing.Point(393, 386);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(54, 68);
            this.pictureBox40.TabIndex = 36;
            this.pictureBox40.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Location = new System.Drawing.Point(393, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(54, 70);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Location = new System.Drawing.Point(315, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(54, 70);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Location = new System.Drawing.Point(237, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 70);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(159, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 70);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(81, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 70);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 70);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox11.Location = new System.Drawing.Point(471, 3);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(54, 70);
            this.pictureBox11.TabIndex = 6;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox12.Location = new System.Drawing.Point(3, 79);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(54, 70);
            this.pictureBox12.TabIndex = 7;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox13.Location = new System.Drawing.Point(81, 79);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(54, 70);
            this.pictureBox13.TabIndex = 8;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox14.Location = new System.Drawing.Point(159, 79);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(54, 70);
            this.pictureBox14.TabIndex = 9;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox15.Location = new System.Drawing.Point(237, 79);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(54, 70);
            this.pictureBox15.TabIndex = 10;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox16.Location = new System.Drawing.Point(315, 79);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(54, 70);
            this.pictureBox16.TabIndex = 11;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox18.Location = new System.Drawing.Point(471, 79);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(54, 70);
            this.pictureBox18.TabIndex = 14;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox17.Location = new System.Drawing.Point(393, 79);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(54, 70);
            this.pictureBox17.TabIndex = 12;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox19.Location = new System.Drawing.Point(3, 157);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(54, 68);
            this.pictureBox19.TabIndex = 15;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox20.Location = new System.Drawing.Point(81, 157);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(54, 68);
            this.pictureBox20.TabIndex = 16;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox21.Location = new System.Drawing.Point(159, 157);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(54, 68);
            this.pictureBox21.TabIndex = 17;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox22.Location = new System.Drawing.Point(237, 157);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(54, 68);
            this.pictureBox22.TabIndex = 18;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox23.Location = new System.Drawing.Point(315, 157);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(54, 68);
            this.pictureBox23.TabIndex = 19;
            this.pictureBox23.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox24.Location = new System.Drawing.Point(393, 157);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(54, 68);
            this.pictureBox24.TabIndex = 20;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox25.Location = new System.Drawing.Point(471, 157);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(54, 68);
            this.pictureBox25.TabIndex = 21;
            this.pictureBox25.TabStop = false;
            // 
            // pictureBox26
            // 
            this.pictureBox26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox26.Location = new System.Drawing.Point(3, 231);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(54, 68);
            this.pictureBox26.TabIndex = 22;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox27.Location = new System.Drawing.Point(81, 231);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(54, 68);
            this.pictureBox27.TabIndex = 23;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox28.Location = new System.Drawing.Point(159, 231);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(54, 68);
            this.pictureBox28.TabIndex = 24;
            this.pictureBox28.TabStop = false;
            // 
            // pictureBox29
            // 
            this.pictureBox29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox29.Location = new System.Drawing.Point(237, 231);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(54, 68);
            this.pictureBox29.TabIndex = 25;
            this.pictureBox29.TabStop = false;
            // 
            // pictureBox30
            // 
            this.pictureBox30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox30.Location = new System.Drawing.Point(315, 231);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(54, 68);
            this.pictureBox30.TabIndex = 26;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox31
            // 
            this.pictureBox31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox31.Location = new System.Drawing.Point(393, 231);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(54, 68);
            this.pictureBox31.TabIndex = 27;
            this.pictureBox31.TabStop = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox32.Location = new System.Drawing.Point(471, 231);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(54, 68);
            this.pictureBox32.TabIndex = 28;
            this.pictureBox32.TabStop = false;
            // 
            // pictureBox33
            // 
            this.pictureBox33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox33.Location = new System.Drawing.Point(3, 308);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(54, 68);
            this.pictureBox33.TabIndex = 29;
            this.pictureBox33.TabStop = false;
            // 
            // pictureBox34
            // 
            this.pictureBox34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox34.Location = new System.Drawing.Point(81, 308);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(54, 68);
            this.pictureBox34.TabIndex = 30;
            this.pictureBox34.TabStop = false;
            // 
            // pictureBox35
            // 
            this.pictureBox35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox35.Location = new System.Drawing.Point(159, 308);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(54, 68);
            this.pictureBox35.TabIndex = 31;
            this.pictureBox35.TabStop = false;
            // 
            // pictureBox36
            // 
            this.pictureBox36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox36.Location = new System.Drawing.Point(237, 308);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(54, 68);
            this.pictureBox36.TabIndex = 32;
            this.pictureBox36.TabStop = false;
            // 
            // pictureBox37
            // 
            this.pictureBox37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox37.Location = new System.Drawing.Point(315, 308);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(54, 68);
            this.pictureBox37.TabIndex = 33;
            this.pictureBox37.TabStop = false;
            // 
            // pictureBox38
            // 
            this.pictureBox38.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox38.Location = new System.Drawing.Point(393, 308);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(54, 68);
            this.pictureBox38.TabIndex = 34;
            this.pictureBox38.TabStop = false;
            // 
            // pictureBox39
            // 
            this.pictureBox39.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox39.Location = new System.Drawing.Point(471, 308);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(54, 68);
            this.pictureBox39.TabIndex = 35;
            this.pictureBox39.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel4.ColumnCount = 13;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel4.Controls.Add(this.button5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label11, 12, 0);
            this.tableLayoutPanel4.Controls.Add(this.label8, 9, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox10, 8, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 7, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox9, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.label6, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox8, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox7, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label9, 11, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(9, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(760, 28);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(5, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 18);
            this.button5.TabIndex = 16;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Segoe UI Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(647, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 24);
            this.label11.TabIndex = 15;
            this.label11.Text = "00";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(540, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "00";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(467, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "00";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "00";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "00";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cards:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(581, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "Total:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.77528F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.22472F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel3.Controls.Add(this.button4, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.button3, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBox1, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 4, 0);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Segoe UI Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 29);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(760, 27);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(691, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 17);
            this.button4.TabIndex = 7;
            this.button4.Text = "Sort";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(605, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 17);
            this.button3.TabIndex = 6;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(512, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 17);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(205, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Decks:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deck Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(275, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 19);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(420, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 17);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeckEdit
            // 
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 549);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeckEdit";
            this.Load += new System.EventHandler(this.DeckEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public DeckEdit(Main main, ISoundEngine soundengine)
            {

                InitializeComponent();
                Main = main;
                soundEngine = soundengine;
                CardList = new List<Card>();
                Cards = new Card[42];
                Cardselected = new bool[42];
                Cardtexts = new List<string>();

            }

        private void DeckEdit_Load(object sender, EventArgs e)
        { 


            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "textures/bg.jpg"))
                this.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "textures/bg.jpg");



            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "decks"))
                {
                    comboBox1.Items.Clear();

                    DirectoryInfo dir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "decks");
                    foreach (FileInfo file in dir.GetFiles())
                        if (file.Extension == ".deck")
                            comboBox1.Items.Add(file.Name.Split('.')[0]);

                }

            CleanSelectedCards();
            ReloadCardList();
            ClearPictureCards();

        }

        public void ClearPictureCards()
        {

            pictureBox1.BackgroundImage = null;
            toolTip1.SetToolTip(pictureBox1, "");

            pictureBox2.BackgroundImage = null;
            toolTip1.SetToolTip(pictureBox2, "");

            pictureBox3.BackgroundImage = null;
            toolTip1.SetToolTip(pictureBox3, "");

            pictureBox4.BackgroundImage = null;
            toolTip1.SetToolTip(pictureBox4, "");

            pictureBox5.BackgroundImage = null;
            toolTip1.SetToolTip(pictureBox5, "");

            pictureBox6.BackgroundImage = null;
            toolTip1.SetToolTip(pictureBox6, "");

            pictureBox11.BackgroundImage = null;
            toolTip1.SetToolTip(pictureBox11, "");

            pictureBox12.BackgroundImage = null;
            toolTip1.SetToolTip(pictureBox12, "");

            pictureBox13.BackgroundImage = null;
            toolTip1.SetToolTip(pictureBox13, "");

        }


        public void CleanSelectedCards()
        {
           

            if (Cards != null)
               for (int i = 0; i <= Cards.Count() - 1; i++)
                   if (Cards[i] != null)
                    {
                          Cardselected[i] = false;
                          Cards[i] = null;
                    }


            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "cards.cdb"))
                CardList = Commands.LoadCardDatabase(AppDomain.CurrentDomain.BaseDirectory + "cards.cdb");

                  if (CardList != null)
                   for (int i = 0; i <= CardList.Count - 1; i++)
                    CardList[i].Texture = Image.FromFile("pics/" + CardList[i].ID + ".png");

        }

        public void ReloadCardList()
            {
                int counter = 0;

            if (CardList != null)
                 {
                
            for (int i = 0; i <= CardList.Count - 1; i++)
                   {

                    imageList1.Images.Add(CardList[i].Texture);
                    ListViewItem item = new ListViewItem(CardList[i].Name);
                    if (counter == 0)
                    {


                        item.ImageIndex = counter;
                        counter += 1;
                    }

                    else
                    {

                        item.ImageIndex = counter;
                        counter += 1;

                    }

                    listView1.Items.Add(item);

                   }

                     label11.Text = counter.ToString();

                
                  }

         }


            private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (Cardselected[0] == true)
            {
                imageList1.Images.Add(Cards[0].Texture);
                CardList.Add(Cards[0]);
                ListViewItem item = new ListViewItem(Cards[0].Name);
                item.ImageIndex = imageList1.Images.Count - 1;
                listView1.Items.Add(item);
                Cards[0] = null;
                pictureBox1.BackgroundImage = null;
                toolTip1.SetToolTip(pictureBox1, "");
                Cardselected[0] = false;

            }
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Cardselected[1] == true)
                 {
                     imageList1.Images.Add(Cards[1].Texture);
                     CardList.Add(Cards[1]);
                     ListViewItem item = new ListViewItem(Cards[1].Name);
                     item.ImageIndex = imageList1.Images.Count - 1;
                     listView1.Items.Add(item);
                     Cards[1] = null;
                     pictureBox2.BackgroundImage = null;
                     toolTip1.SetToolTip(pictureBox2, "");
                     Cardselected[1] = false;

                }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Cardselected[2] == true)
            {
               
                imageList1.Images.Add(Cards[2].Texture);
                CardList.Add(Cards[2]);
                ListViewItem item = new ListViewItem(Cards[2].Name);
                item.ImageIndex = imageList1.Images.Count - 1;
                listView1.Items.Add(item);
                Cards[2] = null;   
                pictureBox3.BackgroundImage = null;
                toolTip1.SetToolTip(pictureBox3, "");
                Cardselected[2] = false;

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Cardselected[3] == true)
            {
                
                imageList1.Images.Add(Cards[3].Texture);
                CardList.Add(Cards[3]);
                ListViewItem item = new ListViewItem(Cards[3].Name);
                item.ImageIndex = imageList1.Images.Count - 1;
                listView1.Items.Add(item);
                Cards[3] = null;
                pictureBox4.BackgroundImage = null;
                toolTip1.SetToolTip(pictureBox4, "");
                Cardselected[3] = false;

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string current;
          

            foreach (ListViewItem item in listView1.SelectedItems)
                if (item != null)
                {

                    current = item.SubItems[0].Text;
                    label3.Text = item.Index.ToString();

                    MessageBox.Show(CardList[item.Index].Name);
                    //for (int i = 0; i <= Cards.Count - 1; i++)
                        //if (Cards[i].ID != CardList[item.Index].ID)
                        
                         //Cards.Add(CardList[item.Index]);

                    if (Cardselected[0] == false)
                        {
                            Cards[0] = CardList[item.Index];
                            pictureBox1.BackgroundImage = Cards[0].Texture;
                            toolTip1.SetToolTip(pictureBox1, Cards[0].Name);
                            Cardselected[0] = true;

                        }
                    else if (Cardselected[1] == false)
                        {
                            Cards[1] = CardList[item.Index];
                            pictureBox2.BackgroundImage = Cards[1].Texture;
                            toolTip1.SetToolTip(pictureBox2, Cards[1].Name);
                            Cardselected[1] = true;
                        }
                    else if (Cardselected[2] == false)
                    {
                        Cards[2] = CardList[item.Index];
                        pictureBox3.BackgroundImage = Cards[2].Texture;
                        toolTip1.SetToolTip(pictureBox3, Cards[2].Name);
                        Cardselected[2] = true;
                    }
                    else if (Cardselected[3] == false)
                    {
                        Cards[3] = CardList[item.Index];
                        pictureBox4.BackgroundImage = Cards[3].Texture;
                        toolTip1.SetToolTip(pictureBox4, Cards[3].Name);
                        Cardselected[3] = true;
                    }
                    else if (Cardselected[4] == false)
                    {
                        Cards[4] = CardList[item.Index];
                        pictureBox5.BackgroundImage = Cards[4].Texture;
                        toolTip1.SetToolTip(pictureBox5, Cards[4].Name);
                        Cardselected[4] = true;
                    }
                    else if (Cardselected[5] == false)
                    {
                        Cards[5] = CardList[item.Index];
                        pictureBox6.BackgroundImage = Cards[5].Texture;
                        toolTip1.SetToolTip(pictureBox6, Cards[5].Name);
                        Cardselected[5] = true;
                    }
                    else if (Cardselected[6] == false)
                    {
                        Cards[6] = CardList[item.Index];
                        pictureBox11.BackgroundImage = Cards[6].Texture;
                        toolTip1.SetToolTip(pictureBox11, Cards[6].Name);
                        Cardselected[6] = true;
                    }
                    else if (Cardselected[7] == false)
                    {
                        Cards[7] = CardList[item.Index];
                        pictureBox12.BackgroundImage = Cards[7].Texture;
                        toolTip1.SetToolTip(pictureBox12, Cards[7].Name);
                        Cardselected[7] = true;
                    }
                    else if (Cardselected[8] == false)
                    {
                        Cards[8] = CardList[item.Index];
                        pictureBox13.BackgroundImage = Cards[8].Texture;
                        toolTip1.SetToolTip(pictureBox13, Cards[8].Name);
                        Cardselected[8] = true;
                    }
                    else if (Cardselected[8] == false)
                    {
                        Cards[8] = CardList[item.Index];
                        pictureBox13.BackgroundImage = Cards[8].Texture;
                        toolTip1.SetToolTip(pictureBox13, Cards[8].Name);
                        Cardselected[8] = true;
                    }
                    else if (Cardselected[8] == false)
                    {
                        Cards[8] = CardList[item.Index];
                        pictureBox13.BackgroundImage = Cards[8].Texture;
                        toolTip1.SetToolTip(pictureBox13, Cards[8].Name);
                        Cardselected[8] = true;
                    }
                    

                    
                    CardList.RemoveAt(item.Index);

                    imageList1.Images.RemoveAt(item.Index);
                    listView1.Items.Remove(item);

                  }



            

            for (int i = 0; i <= imageList1.Images.Count - 1; i++)
                listView1.Items[i].ImageIndex = i;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            imageList1.Images.Clear();
            listView1.Items.Clear();
            CardList.Clear();
            Cardtexts.Clear();
            CleanSelectedCards();
            ClearPictureCards();

            if (comboBox1.SelectedItem != null)
                {
                string current = comboBox1.SelectedItem.ToString();

                ISound sound = soundEngine.Play2D("sound/menu.wav");


                using (StreamReader reader = new StreamReader("decks/" + current + ".deck"))
                {

                    reader.ReadLine();

                    for (int i = 0; i <= 9; i++)
                         {
                          
                        string card = reader.ReadLine();
                        if (card != null)
                            Cardtexts.Add(card);
                
                          }

                }

                 
                for (int i = Cardtexts.Count - 1; i >= 0; i--)
                //for (int i = 0; i <=  Cardtexts.Count - 1; i++)
                    if (Cardtexts[i] != null)
                       {

                           int id = Convert.ToInt32(Cardtexts[i]);

                        if (Cardselected[0] == false)
                        {
                            Cards[0] = CardList[id - 1];
                            CardList.RemoveAt(id - 1);
                            pictureBox1.BackgroundImage = Cards[0].Texture;
                            toolTip1.SetToolTip(pictureBox1, Cards[0].Name);
                            Cardselected[0] = true;
                            

                        }
                        else if (Cardselected[1] == false)
                        {
                            Cards[1] = CardList[id - 1];
                            CardList.RemoveAt(id - 1);
                            pictureBox2.BackgroundImage = Cards[1].Texture;
                            toolTip1.SetToolTip(pictureBox2, Cards[1].Name);
                            Cardselected[1] = true;

                        }
                        else if (Cardselected[2] == false)
                        {
                            Cards[2] = CardList[id - 1];
                            CardList.RemoveAt(id - 1);
                            pictureBox3.BackgroundImage = Cards[2].Texture;
                            toolTip1.SetToolTip(pictureBox3, Cards[2].Name);
                            Cardselected[2] = true;

                        }
                        else if (Cardselected[3] == false)
                        {
                            Cards[3] = CardList[id - 1];
                            CardList.RemoveAt(id - 1);
                            pictureBox4.BackgroundImage = Cards[3].Texture;
                            toolTip1.SetToolTip(pictureBox4, Cards[3].Name);
                            Cardselected[3] = true;

                        }
                        else if (Cardselected[4] == false)
                        {
                            Cards[4] = CardList[id - 1];
                            CardList.RemoveAt(id - 1);
                            pictureBox5.BackgroundImage = Cards[4].Texture;
                            toolTip1.SetToolTip(pictureBox5, Cards[4].Name);
                            Cardselected[4] = true;

                        }
                        else if (Cardselected[5] == false)
                        {
                            Cards[5] = CardList[id - 1];
                            CardList.RemoveAt(id - 1);
                            pictureBox6.BackgroundImage = Cards[5].Texture;
                            toolTip1.SetToolTip(pictureBox6, Cards[5].Name);
                            Cardselected[5] = true;


                        }
                        else if (Cardselected[6] == false)
                        {
                            Cards[6] = CardList[id - 1];
                            CardList.RemoveAt(id - 1);
                            pictureBox11.BackgroundImage = Cards[6].Texture;
                            toolTip1.SetToolTip(pictureBox11, Cards[6].Name);
                            Cardselected[6] = true;

                        }
                        else if (Cardselected[7] == false)
                        {
                            Cards[7] = CardList[id - 1];
                            CardList.RemoveAt(id - 1);
                            pictureBox12.BackgroundImage = Cards[7].Texture;
                            toolTip1.SetToolTip(pictureBox12, Cards[7].Name);
                            Cardselected[7] = true;

                        }
                        else if (Cardselected[8] == false)
                        {
                            Cards[8] = CardList[id - 1];
                            CardList.RemoveAt(id - 1);
                            pictureBox13.BackgroundImage = Cards[8].Texture;
                            toolTip1.SetToolTip(pictureBox13, Cards[8].Name);
                            Cardselected[8] = true;

                        }
                        

                       }


                label11.Text = (CardList.Count).ToString();

                //Load only the Cardlist cards
                ReloadCardList();

                }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Hide();
            Main.panel1.Show();
            Main.BackgroundImage = Image.FromFile("textures/bg.jpg");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Cardselected[4] == true)
            {

                imageList1.Images.Add(Cards[4].Texture);
                CardList.Add(Cards[4]);
                ListViewItem item = new ListViewItem(Cards[4].Name);
                item.ImageIndex = imageList1.Images.Count - 1;
                listView1.Items.Add(item);
                Cards[4] = null;
                pictureBox5.BackgroundImage = null;
                toolTip1.SetToolTip(pictureBox5, "");
                Cardselected[4] = false;

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (Cardselected[5] == true)
            {

                imageList1.Images.Add(Cards[5].Texture);
                CardList.Add(Cards[5]);
                ListViewItem item = new ListViewItem(Cards[5].Name);
                item.ImageIndex = imageList1.Images.Count - 1;
                listView1.Items.Add(item);
                Cards[5] = null;
                pictureBox6.BackgroundImage = null;
                toolTip1.SetToolTip(pictureBox6, "");
                Cardselected[5] = false;

            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (Cardselected[6] == true)
            {

                imageList1.Images.Add(Cards[6].Texture);
                CardList.Add(Cards[6]);
                ListViewItem item = new ListViewItem(Cards[6].Name);
                item.ImageIndex = imageList1.Images.Count - 1;
                listView1.Items.Add(item);
                Cards[6] = null;
                pictureBox11.BackgroundImage = null;
                toolTip1.SetToolTip(pictureBox11, "");
                Cardselected[6] = false;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int counter = 0;
            List<Card> Sorted = new List<Card>();

            if (listView1.Items != null)
                {

                imageList1.Images.Clear();
                listView1.Items.Clear();

                if (CardList != null)
                {

                    Sorted = CardList.OrderBy(o => o.ID).ToList();
                    for (int i = 0; i <= Sorted.Count - 1; i++)
                    {
                        Sorted[i].Texture = Image.FromFile("pics/" + Sorted[i].ID + ".png");
                        ListViewItem item = new ListViewItem();

                        
                        if (counter == 0)
                        {
                            imageList1.Images.Add(Sorted[counter].Texture);
                            item = new ListViewItem(Sorted[counter].Name);
                            item.ImageIndex = counter;
                            counter += 1;
                        }

                        else
                        {
                            imageList1.Images.Add(Sorted[counter].Texture);
                            item = new ListViewItem(Sorted[counter].Name);
                            item.ImageIndex = counter;
                            counter += 1;

                        }

                        listView1.Items.Add(item);

                    }

                    label11.Text = counter.ToString();

                } 


                }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string current = "default";

            if (comboBox1.SelectedItem != null)
                current = comboBox1.SelectedItem.ToString();
            else
                current = comboBox1.Text;

            if (!comboBox1.Items.Contains(current))
                comboBox1.Items.Add(current);

                ISound sound = soundEngine.Play2D("sound/menu.wav");


                using (StreamWriter writer = new StreamWriter("decks/" + current + ".deck"))
                {

                    writer.WriteLine("--Fallout Caravan deck file");

                    for (int i = 0; i <= Cards.Count() - 1; i++)
                        if (Cards[i] != null)
                         {
                          
                        string card = Cards[i].ID.ToString();
                        writer.WriteLine(card);
                
                          }

                }

                
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (Cardselected[7] == true)
            {

                imageList1.Images.Add(Cards[7].Texture);
                CardList.Add(Cards[7]);
                ListViewItem item = new ListViewItem(Cards[7].Name);
                item.ImageIndex = imageList1.Images.Count - 1;
                listView1.Items.Add(item);
                Cards[7] = null;
                pictureBox12.BackgroundImage = null;
                toolTip1.SetToolTip(pictureBox12, "");
                Cardselected[7] = false;

            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (Cardselected[8] == true)
            {

                imageList1.Images.Add(Cards[8].Texture);
                CardList.Add(Cards[8]);
                ListViewItem item = new ListViewItem(Cards[8].Name);
                item.ImageIndex = imageList1.Images.Count - 1;
                listView1.Items.Add(item);
                Cards[8] = null;
                pictureBox13.BackgroundImage = null;
                toolTip1.SetToolTip(pictureBox13, "");
                Cardselected[8] = false;

            }
        }




        


    }
}
