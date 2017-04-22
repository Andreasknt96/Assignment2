using System;
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
        int intMyListIndex;
        int n1 = 0;
        int n2 = 0;
        int n3 = 0;
        int n4 = 0;
        int n5 = 0;
        int n6 = 0;
        int n7 = 0;
        int n8 = 0;
        int n9 = 0;
        int n10 = 0;
        int n11 = 0;
        int item = 0;
        public Form1()
        {
            InitializeComponent();
            RichTextBox Word_Builder = new RichTextBox();

            //We create the text file if it does not exist.
            string path1 = @"C:\\C# Assignment 2\\save1.txt";
            if (!File.Exists(path1))
            {
                using (StreamWriter sw = File.CreateText(path1))
                {

                }
            }
            //We create the text file if it does not exist.
            string path2 = @"C:\\C# Assignment 2\\save2.txt";
            if (!File.Exists(path2))
            {
                using (StreamWriter sw = File.CreateText(path2))
                {

                }
            }
            //We create the text file if it does not exist.
            string path3 = @"C:\\C# Assignment 2\\save3.txt";
            if (!File.Exists(path3))
            {
                using (StreamWriter sw = File.CreateText(path3))
                {

                }
            }
            //We create the text file if it does not exist.
            string path4 = @"C:\\C# Assignment 2\\save4.txt";
            if (!File.Exists(path4))
            {
                using (StreamWriter sw = File.CreateText(path4))
                {

                }
            }
            //We create the text file if it does not exist.
            string path5 = @"C:\\C# Assignment 2\\save5.txt";
            if (!File.Exists(path5))
            {
                using (StreamWriter sw = File.CreateText(path5))
                {

                }
            }
            //We create the text file if it does not exist.
            string path6 = @"C:\\C# Assignment 2\\save6.txt";
            if (!File.Exists(path6))
            {
                using (StreamWriter sw = File.CreateText(path6))
                {

                }
            }
            //We create the text file if it does not exist.
            string path7 = @"C:\\C# Assignment 2\\save7.txt";
            if (!File.Exists(path7))
            {
                using (StreamWriter sw = File.CreateText(path7))
                {

                }
            }
            //We create the text file if it does not exist.
            string path8 = @"C:\\C# Assignment 2\\save8.txt";
            if (!File.Exists(path8))
            {
                using (StreamWriter sw = File.CreateText(path8))
                {

                }
            }
            //We create the text file if it does not exist.
            string path9 = @"C:\\C# Assignment 2\\save9.txt";
            if (!File.Exists(path9))
            {
                using (StreamWriter sw = File.CreateText(path9))
                {

                }
            }
            //We create the text file if it does not exist.
            string path10 = @"C:\\C# Assignment 2\\save10.txt";
            if (!File.Exists(path10))
            {
                using (StreamWriter sw = File.CreateText(path10))
                {

                }
            }
            //We create the text file if it does not exist.
            string path11 = @"C:\\C# Assignment 2\\save11.txt";
            if (!File.Exists(path11))
            {
                using (StreamWriter sw = File.CreateText(path11))
                {

                }
            }

            //We load the saved file into the listboxes.
            using (StreamReader sr = new StreamReader(@"C:\\C# Assignment 2\\save1.txt"))

            while (sr.Peek() != -1)
            {
                listBox12.Items.Add(sr.ReadLine());
            }

            //We load the saved file into the listboxes.
            using (StreamReader sr2 = new StreamReader(@"C:\\C# Assignment 2\\save2.txt"))

                while (sr2.Peek() != -1)
                {
                    listBox13.Items.Add(sr2.ReadLine());
                }

            //We load the saved file into the listboxes.
            using (StreamReader sr3 = new StreamReader(@"C:\\C# Assignment 2\\save3.txt"))

                while (sr3.Peek() != -1)
                {
                    listBox14.Items.Add(sr3.ReadLine());
                }

            //We load the saved file into the listboxes.
            using (StreamReader sr4 = new StreamReader(@"C:\\C# Assignment 2\\save4.txt"))

                while (sr4.Peek() != -1)
                {
                    listBox15.Items.Add(sr4.ReadLine());
                }

            //We load the saved file into the listboxes.
            using (StreamReader sr5 = new StreamReader(@"C:\\C# Assignment 2\\save5.txt"))

                while (sr5.Peek() != -1)
                {
                    listBox16.Items.Add(sr5.ReadLine());
                }

            //We load the saved file into the listboxes.
            using (StreamReader sr6 = new StreamReader(@"C:\\C# Assignment 2\\save6.txt"))

                while (sr6.Peek() != -1)
                {
                    listBox17.Items.Add(sr6.ReadLine());
                }

            //We load the saved file into the listboxes.
            using (StreamReader sr7 = new StreamReader(@"C:\\C# Assignment 2\\save7.txt"))

                while (sr7.Peek() != -1)
                {
                    listBox18.Items.Add(sr7.ReadLine());
                }

            //We load the saved file into the listboxes.
            using (StreamReader sr8 = new StreamReader(@"C:\\C# Assignment 2\\save8.txt"))

                while (sr8.Peek() != -1)
                {
                    listBox19.Items.Add(sr8.ReadLine());
                }

            //We load the saved file into the listboxes.
            using (StreamReader sr9 = new StreamReader(@"C:\\C# Assignment 2\\save9.txt"))

                while (sr9.Peek() != -1)
                {
                    listBox20.Items.Add(sr9.ReadLine());
                }

            //We load the saved file into the listboxes.
            using (StreamReader sr10 = new StreamReader(@"C:\\C# Assignment 2\\save10.txt"))

                while (sr10.Peek() != -1)
                {
                    listBox21.Items.Add(sr10.ReadLine());
                }

            //We load the saved file into the listboxes.
            using (StreamReader sr11 = new StreamReader(@"C:\\C# Assignment 2\\save11.txt"))

                while (sr11.Peek() != -1)
                {
                    listBox22.Items.Add(sr11.ReadLine());
                }
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
            //Changing the mode to Prediction.
            if (Mode_Status.Text == "Prediction")
            {
                //We take the length of the key_sequence text to substring the Word_Builder.
                string str2 = Key_Sequence.Text.ToString();
                int l = str2.Length;
                //We append the contents of the Word_Builder textbox into the NotePad and clear the Word_Builder textbox.
                NotePad.AppendText(Word_Builder.Text.Substring(0, l) + " ");
                Word_Builder.Clear();
                Key_Sequence.Clear();
                Char_Sequence.Clear();
                listBox23.Items.Clear();
                x = 0;
                index = 0;
            }
            else
            {
                //If the Word_Builder is empty the button doesn't do anything.
                if (Word_Builder.Text == "".ToString())
                {
                    Word_Builder.Text = "".ToString();
                }
                else
                    //We populate a dictionary for the words starting with a character from button 1.
                    if (Key_Sequence.Text.Substring(0, 1) == "1".ToString())
                    {
                        n1 = listBox12.Items.Count;
                        listBox12.Items.Add(Key_Sequence.Text + " , " + Word_Builder.Text + " , " + n1);
                        //We create a file on the hard disc to safe the contents of the dictionary.
                        using (StreamWriter SaveFile = new StreamWriter(@"C:\\C# Assignment 2\\save1.txt"))
                        foreach (var item in listBox12.Items)
                        {
                            SaveFile.WriteLine(item.ToString());
                        }
                        //By pressing the '000' button we append the text content of the WordBuilder TextBox into the NotePad and we clear the variable Str_KeyStrokes.
                        NotePad.AppendText(Word_Builder.Text.ToString() + " ");
                        Key_Sequence.Clear();
                        Word_Builder.Clear();
                        x = 0;
                        index = 0;
                    }
                    else
                        //We populate a dictionary for the words starting with a character from button 2.
                        if (Key_Sequence.Text.Substring(0, 1) == "2".ToString())
                        {
                            n2 = listBox13.Items.Count;
                            listBox13.Items.Add(Key_Sequence.Text + " , " + Word_Builder.Text + " , " + n2);
                            //We create a file on the hard disc to safe the contents of the dictionary.
                            using (StreamWriter SaveFile = new StreamWriter(@"C:\\C# Assignment 2\\save2.txt"))
                                foreach (var item in listBox13.Items)
                                {
                                    SaveFile.WriteLine(item.ToString());
                                }
                            //By pressing the '000' button we append the text content of the WordBuilder TextBox into the NotePad and we clear the variable Str_KeyStrokes.
                            NotePad.AppendText(Word_Builder.Text.ToString() + " ");
                            Key_Sequence.Clear();
                            Word_Builder.Clear();
                            x = 0;
                            index = 0;
                        }
                        else
                            //We populate a dictionary for the words starting with a character from button 3.
                            if (Key_Sequence.Text.Substring(0, 1) == "3".ToString())
                            {
                                n3 = listBox14.Items.Count;
                                listBox14.Items.Add(Key_Sequence.Text + " , " + Word_Builder.Text + " , " + n3);
                                //We create a file on the hard disc to safe the contents of the dictionary.
                                using (StreamWriter SaveFile = new StreamWriter(@"C:\\C# Assignment 2\\save3.txt"))
                                    foreach (var item in listBox14.Items)
                                    {
                                        SaveFile.WriteLine(item.ToString());
                                    }
                                //By pressing the '000' button we append the text content of the WordBuilder TextBox into the NotePad and we clear the variable Str_KeyStrokes.
                                NotePad.AppendText(Word_Builder.Text.ToString() + " ");
                                Key_Sequence.Clear();
                                Word_Builder.Clear();
                                x = 0;
                                index = 0;
                            }
                            else
                                //We populate a dictionary for the words starting with a character from button 4.
                                if (Key_Sequence.Text.Substring(0, 1) == "4".ToString())
                                {
                                    n4 = listBox15.Items.Count;
                                    listBox15.Items.Add(Key_Sequence.Text + " , " + Word_Builder.Text + " , " + n4);
                                    //We create a file on the hard disc to safe the contents of the dictionary.
                                    using (StreamWriter SaveFile = new StreamWriter(@"C:\\C# Assignment 2\\save4.txt"))
                                        foreach (var item in listBox15.Items)
                                        {
                                            SaveFile.WriteLine(item.ToString());
                                        }
                                    //By pressing the '000' button we append the text content of the WordBuilder TextBox into the NotePad and we clear the variable Str_KeyStrokes.
                                    NotePad.AppendText(Word_Builder.Text.ToString() + " ");
                                    Key_Sequence.Clear();
                                    Word_Builder.Clear();
                                    x = 0;
                                    index = 0;
                                }
                                else
                                    //We populate a dictionary for the words starting with a character from button 5.
                                    if (Key_Sequence.Text.Substring(0, 1) == "5".ToString())
                                    {
                                        n5 = listBox16.Items.Count;
                                        listBox16.Items.Add(Key_Sequence.Text + " , " + Word_Builder.Text + " , " + n5);
                                        //We create a file on the hard disc to safe the contents of the dictionary.
                                        using (StreamWriter SaveFile = new StreamWriter(@"C:\\C# Assignment 2\\save5.txt"))
                                            foreach (var item in listBox16.Items)
                                            {
                                                SaveFile.WriteLine(item.ToString());
                                            }
                                        //By pressing the '000' button we append the text content of the WordBuilder TextBox into the NotePad and we clear the variable Str_KeyStrokes.
                                        NotePad.AppendText(Word_Builder.Text.ToString() + " ");
                                        Key_Sequence.Clear();
                                        Word_Builder.Clear();
                                        x = 0;
                                        index = 0;
                                    }
                                    else
                                        //We populate a dictionary for the words starting with a character from button 6.
                                        if (Key_Sequence.Text.Substring(0, 1) == "6".ToString())
                                        {
                                            n6 = listBox17.Items.Count;
                                            listBox17.Items.Add(Key_Sequence.Text + " , " + Word_Builder.Text + " , " + n6);
                                            //We create a file on the hard disc to safe the contents of the dictionary.
                                            using (StreamWriter SaveFile = new StreamWriter(@"C:\\C# Assignment 2\\save6.txt"))
                                                foreach (var item in listBox17.Items)
                                                {
                                                    SaveFile.WriteLine(item.ToString());
                                                }
                                            //By pressing the '000' button we append the text content of the WordBuilder TextBox into the NotePad and we clear the variable Str_KeyStrokes.
                                            NotePad.AppendText(Word_Builder.Text.ToString() + " ");
                                            Key_Sequence.Clear();
                                            Word_Builder.Clear();
                                            x = 0;
                                            index = 0;
                                        }
                                        else
                                            //We populate a dictionary for the words starting with a character from button 7.
                                            if (Key_Sequence.Text.Substring(0, 1) == "7".ToString())
                                            {
                                                n7 = listBox18.Items.Count;
                                                listBox18.Items.Add(Key_Sequence.Text + " , " + Word_Builder.Text + " , " + n7);
                                                //We create a file on the hard disc to safe the contents of the dictionary.
                                                using (StreamWriter SaveFile = new StreamWriter(@"C:\\C# Assignment 2\\save7.txt"))
                                                    foreach (var item in listBox18.Items)
                                                    {
                                                        SaveFile.WriteLine(item.ToString());
                                                    }
                                                //By pressing the '000' button we append the text content of the WordBuilder TextBox into the NotePad and we clear the variable Str_KeyStrokes.
                                                NotePad.AppendText(Word_Builder.Text.ToString() + " ");
                                                Key_Sequence.Clear();
                                                Word_Builder.Clear();
                                                x = 0;
                                                index = 0;
                                            }
                                            else
                                                //We populate a dictionary for the words starting with a character from button 8.
                                                if (Key_Sequence.Text.Substring(0, 1) == "8".ToString())
                                                {
                                                    n8 = listBox19.Items.Count;
                                                    listBox19.Items.Add(Key_Sequence.Text + " , " + Word_Builder.Text + " , " + n8);
                                                    //We create a file on the hard disc to safe the contents of the dictionary.
                                                    using (StreamWriter SaveFile = new StreamWriter(@"C:\\C# Assignment 2\\save8.txt"))
                                                        foreach (var item in listBox19.Items)
                                                        {
                                                            SaveFile.WriteLine(item.ToString());
                                                        }
                                                    //By pressing the '000' button we append the text content of the WordBuilder TextBox into the NotePad and we clear the variable Str_KeyStrokes.
                                                    NotePad.AppendText(Word_Builder.Text.ToString() + " ");
                                                    Key_Sequence.Clear();
                                                    Word_Builder.Clear();
                                                    x = 0;
                                                    index = 0;
                                                }
                                                else
                                                    //We populate a dictionary for the words starting with a character from button 9.
                                                    if (Key_Sequence.Text.Substring(0, 1) == "9".ToString())
                                                    {
                                                        n9 = listBox20.Items.Count;
                                                        listBox20.Items.Add(Key_Sequence.Text + " , " + Word_Builder.Text + " , " + n9);
                                                        //We create a file on the hard disc to safe the contents of the dictionary.
                                                        using (StreamWriter SaveFile = new StreamWriter(@"C:\\C# Assignment 2\\save9.txt"))
                                                            foreach (var item in listBox20.Items)
                                                            {
                                                                SaveFile.WriteLine(item.ToString());
                                                            }
                                                        //By pressing the '000' button we append the text content of the WordBuilder TextBox into the NotePad and we clear the variable Str_KeyStrokes.
                                                        NotePad.AppendText(Word_Builder.Text.ToString() + " ");
                                                        Key_Sequence.Clear();
                                                        Word_Builder.Clear();
                                                        x = 0;
                                                        index = 0;
                                                    }
                                                    else
                                                        //We populate a dictionary for the words starting with a character from button 10.
                                                        if (Key_Sequence.Text.Substring(0, 1) == "*".ToString())
                                                        {
                                                            n10 = listBox21.Items.Count;
                                                            listBox21.Items.Add(Key_Sequence.Text + " , " + Word_Builder.Text + " , " + n10);
                                                            //We create a file on the hard disc to safe the contents of the dictionary.
                                                            using (StreamWriter SaveFile = new StreamWriter(@"C:\\C# Assignment 2\\save10.txt"))
                                                                foreach (var item in listBox21.Items)
                                                                {
                                                                    SaveFile.WriteLine(item.ToString());
                                                                }
                                                            //By pressing the '000' button we append the text content of the WordBuilder TextBox into the NotePad and we clear the variable Str_KeyStrokes.
                                                            NotePad.AppendText(Word_Builder.Text.ToString() + " ");
                                                            Key_Sequence.Clear();
                                                            Word_Builder.Clear();
                                                            x = 0;
                                                            index = 0;
                                                        }
                                                        else
                                                            //We populate a dictionary for the words starting with a character from button 11.
                                                            if (Key_Sequence.Text.Substring(0, 1) == "#".ToString())
                                                            {
                                                                n11 = listBox22.Items.Count;
                                                                listBox22.Items.Add(Key_Sequence.Text + " , " + Word_Builder.Text + " , " + n11);
                                                                //We create a file on the hard disc to safe the contents of the dictionary.
                                                                using (StreamWriter SaveFile = new StreamWriter(@"C:\\C# Assignment 2\\save11.txt"))
                                                                    foreach (var item in listBox22.Items)
                                                                    {
                                                                        SaveFile.WriteLine(item.ToString());
                                                                    }
                                                                //By pressing the '000' button we append the text content of the WordBuilder TextBox into the NotePad and we clear the variable Str_KeyStrokes.
                                                                NotePad.AppendText(Word_Builder.Text.ToString() + " ");
                                                                Key_Sequence.Clear();
                                                                Word_Builder.Clear();
                                                                x = 0;
                                                                index = 0;
                                                            }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //We are checking if a button was pressed before and that is not number 7.
            while (boolsButtonPressed[intWhichButton] == true && intMyListIndex != 7)
            {
                switch (intMyListIndex)
                {
                    case 1:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox1.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox1.SetSelected(index, true);
                            Word_Builder.AppendText(listBox1.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 2:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox2.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox2.SetSelected(index, true);
                            Word_Builder.AppendText(listBox2.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 3:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox3.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox3.SetSelected(index, true);
                            Word_Builder.AppendText(listBox3.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 4:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox4.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox4.SetSelected(index, true);
                            Word_Builder.AppendText(listBox4.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 5:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox5.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox5.SetSelected(index, true);
                            Word_Builder.AppendText(listBox5.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 6:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox6.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox6.SetSelected(index, true);
                            Word_Builder.AppendText(listBox6.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 7:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox7.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox7.SetSelected(index, true);
                            Word_Builder.AppendText(listBox7.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 8:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox8.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox8.SetSelected(index, true);
                            Word_Builder.AppendText(listBox8.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 9:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox9.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox9.SetSelected(index, true);
                            Word_Builder.AppendText(listBox9.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 10:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox10.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox10.SetSelected(index, true);
                            Word_Builder.AppendText(listBox10.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 11:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox11.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox11.SetSelected(index, true);
                            Word_Builder.AppendText(listBox11.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;
                }
            }
            //On the first selection of the key we append the key number to the variable str_KeyStrokes.
            while (boolFirstVisit == true)
            {
                Key_Sequence.AppendText("7".ToString());
                str_KeyStrokes = Key_Sequence.Text.ToString();
                boolFirstVisit = false;
                boolsButtonPressed[intWhichButton] = true;
            }

            intMyListIndex = 7;
            // To exdent the timer interval whenever we press a key.
            withinTimer.Enabled = false;
            withinTimer.Enabled = true;
            withinTimer.Interval = intIntervalRequired;

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
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                            //Selecting the other items fromt he listbox7 by increasing the index and append them to the WordBuilder textbox.
                            listBox7.SetSelected(index, true);
                            Word_Builder.AppendText(listBox7.SelectedItem.ToString());
                            index++;
                        }
                        else
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
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
            //We retrieve the contents of the Word_Builder before the Prediction from the saved variable Char_sequence.
            Word_Builder.Text = Char_Sequence.Text.ToString();
            //We are checking if a button was pressed before and that is not number 4.
            while (boolsButtonPressed[intWhichButton] == true && intMyListIndex != 4)
            {
                switch (intMyListIndex)
                {

                    case 1:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox1.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox1.SetSelected(index, true);
                            Word_Builder.AppendText(listBox1.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 2:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox2.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox2.SetSelected(index, true);
                            Word_Builder.AppendText(listBox2.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 3:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox3.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox3.SetSelected(index, true);
                            Word_Builder.AppendText(listBox3.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 5:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox5.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox5.SetSelected(index, true);
                            Word_Builder.AppendText(listBox5.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 6:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox6.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox6.SetSelected(index, true);
                            Word_Builder.AppendText(listBox6.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 7:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox7.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox7.SetSelected(index, true);
                            Word_Builder.AppendText(listBox7.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 8:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox8.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox8.SetSelected(index, true);
                            Word_Builder.AppendText(listBox8.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 9:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox9.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox9.SetSelected(index, true);
                            Word_Builder.AppendText(listBox9.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 10:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox10.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox10.SetSelected(index, true);
                            Word_Builder.AppendText(listBox10.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 11:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox11.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox11.SetSelected(index, true);
                            Word_Builder.AppendText(listBox11.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;
                }
            }
            //On the first selection of the key we append the key number to the variable str_KeyStrokes.
            while (boolFirstVisit == true)
            {
                Key_Sequence.AppendText("4".ToString());
                str_KeyStrokes = Key_Sequence.Text.ToString();
                boolFirstVisit = false;
                boolsButtonPressed[intWhichButton] = true;
            }

            intMyListIndex = 4;
            // To exdent the timer interval whenever we press a key.
            withinTimer.Enabled = false;
            withinTimer.Enabled = true;
            withinTimer.Interval = intIntervalRequired;

            //We select an item from the listBox1 and appended to Word_Builder textbox for the first character.
            if (x == 0)
            {
                if (index <= 6)
                {
                    listBox4.SetSelected(index, true);
                    Word_Builder.Text = listBox4.SelectedItem.ToString();
                    //We copy the contents of the word_builder textbox into the char_sequence textbox.
                    Char_Sequence.Text = listBox4.SelectedItem.ToString();
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
                        listBox4.SetSelected(index, true);
                        Word_Builder.AppendText(listBox4.SelectedItem.ToString());
                        Char_Sequence.AppendText(listBox4.SelectedItem.ToString());
                        //We increment the index.
                        index++;
                    }
                    else
                        if (index <= 6)
                        {
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                            Char_Sequence.Text = Char_Sequence.Text.Substring(0, Char_Sequence.Text.Length - 1);
                            //Selecting the other items fromt he listbox1 by increasing the index and append them to the WordBuilder textbox.
                            listBox4.SetSelected(index, true);
                            Word_Builder.AppendText(listBox4.SelectedItem.ToString());
                            Char_Sequence.AppendText(listBox4.SelectedItem.ToString());
                            //We increment the index.
                            index++;
                        }
                        else
                        {
                            //We reset the index.
                            index = 0;
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                            Char_Sequence.Text = Char_Sequence.Text.Substring(0, Char_Sequence.Text.Length - 1);
                        }
                    }
                }
                if (Mode_Status.Text == "Prediction")
                {
                    //We clear listbox23 to load another prediction list.
                    listBox23.Items.Clear();
                    if (listBox23.Items.Count == 0)
                    {
                        string str2 = Key_Sequence.Text.ToString();
                        if (str2.StartsWith("4"))
                        {
                            //Go through all the items in listbox12 and if the key_sequence match or start with the split sequence string we load that item in listbox23.
                            for (int item = 0; item < listBox15.Items.Count; item++)
                            {
                                listBox15.SetSelected(item, true);
                                string str = listBox15.SelectedItem.ToString();
                                string str1 = str.Split(',')[0];
                                string str3 = str.Split(',')[1];
                                if (str1.StartsWith(str2))
                                {
                                    listBox23.Items.Add(str1 + "," + str3);
                                }
                            }
                            //Go through the prediction list to find the most frequent used word.
                            if (listBox23.Items.Count >= 1)
                            {
                                string st1 = default(string);
                                string st2 = default(string);
                                string st3 = default(string);
                                int l1 = default(int);
                                int l2 = default(int);
                                foreach (string var_st1 in listBox23.Items)
                                {
                                    st1 = var_st1;
                                    foreach (string var_st2 in listBox23.Items)
                                    {
                                        st2 = var_st2;
                                        if (st1 == st2)
                                        {
                                            l1++;
                                        }
                                    }
                                    if (l1 > l2)
                                    {
                                        l2 = l1;
                                        st3 = st1;
                                    }
                                    l1 = 0;
                                }
                                int l = str2.Length;
                                string str1 = st3.Split(',')[1];
                                Word_Builder.Text = str1.ToString();
                                //We change the colour of the string.
                                Word_Builder.SelectionStart = 1;
                                Word_Builder.SelectionLength = l;
                                Word_Builder.SelectionColor = Color.Black;
                                Word_Builder.SelectionStart = l+1;
                                Word_Builder.SelectionLength = 100;
                                Word_Builder.SelectionColor = Color.Red;
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
            //The file must not be empty.
          if (NotePad.Text != string.Empty)
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
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NotePad.Text != string.Empty)
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

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes Application.
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //We retrieve the contents of the Word_Builder before the Prediction from the saved variable Char_sequence.
            Word_Builder.Text = Char_Sequence.Text.ToString();
            //We are checking if a button was pressed before and that is not number 1.
            while (boolsButtonPressed[intWhichButton] == true && intMyListIndex != 1)
            {
                switch (intMyListIndex)
                {

                    case 2:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox2.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox2.SetSelected(index, true);
                            Word_Builder.AppendText(listBox2.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 3:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox3.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox3.SetSelected(index, true);
                            Word_Builder.AppendText(listBox3.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 4:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox4.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox4.SetSelected(index, true);
                            Word_Builder.AppendText(listBox4.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 5:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox5.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox5.SetSelected(index, true);
                            Word_Builder.AppendText(listBox5.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 6:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox6.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox6.SetSelected(index, true);
                            Word_Builder.AppendText(listBox6.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 7:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox7.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox7.SetSelected(index, true);
                            Word_Builder.AppendText(listBox7.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 8:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox8.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox8.SetSelected(index, true);
                            Word_Builder.AppendText(listBox8.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 9:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox9.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox9.SetSelected(index, true);
                            Word_Builder.AppendText(listBox9.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 10:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox10.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox10.SetSelected(index, true);
                            Word_Builder.AppendText(listBox10.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 11:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox11.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox11.SetSelected(index, true);
                            Word_Builder.AppendText(listBox11.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;
                }
            }
            //On the first selection of the key we append the key number to the variable str_KeyStrokes.
            while (boolFirstVisit == true)
            {
                Key_Sequence.AppendText("1".ToString());
                str_KeyStrokes = Key_Sequence.Text.ToString();
                boolFirstVisit = false;
                boolsButtonPressed[intWhichButton] = true;
            }

            intMyListIndex = 1;
            // To exdent the timer interval whenever we press a key.
            withinTimer.Enabled = false;
            withinTimer.Enabled = true;
            withinTimer.Interval = intIntervalRequired;

            //We select an item from the listBox1 and appended to Word_Builder textbox for the first character.
            if (x == 0)
            {
                if (index <= 8)
                {
                    listBox1.SetSelected(index, true);
                    Word_Builder.Text = listBox1.SelectedItem.ToString();
                    //We copy the contents of the word_builder textbox into the char_sequence textbox.
                    Char_Sequence.Text = listBox1.SelectedItem.ToString();
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
                        Char_Sequence.AppendText(listBox1.SelectedItem.ToString());
                        //We increment the index.
                        index++;
                    }
                    else
                        if (index <= 8)
                        {
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                            Char_Sequence.Text = Char_Sequence.Text.Substring(0, Char_Sequence.Text.Length - 1);
                            //Selecting the other items fromt he listbox1 by increasing the index and append them to the WordBuilder textbox.
                            listBox1.SetSelected(index, true);
                            Word_Builder.AppendText(listBox1.SelectedItem.ToString());
                            Char_Sequence.AppendText(listBox1.SelectedItem.ToString());
                            //We increment the index.
                            index++;
                        }
                        else
                        {
                            //We reset the index.
                            index = 0;
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                            Char_Sequence.Text = Char_Sequence.Text.Substring(0, Char_Sequence.Text.Length - 1);
                        }
                    }
                }
                if (Mode_Status.Text == "Prediction")
                {
                    //We clear listbox23 to load another prediction list.
                    listBox23.Items.Clear();
                    if (listBox23.Items.Count == 0)
                    {
                        string str2 = Key_Sequence.Text.ToString();
                        if (str2.StartsWith("1"))
                        {
                            //Go through all the items in listbox12 and if the key_sequence match or start with the split sequence string we load that item in listbox23.
                            for (int item = 0; item < listBox12.Items.Count; item ++)
                            {
                                listBox12.SetSelected(item, true);
                                string str = listBox12.SelectedItem.ToString();
                                string str1 = str.Split(',')[0];
                                string str3 = str.Split(',')[1];
                                if (str1.StartsWith(str2))
                                {
                                    listBox23.Items.Add(str1 + "," + str3);
                                }
                            }
                            //Go through the prediction list to find the most frequent used word.
                            if (listBox23.Items.Count >= 1)
                            {
                                string st1 = default(string);
                                string st2 = default(string);
                                string st3 = default(string);
                                int l1 = default(int);
                                int l2 = default(int);
                                foreach (string var_st1 in listBox23.Items)
                                {
                                    st1 = var_st1;
                                    foreach (string var_st2 in listBox23.Items)
                                    {
                                        st2 = var_st2;
                                        if (st1 == st2)
                                        {
                                            l1++;
                                        }
                                    }
                                    if (l1 > l2)
                                    {
                                        l2 = l1;
                                        st3 = st1;
                                    }
                                    l1 = 0;
                                }
                                int l = str2.Length;
                                string str1 = st3.Split(',')[1];
                                Word_Builder.Text = str1.ToString();
                                //We change the colour of the string.
                                Word_Builder.SelectionStart = 1;
                                Word_Builder.SelectionLength = l;
                                Word_Builder.SelectionColor = Color.Black;
                                Word_Builder.SelectionStart = l+1;
                                Word_Builder.SelectionLength = 100;
                                Word_Builder.SelectionColor = Color.Red;
                            }
                        }
                    }
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //We are checking if a button was pressed before and that is not number 3.
            while (boolsButtonPressed[intWhichButton] == true && intMyListIndex != 3)
            {
                switch (intMyListIndex)
                {
                    case 1:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox1.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox1.SetSelected(index, true);
                            Word_Builder.AppendText(listBox1.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 2:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox2.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox2.SetSelected(index, true);
                            Word_Builder.AppendText(listBox2.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 4:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox4.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox4.SetSelected(index, true);
                            Word_Builder.AppendText(listBox4.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 5:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox5.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox5.SetSelected(index, true);
                            Word_Builder.AppendText(listBox5.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 6:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox6.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox6.SetSelected(index, true);
                            Word_Builder.AppendText(listBox6.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 7:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox7.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox7.SetSelected(index, true);
                            Word_Builder.AppendText(listBox7.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 8:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox8.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox8.SetSelected(index, true);
                            Word_Builder.AppendText(listBox8.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 9:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox9.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox9.SetSelected(index, true);
                            Word_Builder.AppendText(listBox9.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 10:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox10.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox10.SetSelected(index, true);
                            Word_Builder.AppendText(listBox10.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 11:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox11.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox11.SetSelected(index, true);
                            Word_Builder.AppendText(listBox11.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;
                }
            }
            //On the first selection of the key we append the key number to the variable str_KeyStrokes.
            while (boolFirstVisit == true)
            {
                Key_Sequence.AppendText("3".ToString());
                str_KeyStrokes = Key_Sequence.Text.ToString();
                boolFirstVisit = false;
                boolsButtonPressed[intWhichButton] = true;
            }

            intMyListIndex = 3;
            // To exdent the timer interval whenever we press a key.
            withinTimer.Enabled = false;
            withinTimer.Enabled = true;
            withinTimer.Interval = intIntervalRequired;

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
                        //We increment the index.
                        index++;
                    }
                    else
                    {
                        if (index <= 8)
                        {
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                            //Selecting the other items fromt he listbox3 by increasing the index and append them to the WordBuilder textbox.
                            listBox3.SetSelected(index, true);
                            Word_Builder.AppendText(listBox3.SelectedItem.ToString());
                            //We increment the index.
                            index++;
                        }
                        else
                        {
                            //We reset the index.
                            index = 0;
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //We are checking if a button was pressed before and that is not number 5.
            while (boolsButtonPressed[intWhichButton] == true && intMyListIndex != 5)
            {
                switch (intMyListIndex)
                {
                    case 1:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox1.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox1.SetSelected(index, true);
                            Word_Builder.AppendText(listBox1.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 2:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox2.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox2.SetSelected(index, true);
                            Word_Builder.AppendText(listBox2.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 3:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox3.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox3.SetSelected(index, true);
                            Word_Builder.AppendText(listBox3.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 4:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox4.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox4.SetSelected(index, true);
                            Word_Builder.AppendText(listBox4.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 6:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox6.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox6.SetSelected(index, true);
                            Word_Builder.AppendText(listBox6.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 7:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox7.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox7.SetSelected(index, true);
                            Word_Builder.AppendText(listBox7.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 8:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox8.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox8.SetSelected(index, true);
                            Word_Builder.AppendText(listBox8.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 9:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox9.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox9.SetSelected(index, true);
                            Word_Builder.AppendText(listBox9.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 10:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox10.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox10.SetSelected(index, true);
                            Word_Builder.AppendText(listBox10.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 11:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox11.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox11.SetSelected(index, true);
                            Word_Builder.AppendText(listBox11.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;
                }
            }
            //On the first selection of the key we append the key number to the variable str_KeyStrokes.
            while (boolFirstVisit == true)
            {
                Key_Sequence.AppendText("5".ToString());
                str_KeyStrokes = Key_Sequence.Text.ToString();
                boolFirstVisit = false;
                boolsButtonPressed[intWhichButton] = true;
            }

            intMyListIndex = 5;
            // To exdent the timer interval whenever we press a key.
            withinTimer.Enabled = false;
            withinTimer.Enabled = true;
            withinTimer.Interval = intIntervalRequired;

            //We select an item from the listBox5 and appended to Word_Builder textbox for the first character.
            if (x == 0)
            {
                if (index <= 6)
                {
                    listBox5.SetSelected(index, true);
                    Word_Builder.Text = listBox5.SelectedItem.ToString();
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
                    //We select the first item from the listbox5 and append it to the second position of the WordBuilder textbox.
                    if (index == 0)
                    {
                        listBox5.SetSelected(index, true);
                        Word_Builder.AppendText(listBox5.SelectedItem.ToString());
                        //We increment the index.
                        index++;
                    }
                    else
                    {
                        if (index <= 6)
                        {
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                            //Selecting the other items fromt he listbox5 by increasing the index and append them to the WordBuilder textbox.
                            listBox5.SetSelected(index, true);
                            Word_Builder.AppendText(listBox5.SelectedItem.ToString());
                            //We increment the index.
                            index++;
                        }
                        else
                        {
                            //We reset the index.
                            index = 0;
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                        }
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //We are checking if a button was pressed before and that is not number 6.
            while (boolsButtonPressed[intWhichButton] == true && intMyListIndex != 6)
            {
                switch (intMyListIndex)
                {
                    case 1:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox1.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox1.SetSelected(index, true);
                            Word_Builder.AppendText(listBox1.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 2:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox2.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox2.SetSelected(index, true);
                            Word_Builder.AppendText(listBox2.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 3:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox3.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox3.SetSelected(index, true);
                            Word_Builder.AppendText(listBox3.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 4:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox4.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox4.SetSelected(index, true);
                            Word_Builder.AppendText(listBox4.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 5:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox5.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox5.SetSelected(index, true);
                            Word_Builder.AppendText(listBox5.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 7:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox7.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox7.SetSelected(index, true);
                            Word_Builder.AppendText(listBox7.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 8:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox8.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox8.SetSelected(index, true);
                            Word_Builder.AppendText(listBox8.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 9:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox9.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox9.SetSelected(index, true);
                            Word_Builder.AppendText(listBox9.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 10:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox10.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox10.SetSelected(index, true);
                            Word_Builder.AppendText(listBox10.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 11:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox11.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox11.SetSelected(index, true);
                            Word_Builder.AppendText(listBox11.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;
                }
            }
            //On the first selection of the key we append the key number to the variable str_KeyStrokes.
            while (boolFirstVisit == true)
            {
                Key_Sequence.AppendText("6".ToString());
                str_KeyStrokes = Key_Sequence.Text.ToString();
                boolFirstVisit = false;
                boolsButtonPressed[intWhichButton] = true;
            }

            intMyListIndex = 6;
            // To exdent the timer interval whenever we press a key.
            withinTimer.Enabled = false;
            withinTimer.Enabled = true;
            withinTimer.Interval = intIntervalRequired;

            //We select an item from the listBox6 and appended to Word_Builder textbox for the first character.
            if (x == 0)
            {
                if (index <= 6)
                {
                    listBox6.SetSelected(index, true);
                    Word_Builder.Text = listBox6.SelectedItem.ToString();
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
                    //We select the first item from the listbox6 and append it to the second position of the WordBuilder textbox.
                    if (index == 0)
                    {
                        listBox6.SetSelected(index, true);
                        Word_Builder.AppendText(listBox6.SelectedItem.ToString());
                        //We increment the index.
                        index++;
                    }
                    else
                    {
                        if (index <= 6)
                        {
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                            //Selecting the other items fromt he listbox6 by increasing the index and append them to the WordBuilder textbox.
                            listBox6.SetSelected(index, true);
                            Word_Builder.AppendText(listBox6.SelectedItem.ToString());
                            //We increment the index.
                            index++;
                        }
                        else
                        {
                            //We reset the index.
                            index = 0;
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //We are checking if a button was pressed before and that is not number 2.
            while (boolsButtonPressed[intWhichButton] == true && intMyListIndex != 2)
            {
                switch (intMyListIndex)
                {
                    case 1:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox1.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox1.SetSelected(index, true);
                            Word_Builder.AppendText(listBox1.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 3:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox3.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox3.SetSelected(index, true);
                            Word_Builder.AppendText(listBox3.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 4:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox4.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox4.SetSelected(index, true);
                            Word_Builder.AppendText(listBox4.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 5:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox5.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox5.SetSelected(index, true);
                            Word_Builder.AppendText(listBox5.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 6:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox6.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox6.SetSelected(index, true);
                            Word_Builder.AppendText(listBox6.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 7:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox7.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox7.SetSelected(index, true);
                            Word_Builder.AppendText(listBox7.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 8:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox8.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox8.SetSelected(index, true);
                            Word_Builder.AppendText(listBox8.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 9:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox9.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox9.SetSelected(index, true);
                            Word_Builder.AppendText(listBox9.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 10:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox10.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox10.SetSelected(index, true);
                            Word_Builder.AppendText(listBox10.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 11:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox11.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox11.SetSelected(index, true);
                            Word_Builder.AppendText(listBox11.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;
                }
            }
            //On the first selection of the key we append the key number to the variable str_KeyStrokes.
            while (boolFirstVisit == true)
            {
                Key_Sequence.AppendText("2".ToString());
                str_KeyStrokes = Key_Sequence.Text.ToString();
                boolFirstVisit = false;
                boolsButtonPressed[intWhichButton] = true;
            }

            intMyListIndex = 2;
            // To exdent the timer interval whenever we press a key.
            withinTimer.Enabled = false;
            withinTimer.Enabled = true;
            withinTimer.Interval = intIntervalRequired;

            //We select an item from the listBox2 and appended to Word_Builder textbox for the first character.
            if (x == 0)
            {
                if (index <= 6)
                {
                    listBox2.SetSelected(index, true);
                    Word_Builder.Text = listBox2.SelectedItem.ToString();
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
                    //We select the first item from the listbox2 and append it to the second position of the WordBuilder textbox.
                    if (index == 0)
                    {
                        listBox2.SetSelected(index, true);
                        Word_Builder.AppendText(listBox2.SelectedItem.ToString());
                        //We increment the index.
                        index++;
                    }
                    else
                    {
                        if (index <= 6)
                        {
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                            //Selecting the other items fromt he listbox2 by increasing the index and append them to the WordBuilder textbox.
                            listBox2.SetSelected(index, true);
                            Word_Builder.AppendText(listBox2.SelectedItem.ToString());
                            //We increment the index.
                            index++;
                        }
                        else
                        {
                            //We reset the index.
                            index = 0;
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                        }
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //We are checking if a button was pressed before and that is not number 8.
            while (boolsButtonPressed[intWhichButton] == true && intMyListIndex != 8)
            {
                switch (intMyListIndex)
                {
                    case 1:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox1.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox1.SetSelected(index, true);
                            Word_Builder.AppendText(listBox1.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 2:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox2.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox2.SetSelected(index, true);
                            Word_Builder.AppendText(listBox2.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 3:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox3.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox3.SetSelected(index, true);
                            Word_Builder.AppendText(listBox3.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 4:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox4.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox4.SetSelected(index, true);
                            Word_Builder.AppendText(listBox4.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 5:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox5.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox5.SetSelected(index, true);
                            Word_Builder.AppendText(listBox5.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 6:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox6.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox6.SetSelected(index, true);
                            Word_Builder.AppendText(listBox6.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 7:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox7.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox7.SetSelected(index, true);
                            Word_Builder.AppendText(listBox7.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 9:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox9.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox9.SetSelected(index, true);
                            Word_Builder.AppendText(listBox9.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 10:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox10.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox10.SetSelected(index, true);
                            Word_Builder.AppendText(listBox10.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 11:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox11.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox11.SetSelected(index, true);
                            Word_Builder.AppendText(listBox11.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;
                }
            }
            //On the first selection of the key we append the key number to the variable str_KeyStrokes.
            while (boolFirstVisit == true)
            {
                Key_Sequence.AppendText("8".ToString());
                str_KeyStrokes = Key_Sequence.Text.ToString();
                boolFirstVisit = false;
                boolsButtonPressed[intWhichButton] = true;
            }

            intMyListIndex = 8;
            // To exdent the timer interval whenever we press a key.
            withinTimer.Enabled = false;
            withinTimer.Enabled = true;
            withinTimer.Interval = intIntervalRequired;

            //We select an item from the listBox8 and appended to Word_Builder textbox for the first character.
            if (x == 0)
            {
                if (index <= 6)
                {
                    listBox8.SetSelected(index, true);
                    Word_Builder.Text = listBox8.SelectedItem.ToString();
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
                    //We select the first item from the listbox8 and append it to the second position of the WordBuilder textbox.
                    if (index == 0)
                    {
                        listBox8.SetSelected(index, true);
                        Word_Builder.AppendText(listBox8.SelectedItem.ToString());
                        //We increment the index.
                        index++;
                    }
                    else
                    {
                        if (index <= 6)
                        {
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                            //Selecting the other items fromt he listbox8 by increasing the index and append them to the WordBuilder textbox.
                            listBox8.SetSelected(index, true);
                            Word_Builder.AppendText(listBox8.SelectedItem.ToString());
                            //We increment the index.
                            index++;
                        }
                        else
                        {
                            //We reset the index.
                            index = 0;
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                        }
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //We are checking if a button was pressed before and that is not number 9.
            while (boolsButtonPressed[intWhichButton] == true && intMyListIndex != 9)
            {
                switch (intMyListIndex)
                {
                    case 1:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox1.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox1.SetSelected(index, true);
                            Word_Builder.AppendText(listBox1.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 2:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox2.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox2.SetSelected(index, true);
                            Word_Builder.AppendText(listBox2.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 3:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox3.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox3.SetSelected(index, true);
                            Word_Builder.AppendText(listBox3.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 4:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox4.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox4.SetSelected(index, true);
                            Word_Builder.AppendText(listBox4.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 5:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox5.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox5.SetSelected(index, true);
                            Word_Builder.AppendText(listBox5.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 6:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox6.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox6.SetSelected(index, true);
                            Word_Builder.AppendText(listBox6.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 7:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox7.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox7.SetSelected(index, true);
                            Word_Builder.AppendText(listBox7.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 8:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox8.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox8.SetSelected(index, true);
                            Word_Builder.AppendText(listBox8.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 10:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox10.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox10.SetSelected(index, true);
                            Word_Builder.AppendText(listBox10.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 11:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox11.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox11.SetSelected(index, true);
                            Word_Builder.AppendText(listBox11.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;
                }
            }
            //On the first selection of the key we append the key number to the variable str_KeyStrokes.
            while (boolFirstVisit == true)
            {
                Key_Sequence.AppendText("9".ToString());
                str_KeyStrokes = Key_Sequence.Text.ToString();
                boolFirstVisit = false;
                boolsButtonPressed[intWhichButton] = true;
            }

            intMyListIndex = 9;
            // To exdent the timer interval whenever we press a key.
            withinTimer.Enabled = false;
            withinTimer.Enabled = true;
            withinTimer.Interval = intIntervalRequired;

            //We select an item from the listBox9 and appended to Word_Builder textbox for the first character.
            if (x == 0)
            {
                if (index <= 6)
                {
                    listBox9.SetSelected(index, true);
                    Word_Builder.Text = listBox9.SelectedItem.ToString();
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
                    //We select the first item from the listbox9 and append it to the second position of the WordBuilder textbox.
                    if (index == 0)
                    {
                        listBox9.SetSelected(index, true);
                        Word_Builder.AppendText(listBox9.SelectedItem.ToString());
                        //We increment the index.
                        index++;
                    }
                    else
                    {
                        if (index <= 6)
                        {
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                            //Selecting the other items fromt he listbox9 by increasing the index and append them to the WordBuilder textbox.
                            listBox9.SetSelected(index, true);
                            Word_Builder.AppendText(listBox9.SelectedItem.ToString());
                            //We increment the index.
                            index++;
                        }
                        else
                        {
                            //We reset the index.
                            index = 0;
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                        }
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //We are checking if a button was pressed before and that is not number 10.
            while (boolsButtonPressed[intWhichButton] == true && intMyListIndex != 10)
            {
                switch (intMyListIndex)
                {
                    case 1:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox1.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox1.SetSelected(index, true);
                            Word_Builder.AppendText(listBox1.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 2:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox2.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox2.SetSelected(index, true);
                            Word_Builder.AppendText(listBox2.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 3:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox3.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox3.SetSelected(index, true);
                            Word_Builder.AppendText(listBox3.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 4:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox4.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox4.SetSelected(index, true);
                            Word_Builder.AppendText(listBox4.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 5:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox5.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox5.SetSelected(index, true);
                            Word_Builder.AppendText(listBox5.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 6:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox6.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox6.SetSelected(index, true);
                            Word_Builder.AppendText(listBox6.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 7:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox7.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox7.SetSelected(index, true);
                            Word_Builder.AppendText(listBox7.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 8:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox8.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox8.SetSelected(index, true);
                            Word_Builder.AppendText(listBox8.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 9:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox9.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox9.SetSelected(index, true);
                            Word_Builder.AppendText(listBox9.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 11:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox11.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox11.SetSelected(index, true);
                            Word_Builder.AppendText(listBox11.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;
                }
            }
            //On the first selection of the key we append the key number to the variable str_KeyStrokes.
            while (boolFirstVisit == true)
            {
                Key_Sequence.AppendText("*".ToString());
                str_KeyStrokes = Key_Sequence.Text.ToString();
                boolFirstVisit = false;
                boolsButtonPressed[intWhichButton] = true;
            }

            intMyListIndex = 10;
            // To exdent the timer interval whenever we press a key.
            withinTimer.Enabled = false;
            withinTimer.Enabled = true;
            withinTimer.Interval = intIntervalRequired;

            //We select an item from the listBox10 and appended to Word_Builder textbox for the first character.
            if (x == 0)
            {
                if (index <= 2)
                {
                    listBox10.SetSelected(index, true);
                    Word_Builder.Text = listBox10.SelectedItem.ToString();
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
                    //We select the first item from the listbox10 and append it to the second position of the WordBuilder textbox.
                    if (index == 0)
                    {
                        listBox10.SetSelected(index, true);
                        Word_Builder.AppendText(listBox10.SelectedItem.ToString());
                        //We increment the index.
                        index++;
                    }
                    else
                    {
                        if (index <= 2)
                        {
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                            //Selecting the other items fromt he listbox10 by increasing the index and append them to the WordBuilder textbox.
                            listBox10.SetSelected(index, true);
                            Word_Builder.AppendText(listBox10.SelectedItem.ToString());
                            //We increment the index.
                            index++;
                        }
                        else
                        {
                            //We reset the index.
                            index = 0;
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                        }
                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //We are checking if a button was pressed before and that is not number 11.
            while (boolsButtonPressed[intWhichButton] == true && intMyListIndex != 11)
            {
                switch (intMyListIndex)
                {
                    case 1:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox1.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox1.SetSelected(index, true);
                            Word_Builder.AppendText(listBox1.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 2:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox2.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox2.SetSelected(index, true);
                            Word_Builder.AppendText(listBox2.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 3:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox3.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox3.SetSelected(index, true);
                            Word_Builder.AppendText(listBox3.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 4:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox4.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox4.SetSelected(index, true);
                            Word_Builder.AppendText(listBox4.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 5:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox5.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox5.SetSelected(index, true);
                            Word_Builder.AppendText(listBox5.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 6:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox6.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox6.SetSelected(index, true);
                            Word_Builder.AppendText(listBox6.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 7:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox7.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox7.SetSelected(index, true);
                            Word_Builder.AppendText(listBox7.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 8:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox8.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox8.SetSelected(index, true);
                            Word_Builder.AppendText(listBox8.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 9:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox9.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox9.SetSelected(index, true);
                            Word_Builder.AppendText(listBox9.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;

                    case 10:
                        //We are checking whether the button which was pressed before is already selected.
                        if (Word_Builder.Text.EndsWith(listBox10.SelectedItem.ToString()))
                        {
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            x++;
                            index = 0;
                        }
                        else
                        {
                            //Eliminate the case that the index equals to -1.
                            while (index == 0)
                            {
                                index++;
                            }
                            //Setting the correct index for the previous button.
                            index--;
                            //We select the not selected button which was pressed before.
                            listBox10.SetSelected(index, true);
                            Word_Builder.AppendText(listBox10.SelectedItem.ToString());
                            boolFirstVisit = true;
                            boolsButtonPressed[intWhichButton] = false;
                            //We increament the position of the character in the Word_Builder text and making the index 0.
                            x++;
                            index = 0;
                        }
                        break;
                }
            }
            //On the first selection of the key we append the key number to the variable str_KeyStrokes.
            while (boolFirstVisit == true)
            {
                Key_Sequence.AppendText("#".ToString());
                str_KeyStrokes = Key_Sequence.Text.ToString();
                boolFirstVisit = false;
                boolsButtonPressed[intWhichButton] = true;
            }

            intMyListIndex = 11;
            // To exdent the timer interval whenever we press a key.
            withinTimer.Enabled = false;
            withinTimer.Enabled = true;
            withinTimer.Interval = intIntervalRequired;

            //We select an item from the listBox11 and appended to Word_Builder textbox for the first character.
            if (x == 0)
            {
                if (index <= 2)
                {
                    listBox11.SetSelected(index, true);
                    Word_Builder.Text = listBox11.SelectedItem.ToString();
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
                    //We select the first item from the listbox11 and append it to the second position of the WordBuilder textbox.
                    if (index == 0)
                    {
                        listBox11.SetSelected(index, true);
                        Word_Builder.AppendText(listBox11.SelectedItem.ToString());
                        //We increment the index.
                        index++;
                    }
                    else
                    {
                        if (index <= 2)
                        {
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                            //Selecting the other items fromt he listbox11 by increasing the index and append them to the WordBuilder textbox.
                            listBox11.SetSelected(index, true);
                            Word_Builder.AppendText(listBox11.SelectedItem.ToString());
                            //We increment the index.
                            index++;
                        }
                        else
                        {
                            //We reset the index.
                            index = 0;
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                        }
                    }
                }
            }
        }

        private void withinTimer_Tick(object sender, EventArgs e)
        {
            //Setting up the timer for one time only.
            withinTimer.Stop();
            //Having the second character replaced by the first after the time interval.
          if (index <= 2)
          {
              switch(intMyListIndex)
              {
                  case 7:
                      if (x == 0)
                      {
                          listBox7.SetSelected(0, true);
                          Word_Builder.Text = listBox7.SelectedItem.ToString();
                      }
                      else
                      {
                          if (index == 0)
                          {
                              Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                              listBox7.SetSelected(0, true);
                              Word_Builder.AppendText(listBox7.SelectedItem.ToString());
                          }
                          else
                             Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                             listBox7.SetSelected(0, true);
                             Word_Builder.AppendText(listBox7.SelectedItem.ToString());
                      }
                      withinTimer.Stop();
                      break;
              }
          }
         else
            //Setting up the timer for one time only.
            withinTimer.Stop();
            //Setting up the cursor at the end of Word_Builder text.
            Word_Builder.Focus();
            Word_Builder.SelectionStart = Word_Builder.Text.Length;
            //Increamenting the intiger x.
            x++;
            //Set the index equal to 0.
            index = 0;
            //We make the firstvisit true and the buttonpressed to false.
            boolFirstVisit = true;
            boolsButtonPressed[intWhichButton] = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Mode_Status.Text == "Prediction")
            {
                string str2 = Key_Sequence.Text.ToString();
                int l = str2.Length;
                //We select all the items in listbox23 one at a time.
                if (item < listBox23.Items.Count)
                {
                    //To avoid the possibility to have the item equals to -1.
                    if (item == 0)
                    {
                        listBox23.SetSelected(listBox23.Items.Count - 1, true);
                    }
                    else
                        item--;
                    listBox23.SetSelected(item, true);
                    string str = listBox23.SelectedItem.ToString();
                    //We split the string of the selected item to get the word in the dictionary and we dispay it to the Word_Builder textbox.
                    string str1 = str.Split(',')[1];
                    Word_Builder.Text = str1.ToString();
                    //We change the colour of the string.
                    Word_Builder.SelectionStart = 1;
                    Word_Builder.SelectionLength = l;
                    Word_Builder.SelectionColor = Color.Black;
                    Word_Builder.SelectionStart = l + 1;
                    Word_Builder.SelectionLength = 100;
                    Word_Builder.SelectionColor = Color.Red;
                }
                else
                    item = 0;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Mode_Status.Text == "Prediction")
            {
                //We append the content of the Word_builder into the Notepad and clearing all the textboxes.
                NotePad.AppendText(Word_Builder.Text.ToString() + "");
                listBox23.Items.Clear();
                Word_Builder.Clear();
                Key_Sequence.Clear();
                Char_Sequence.Clear();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Mode_Status.Text == "Prediction")
            {
                string str2 = Key_Sequence.Text.ToString();
                int l = str2.Length;
                if (item < listBox23.Items.Count)
                {
                    //If the selected item is the last we select the last to avoid an error.
                    if (item == listBox23.Items.Count - 1)
                        listBox23.SetSelected(listBox23.Items.Count - 1, true);
                    else
                        item++;
                    listBox23.SetSelected(item, true);
                    string str = listBox23.SelectedItem.ToString();
                    //We split the string of the selected item to get the word in the dictionary and we dispay it to the Word_Builder textbox.
                    string str1 = str.Split(',')[1];
                    Word_Builder.Text = str1.ToString();
                    //We change the colour of the string.
                    Word_Builder.SelectionStart = 1;
                    Word_Builder.SelectionLength = l;
                    Word_Builder.SelectionColor = Color.Black;
                    Word_Builder.SelectionStart = l + 1;
                    Word_Builder.SelectionLength = 100;
                    Word_Builder.SelectionColor = Color.Red;
                }
                else
                    item = 0;
            }
        }
    }
}
