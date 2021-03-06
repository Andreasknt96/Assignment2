﻿namespace MiniKeyboard
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NotePad = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mode_Status = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Word_Builder = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.withinTimer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listBox21 = new System.Windows.Forms.ListBox();
            this.listBox22 = new System.Windows.Forms.ListBox();
            this.listBox23 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.listBox9 = new System.Windows.Forms.ListBox();
            this.listBox10 = new System.Windows.Forms.ListBox();
            this.listBox11 = new System.Windows.Forms.ListBox();
            this.Key_Sequence = new System.Windows.Forms.TextBox();
            this.Char_Sequence = new System.Windows.Forms.TextBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox12 = new System.Windows.Forms.ListBox();
            this.listBox13 = new System.Windows.Forms.ListBox();
            this.listBox14 = new System.Windows.Forms.ListBox();
            this.listBox16 = new System.Windows.Forms.ListBox();
            this.listBox17 = new System.Windows.Forms.ListBox();
            this.listBox18 = new System.Windows.Forms.ListBox();
            this.listBox19 = new System.Windows.Forms.ListBox();
            this.listBox20 = new System.Windows.Forms.ListBox();
            this.listBox15 = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotePad
            // 
            this.NotePad.Location = new System.Drawing.Point(3, 3);
            this.NotePad.Multiline = true;
            this.NotePad.Name = "NotePad";
            this.NotePad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NotePad.Size = new System.Drawing.Size(564, 133);
            this.NotePad.TabIndex = 0;
            this.NotePad.TextChanged += new System.EventHandler(this.NotePad_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.configureToolStripMenuItem.Text = "Configure";
            this.configureToolStripMenuItem.Click += new System.EventHandler(this.configureToolStripMenuItem_Click);
            // 
            // Mode_Status
            // 
            this.Mode_Status.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Mode_Status.Location = new System.Drawing.Point(200, 3);
            this.Mode_Status.Multiline = true;
            this.Mode_Status.Name = "Mode_Status";
            this.Mode_Status.Size = new System.Drawing.Size(59, 25);
            this.Mode_Status.TabIndex = 3;
            this.Mode_Status.Text = "Multi-Press";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Word_Builder);
            this.panel1.Controls.Add(this.Mode_Status);
            this.panel1.Location = new System.Drawing.Point(183, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 33);
            this.panel1.TabIndex = 4;
            // 
            // Word_Builder
            // 
            this.Word_Builder.Location = new System.Drawing.Point(5, 3);
            this.Word_Builder.Name = "Word_Builder";
            this.Word_Builder.Size = new System.Drawing.Size(190, 25);
            this.Word_Builder.TabIndex = 4;
            this.Word_Builder.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.NotePad);
            this.panel2.Location = new System.Drawing.Point(12, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 141);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button19);
            this.panel3.Controls.Add(this.button18);
            this.panel3.Controls.Add(this.button17);
            this.panel3.Controls.Add(this.button16);
            this.panel3.Controls.Add(this.button15);
            this.panel3.Controls.Add(this.button14);
            this.panel3.Controls.Add(this.button13);
            this.panel3.Controls.Add(this.button12);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(183, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 291);
            this.panel3.TabIndex = 6;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Yellow;
            this.button19.Location = new System.Drawing.Point(200, 177);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(59, 110);
            this.button19.TabIndex = 18;
            this.button19.Text = "Enter";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Yellow;
            this.button18.Location = new System.Drawing.Point(201, 119);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(59, 52);
            this.button18.TabIndex = 17;
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Yellow;
            this.button17.Location = new System.Drawing.Point(200, 61);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(59, 52);
            this.button17.TabIndex = 16;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Yellow;
            this.button16.Location = new System.Drawing.Point(200, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(59, 52);
            this.button16.TabIndex = 15;
            this.button16.Text = "Show Pred-\r\niction";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Aquamarine;
            this.button15.Location = new System.Drawing.Point(135, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(59, 52);
            this.button15.TabIndex = 14;
            this.button15.Text = "Previous";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Aquamarine;
            this.button14.Location = new System.Drawing.Point(70, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(59, 52);
            this.button14.TabIndex = 13;
            this.button14.Text = "Next";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Aquamarine;
            this.button13.Location = new System.Drawing.Point(5, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(59, 52);
            this.button13.TabIndex = 12;
            this.button13.Text = "Mode";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Salmon;
            this.button12.Location = new System.Drawing.Point(135, 235);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(59, 52);
            this.button12.TabIndex = 11;
            this.button12.Text = "# \r\n0.00";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.SpringGreen;
            this.button11.Location = new System.Drawing.Point(70, 235);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(59, 52);
            this.button11.TabIndex = 10;
            this.button11.Text = "000\r\n[ _ }";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Salmon;
            this.button10.Location = new System.Drawing.Point(5, 235);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(59, 52);
            this.button10.TabIndex = 9;
            this.button10.Text = "* - _";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Salmon;
            this.button9.Location = new System.Drawing.Point(135, 61);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(59, 52);
            this.button9.TabIndex = 8;
            this.button9.Text = "9 \r\nD E F";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Salmon;
            this.button8.Location = new System.Drawing.Point(70, 61);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(59, 52);
            this.button8.TabIndex = 7;
            this.button8.Text = "8 \r\nA B C ";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Salmon;
            this.button7.Location = new System.Drawing.Point(5, 61);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 52);
            this.button7.TabIndex = 6;
            this.button7.Text = "7\r\n . , \"";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Salmon;
            this.button6.Location = new System.Drawing.Point(135, 119);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(59, 52);
            this.button6.TabIndex = 5;
            this.button6.Text = "6 \r\nM N O ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Salmon;
            this.button5.Location = new System.Drawing.Point(70, 119);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 52);
            this.button5.TabIndex = 4;
            this.button5.Text = "5 \r\nJ K L ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Salmon;
            this.button4.Location = new System.Drawing.Point(5, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 52);
            this.button4.TabIndex = 3;
            this.button4.Text = "4 \r\nG H I ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Salmon;
            this.button3.Location = new System.Drawing.Point(135, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "3 \r\nW X Y Z";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.Location = new System.Drawing.Point(70, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "2\r\n T U V";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Location = new System.Drawing.Point(5, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "1 \r\nP Q R S";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "p",
            "q",
            "r",
            "s",
            "1",
            "P",
            "Q",
            "R",
            "S"});
            this.listBox1.Location = new System.Drawing.Point(454, 414);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(53, 43);
            this.listBox1.TabIndex = 7;
            // 
            // withinTimer
            // 
            this.withinTimer.Tick += new System.EventHandler(this.withinTimer_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.InitialDirectory = "c:\\\\";
            // 
            // listBox21
            // 
            this.listBox21.FormattingEnabled = true;
            this.listBox21.Location = new System.Drawing.Point(20, 481);
            this.listBox21.Name = "listBox21";
            this.listBox21.Size = new System.Drawing.Size(65, 30);
            this.listBox21.TabIndex = 28;
            // 
            // listBox22
            // 
            this.listBox22.FormattingEnabled = true;
            this.listBox22.Location = new System.Drawing.Point(91, 481);
            this.listBox22.Name = "listBox22";
            this.listBox22.Size = new System.Drawing.Size(65, 30);
            this.listBox22.TabIndex = 29;
            // 
            // listBox23
            // 
            this.listBox23.FormattingEnabled = true;
            this.listBox23.Location = new System.Drawing.Point(4, 188);
            this.listBox23.Name = "listBox23";
            this.listBox23.Size = new System.Drawing.Size(166, 95);
            this.listBox23.Sorted = true;
            this.listBox23.TabIndex = 35;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "t",
            "u",
            "v",
            "2",
            "T",
            "U",
            "V"});
            this.listBox2.Location = new System.Drawing.Point(513, 414);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(35, 43);
            this.listBox2.TabIndex = 8;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Items.AddRange(new object[] {
            "w",
            "x",
            "y",
            "z",
            "3",
            "W",
            "X",
            "Y",
            "Z"});
            this.listBox3.Location = new System.Drawing.Point(554, 414);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(35, 43);
            this.listBox3.TabIndex = 9;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Items.AddRange(new object[] {
            "j",
            "k",
            "l",
            "5",
            "J",
            "K",
            "L"});
            this.listBox5.Location = new System.Drawing.Point(515, 357);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(33, 43);
            this.listBox5.TabIndex = 11;
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Items.AddRange(new object[] {
            "m",
            "n",
            "o",
            "6",
            "M",
            "N",
            "O"});
            this.listBox6.Location = new System.Drawing.Point(558, 358);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(30, 43);
            this.listBox6.TabIndex = 12;
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.Items.AddRange(new object[] {
            ".",
            "~",
            "\"",
            "7",
            "\'",
            ":",
            ";"});
            this.listBox7.Location = new System.Drawing.Point(462, 294);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(43, 56);
            this.listBox7.TabIndex = 13;
            // 
            // listBox8
            // 
            this.listBox8.FormattingEnabled = true;
            this.listBox8.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "8",
            "A",
            "B",
            "C"});
            this.listBox8.Location = new System.Drawing.Point(513, 292);
            this.listBox8.Name = "listBox8";
            this.listBox8.Size = new System.Drawing.Size(34, 56);
            this.listBox8.TabIndex = 14;
            // 
            // listBox9
            // 
            this.listBox9.FormattingEnabled = true;
            this.listBox9.Items.AddRange(new object[] {
            "d",
            "e",
            "f",
            "9",
            "D",
            "E",
            "F"});
            this.listBox9.Location = new System.Drawing.Point(557, 292);
            this.listBox9.Name = "listBox9";
            this.listBox9.Size = new System.Drawing.Size(31, 56);
            this.listBox9.TabIndex = 15;
            // 
            // listBox10
            // 
            this.listBox10.FormattingEnabled = true;
            this.listBox10.Items.AddRange(new object[] {
            "*",
            "-",
            "_"});
            this.listBox10.Location = new System.Drawing.Point(459, 469);
            this.listBox10.Name = "listBox10";
            this.listBox10.Size = new System.Drawing.Size(45, 43);
            this.listBox10.TabIndex = 16;
            // 
            // listBox11
            // 
            this.listBox11.FormattingEnabled = true;
            this.listBox11.Items.AddRange(new object[] {
            "#",
            "-",
            "_"});
            this.listBox11.Location = new System.Drawing.Point(554, 469);
            this.listBox11.Name = "listBox11";
            this.listBox11.Size = new System.Drawing.Size(39, 43);
            this.listBox11.TabIndex = 17;
            // 
            // Key_Sequence
            // 
            this.Key_Sequence.Location = new System.Drawing.Point(465, 263);
            this.Key_Sequence.Name = "Key_Sequence";
            this.Key_Sequence.Size = new System.Drawing.Size(119, 20);
            this.Key_Sequence.TabIndex = 18;
            // 
            // Char_Sequence
            // 
            this.Char_Sequence.Location = new System.Drawing.Point(465, 227);
            this.Char_Sequence.Name = "Char_Sequence";
            this.Char_Sequence.Size = new System.Drawing.Size(119, 20);
            this.Char_Sequence.TabIndex = 32;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Items.AddRange(new object[] {
            "g",
            "h",
            "i",
            "4",
            "G",
            "H",
            "I"});
            this.listBox4.Location = new System.Drawing.Point(458, 360);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(49, 43);
            this.listBox4.TabIndex = 33;
            // 
            // listBox12
            // 
            this.listBox12.FormattingEnabled = true;
            this.listBox12.Location = new System.Drawing.Point(20, 445);
            this.listBox12.Name = "listBox12";
            this.listBox12.Size = new System.Drawing.Size(65, 30);
            this.listBox12.TabIndex = 19;
            // 
            // listBox13
            // 
            this.listBox13.FormattingEnabled = true;
            this.listBox13.Location = new System.Drawing.Point(91, 445);
            this.listBox13.Name = "listBox13";
            this.listBox13.Size = new System.Drawing.Size(65, 30);
            this.listBox13.TabIndex = 20;
            // 
            // listBox14
            // 
            this.listBox14.FormattingEnabled = true;
            this.listBox14.Location = new System.Drawing.Point(20, 409);
            this.listBox14.Name = "listBox14";
            this.listBox14.Size = new System.Drawing.Size(65, 30);
            this.listBox14.TabIndex = 21;
            // 
            // listBox16
            // 
            this.listBox16.FormattingEnabled = true;
            this.listBox16.Location = new System.Drawing.Point(20, 373);
            this.listBox16.Name = "listBox16";
            this.listBox16.Size = new System.Drawing.Size(65, 30);
            this.listBox16.TabIndex = 23;
            // 
            // listBox17
            // 
            this.listBox17.FormattingEnabled = true;
            this.listBox17.Location = new System.Drawing.Point(91, 373);
            this.listBox17.Name = "listBox17";
            this.listBox17.Size = new System.Drawing.Size(65, 30);
            this.listBox17.TabIndex = 24;
            // 
            // listBox18
            // 
            this.listBox18.FormattingEnabled = true;
            this.listBox18.Location = new System.Drawing.Point(20, 337);
            this.listBox18.Name = "listBox18";
            this.listBox18.Size = new System.Drawing.Size(65, 30);
            this.listBox18.TabIndex = 25;
            // 
            // listBox19
            // 
            this.listBox19.FormattingEnabled = true;
            this.listBox19.Location = new System.Drawing.Point(91, 337);
            this.listBox19.Name = "listBox19";
            this.listBox19.Size = new System.Drawing.Size(65, 30);
            this.listBox19.TabIndex = 26;
            // 
            // listBox20
            // 
            this.listBox20.FormattingEnabled = true;
            this.listBox20.Location = new System.Drawing.Point(53, 301);
            this.listBox20.Name = "listBox20";
            this.listBox20.Size = new System.Drawing.Size(65, 30);
            this.listBox20.TabIndex = 27;
            // 
            // listBox15
            // 
            this.listBox15.FormattingEnabled = true;
            this.listBox15.Location = new System.Drawing.Point(91, 409);
            this.listBox15.Name = "listBox15";
            this.listBox15.Size = new System.Drawing.Size(65, 30);
            this.listBox15.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(454, 205);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(142, 357);
            this.panel4.TabIndex = 36;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 174);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(170, 388);
            this.panel5.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(596, 583);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.listBox23);
            this.Controls.Add(this.listBox15);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.Char_Sequence);
            this.Controls.Add(this.listBox22);
            this.Controls.Add(this.listBox21);
            this.Controls.Add(this.listBox20);
            this.Controls.Add(this.listBox19);
            this.Controls.Add(this.listBox18);
            this.Controls.Add(this.listBox17);
            this.Controls.Add(this.listBox16);
            this.Controls.Add(this.listBox14);
            this.Controls.Add(this.listBox13);
            this.Controls.Add(this.listBox12);
            this.Controls.Add(this.Key_Sequence);
            this.Controls.Add(this.listBox11);
            this.Controls.Add(this.listBox10);
            this.Controls.Add(this.listBox9);
            this.Controls.Add(this.listBox8);
            this.Controls.Add(this.listBox7);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mini Keyboard v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NotePad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.TextBox Mode_Status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer withinTimer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox listBox21;
        private System.Windows.Forms.ListBox listBox22;
        private System.Windows.Forms.ListBox listBox23;
        private System.Windows.Forms.RichTextBox Word_Builder;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.ListBox listBox8;
        private System.Windows.Forms.ListBox listBox9;
        private System.Windows.Forms.ListBox listBox10;
        private System.Windows.Forms.ListBox listBox11;
        private System.Windows.Forms.TextBox Key_Sequence;
        private System.Windows.Forms.TextBox Char_Sequence;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox12;
        private System.Windows.Forms.ListBox listBox13;
        private System.Windows.Forms.ListBox listBox14;
        private System.Windows.Forms.ListBox listBox16;
        private System.Windows.Forms.ListBox listBox17;
        private System.Windows.Forms.ListBox listBox18;
        private System.Windows.Forms.ListBox listBox19;
        private System.Windows.Forms.ListBox listBox20;
        private System.Windows.Forms.ListBox listBox15;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;

    }
}

