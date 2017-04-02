﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MyDialogs; //We add our file which contains our class

namespace MiniKeyboard
{
    public partial class Form1 : Form
    {
        //Timing Fuctionality.
        bool boolFirstVisit = true;
        int intIntervalRequired = 500;
        //Buttons. Identifies which button is being selected be the user. 
        bool[] boolsButtonPressed = new bool[19];
        int intWhichButton = 0;
        //Index of the listbox items.
        int index = 0;
        //Key Sequence.
        string str_KeyStrokes;
        //The path to the hard disc.
        string strPresentFilePathName = "";
        //The position of the character in the WordBuilder textbox.
        int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void NotePad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Starting with the Mode Status Multi-Press.
            Mode_Status.Text = "Multi-Press";
            //Setup the time Between Presses for Next Character when same button.
            withinTimer.Interval = intIntervalRequired;
            for (int intWhichButton = 0; intWhichButton <= 18; intWhichButton++)
                boolsButtonPressed[intWhichButton] = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Changing the mode status between Multi-Press and Prediction.
            if (Mode_Status.Text == "Multi-Press")
                Mode_Status.Text = "Prediction";
            else
                Mode_Status.Text = "Multi-Press";
        }

        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Setting up the required time by asking the user.
            int n;
            n = intIntervalRequired;
            intIntervalRequired = Convert.ToInt32(My_Dialogs.InputBox("Please enter the 'Delay Value' you require. 1000 is equal to 1 second dealy. At present the 'Delay Value' is " + n + "."));
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //By pressing the enter key the cursor on the NotePad moves to a new line.
            NotePad.Text = NotePad.Text + Environment.NewLine;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //By pressing the '000' button we append the text content of the WordBuilder TextBox into the NotePad and we clear the variable Str_KeyStrokes.
            NotePad.AppendText(Word_Builder.Text.ToString() + " ");
            Key_Sequence.Clear();
            Word_Builder.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //On the first selection of the key we append the key number to the variable str_KeyStrokes.
            while (boolFirstVisit == true)
            {
                Key_Sequence.AppendText("7".ToString());
                str_KeyStrokes = Key_Sequence.Text.ToString();
                boolFirstVisit = false;
            }
            //We select an item from the listBox7 and appended to Word_Builder textbox for the first character.
            if (x == 0)
            {
                if (index <= 6)
                {
                    listBox7.SetSelected(index, true);
                    Word_Builder.Text = listBox7.SelectedItem.ToString();
                    //We increase the index every time we press the button.
                    index++;
                }
                else
                {
                    //We increase the position of the Word_Builder textbox to the second character.
                    x++;
                    //We initialise the index to start from the beginning.
                    index = 0;
                }
            }
            else
            {
                if (x != 0)
                {
                    //We select the first item from the listbox7 and append it to the second position of the WordBuilder textbox.
                    if (index == 0)
                    {
                        listBox7.SetSelected(index, true);
                        Word_Builder.AppendText(listBox7.SelectedItem.ToString());
                        //We increment the index.
                        index++;
                    }
                    else
                    {
                        if (index <= 6)
                        {
                            //Selecting the other items fromt he listbox7 by increasing the index and append them to the WordBuilder textbox.
                            listBox7.SetSelected(index, true);
                            Word_Builder.AppendText(listBox7.SelectedItem.ToString());
                            //By removing two characters from the starting position x and inserting from the same starting address the selected item.
                            Word_Builder.Text = Word_Builder.Text.Remove(x, 2).Insert(x, listBox7.SelectedItem.ToString());
                            index++;
                        }
                        else
                        {
                            //We increase the position of the character to the next position in the WordBuilder textbox.
                            x++;
                            //We reset the index.
                            index = 0;
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //On the first selection of the key we append the key number to the variable str_KeyStrokes.
            while (boolFirstVisit == true)
            {
                Key_Sequence.AppendText("4".ToString());
                str_KeyStrokes = Key_Sequence.Text.ToString();
                boolFirstVisit = false;
            }
            //We select an item from the listBox4 and appended to Word_Builder textbox for the first character.
            if (x == 0)
            {
                if (index <= 6)
                {
                    listBox4.SetSelected(index, true);
                    Word_Builder.Text = listBox4.SelectedItem.ToString();
                    //We increase the index every time we press the button.
                    index++;
                }
                else
                {
                    //We initialise the index to start from the beginning.
                    index = 0;
                }
            }
            else
            {
                if (x != 0)
                {
                    //We select the first item from the listbox4 and append it to the second position of the WordBuilder textbox.
                    if (index == 0)
                    {
                        listBox4.SetSelected(index, true);
                        Word_Builder.AppendText(listBox4.SelectedItem.ToString());
                        //We append the same character in the WordBuilder textbox so as to leave the first item in the sequence.
                        Word_Builder.AppendText(listBox4.SelectedItem.ToString());
                        //By removing two characters from the starting position x and inserting from the same starting address the selected item.
                        Word_Builder.Text = Word_Builder.Text.Remove(x, 2).Insert(x, listBox4.SelectedItem.ToString());
                        //We increment the index.
                        index++;
                    }
                    else
                    {
                        if (index <= 6)
                        {
                            //Selecting the other items fromt he listbox4 by increasing the index and append them to the WordBuilder textbox.
                            listBox4.SetSelected(index, true);
                            Word_Builder.AppendText(listBox4.SelectedItem.ToString());
                            //By removing two characters from the starting position x and inserting from the same starting address the selected item.
                            Word_Builder.Text = Word_Builder.Text.Remove(x, 2).Insert(x, listBox4.SelectedItem.ToString());
                            //We increment the index.
                            index++;
                        }
                        else
                        {
                            //We reset the index.
                            index = 0;
                            //We remove the last character from the textbox.
                            Word_Builder.Text = Word_Builder.Text.Remove(x, 1);
                        }
                    }
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opens a new file.
            NotePad.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Initial directory of the file on the hard disc.
            openFileDialog1.InitialDirectory = "C:\\";
            //Opening an openFileDialog.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Opens the file.
                StreamReader inputStream = File.OpenText(openFileDialog1.FileName);
                //We input the contents of the file into the NotePad textbox.
                NotePad.AppendText(inputStream.ReadToEnd());
                //We are asking for a file name for the file.
                strPresentFilePathName = openFileDialog1.FileName;
                //Close the file.
                inputStream.Close();
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (strPresentFilePathName == "")
            {
                // This redirect it to the Save As function
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                //We creat a file and we save the contents of the NotePad.
                StreamWriter outputStream = File.CreateText(strPresentFilePathName);
                outputStream.Write(NotePad.Text);
                //Close the file.
                outputStream.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Initial directory to save a file.
            saveFileDialog1.InitialDirectory = "C:\\";
            //We create a file and we save the contents of the NotePad.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter outputStream = File.CreateText(saveFileDialog1.FileName);
                outputStream.Write(NotePad.Text);
                //Close the file.
                outputStream.Close();
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes Application.
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //On the first selection of the key we append the key number to the variable str_KeyStrokes.
            while (boolFirstVisit == true)
            {
                Key_Sequence.AppendText("1".ToString());
                str_KeyStrokes = Key_Sequence.Text.ToString();
                boolFirstVisit = false;
            }
            //We select an item from the listBox1 and appended to Word_Builder textbox for the first character.
            if (x == 0)
            {
                if (index <= 8)
                {
                    listBox1.SetSelected(index, true);
                    Word_Builder.Text = listBox1.SelectedItem.ToString();
                    //We increase the index every time we press the button.
                    index++;
                }
                else
                {
                    //We initialise the index to start from the beginning.
                    index = 0;
                }
            }
            else
            {
                if (x != 0)
                {
                    //We select the first item from the listbox1 and append it to the second position of the WordBuilder textbox.
                    if (index == 0)
                    {
                        listBox1.SetSelected(index, true);
                        Word_Builder.AppendText(listBox1.SelectedItem.ToString());
                        //We append the same character in the WordBuilder textbox so as to leave the first item in the sequence.
                        Word_Builder.AppendText(listBox1.SelectedItem.ToString());
                        //By removing two characters from the starting position x and inserting from the same starting address the selected item.
                        Word_Builder.Text = Word_Builder.Text.Remove(x, 2).Insert(x, listBox1.SelectedItem.ToString());
                        //We increment the index.
                        index++;
                    }
                    else
                    {
                        if (index <= 8)
                        {
                            //Selecting the other items fromt he listbox1 by increasing the index and append them to the WordBuilder textbox.
                            listBox1.SetSelected(index, true);
                            Word_Builder.AppendText(listBox1.SelectedItem.ToString());
                            //By removing two characters from the starting position x and inserting from the same starting address the selected item.
                            Word_Builder.Text = Word_Builder.Text.Remove(x, 2).Insert(x, listBox1.SelectedItem.ToString());
                            //We increment the index.
                            index++;
                        }
                        else
                        {
                            //We reset the index.
                            index = 0;
                            //We remove the last character from the textbox.
                            Word_Builder.Text = Word_Builder.Text.Remove(x, 1);
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //On the first selection of the key we append the key number to the variable str_KeyStrokes.
            while (boolFirstVisit == true)
            {
                Key_Sequence.AppendText("3".ToString());
                str_KeyStrokes = Key_Sequence.Text.ToString();
                boolFirstVisit = false;
            }
            //We select an item from the listBox3 and appended to Word_Builder textbox for the first character.
            if (x == 0)
            {
                if (index <= 8)
                {
                    listBox3.SetSelected(index, true);
                    Word_Builder.Text = listBox3.SelectedItem.ToString();
                    //We increase the index every time we press the button.
                    index++;
                }
                else
                {
                    //We initialise the index to start from the beginning.
                    index = 0;
                }
            }
            else
            {
                if (x != 0)
                {
                    //We select the first item from the listbox3 and append it to the second position of the WordBuilder textbox.
                    if (index == 0)
                    {
                        listBox3.SetSelected(index, true);
                        Word_Builder.AppendText(listBox3.SelectedItem.ToString());
                        //We append the same character in the WordBuilder textbox so as to leave the first item in the sequence.
                        Word_Builder.AppendText(listBox3.SelectedItem.ToString());
                        //By removing two characters from the starting position x and inserting from the same starting address the selected item.
                        Word_Builder.Text = Word_Builder.Text.Remove(x, 2).Insert(x, listBox3.SelectedItem.ToString());
                        //We increment the index.
                        index++;
                    }
                    else
                    {
                        if (index <= 8)
                        {
                            //Selecting the other items fromt he listbox3 by increasing the index and append them to the WordBuilder textbox.
                            listBox3.SetSelected(index, true);
                            Word_Builder.AppendText(listBox3.SelectedItem.ToString());
                            //By removing two characters from the starting position x and inserting from the same starting address the selected item.
                            Word_Builder.Text = Word_Builder.Text.Remove(x, 2).Insert(x, listBox3.SelectedItem.ToString());
                            //We increment the index.
                            index++;
                        }
                        else
                        {
                            //We reset the index.
                            index = 0;
                            //We remove the last character from the textbox.
                            Word_Builder.Text = Word_Builder.Text.Remove(x, 1);
                        }
                    }
                }
            }
        }
    }
}
