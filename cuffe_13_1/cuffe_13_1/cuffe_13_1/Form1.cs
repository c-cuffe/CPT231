using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuffe_13_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create list to hold numbers in file
            List<int> numList = new List<int>();

            // Open StreamReader for file
            StreamReader numFile;

            numFile = File.OpenText("random.txt");

            // Iterate through each number in the file
            while (!numFile.EndOfStream)
            {
                // Convert each number to an integer and append to list
                numList.Add(int.Parse(numFile.ReadLine()));
            }

            // Close file
            numFile.Close();

            // Remove all negative numbers from list
            numList.RemoveAll(n => n < 0);

            // Remove all values outside of 1-10
            List<int> numListFinal = numList.FindAll(n => 1 < n && n < 10);
            
            // Append each number to the listbox
            foreach (int num in numListFinal)
            {
                lstNum.Items.Add(num);
            }

        }
    }
}
