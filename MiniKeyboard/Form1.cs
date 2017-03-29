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
    }
}
