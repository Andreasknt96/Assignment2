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
            x = 0;
            index = 0;
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
            //We are checking if a button was pressed before and that is not number 4 .
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
                        //We increment the index.
                        index++;
                    }
                    else
                    {
                        if (index <= 6)
                        {
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length -1);
                            //Selecting the other items fromt he listbox4 by increasing the index and append them to the WordBuilder textbox.
                            listBox4.SetSelected(index, true);
                            Word_Builder.AppendText(listBox4.SelectedItem.ToString());
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
                        //We increment the index.
                        index++;
                    }
                    else
                    {
                        if (index <= 8)
                        {
                            //We remove the last character of the Word_Builder text.
                            Word_Builder.Text = Word_Builder.Text.Substring(0, Word_Builder.Text.Length - 1);
                            //Selecting the other items fromt he listbox1 by increasing the index and append them to the WordBuilder textbox.
                            listBox1.SetSelected(index, true);
                            Word_Builder.AppendText(listBox1.SelectedItem.ToString());
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
    }
}
