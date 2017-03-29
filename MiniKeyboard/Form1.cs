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
        bool[] boolButtonPressed = new bool[19];
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
    }
}
