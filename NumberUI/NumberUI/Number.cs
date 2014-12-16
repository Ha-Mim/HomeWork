using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberUI
{
    public partial class Number : Form
    {
        public Number()
        {
            InitializeComponent();
           
        }
        List<int> numbersList = new List<int>();
        private double sum = 0;

        private void addButton_Click(object sender, EventArgs e)
        {
            numbersList.Add(Convert.ToInt32(numberTextBox.Text));
            numberTextBox.Text = string.Empty;
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            foreach (int number in numbersList)
            {
                showListBox.Items.Add(number);
                sum = number + sum;
            }
            sumTextBox.Text = Convert.ToString(sum);

        }

        
    }
}
