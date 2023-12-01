using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Picker
{
    public partial class Form1 : Form
    {
        //An int list to contain all 6 values. 
        List<int> values = new List<int>();

        Random number  = new Random(1- 50);
        //An int value to contain the randomly selected value temporarily
        int rn = 0;
        
        //A constant value, (LIMIT) that contains the maximum value to be selected from. 
        public Form1()
        {
            InitializeComponent();
            instructionlable.Text = "Press button below to generate your 6/49 lottery numbers";
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            values.Add(rn);
            //For loop 6 times 
            // Get random value and place in temporary variable

            //While(list contains value)
            //Get random value place in temporary variable
            //End while

            //Add value to list
            //End for loop
            for (int i = 0; i < values.Count; i++)
            {
                outputlable.Text += $"{values[i]}\n";

                while (values.Contains(rn))
                {
                    
                }
            }

            
        }
            

       
    }
}
