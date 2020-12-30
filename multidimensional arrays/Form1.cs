using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multidimensional_arrays
{
    public partial class Form1 : Form
    {
       



        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrint1_Click(object sender, EventArgs e)
        {
            Random myRandom = new Random();
            myRandom.Next(0, 101);
            int total = 0;
            int[,] myarray = new int[5, 3];
            txtResultaat.Multiline = true;
            for (int i = 0; i < 5; i++)
            {

                myarray[i, 0] = myRandom.Next(0, 100);
                myarray[i, 1] = myRandom.Next(0, 100);
                myarray[i, 2] = myarray[i, 0] + myarray[i, 1];
                total = myarray[i, 2] + total;


            }
            printArray(myarray);
      
            
           
        }

        private void printArray (int[,] arrayToPrint)
        {
            txtResultaat.Text = "";
            for(int iRow =0; iRow < arrayToPrint.GetLowerBound(0) + 3;iRow++)
            {
                for(int iColumn=0; iColumn < arrayToPrint.GetUpperBound(1) +1; iColumn++)
                {
                    txtResultaat.Text = txtResultaat.Text + arrayToPrint[iRow, iColumn].ToString() + "\t";

                }
                txtResultaat.Text = txtResultaat.Text + Environment.NewLine + Environment.NewLine;
            }

        }
    }
}
