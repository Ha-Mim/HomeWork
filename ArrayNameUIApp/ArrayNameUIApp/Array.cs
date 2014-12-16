using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayNameUIApp
{
    public partial class ArrayUI : Form
    {
        public ArrayUI()
        {
            InitializeComponent();
        }
        String[] names = new string [5];
        private int i = 0;

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(i<5)
             {
                names[i] = nameTextBox.Text;
                 i++;
                 totalNumberTextBox.Text = Convert.ToString(i);
                nameTextBox.Text = String.Empty;
                 

             }
            else if (i==5)
            {
                nameTextBox.Text = string.Empty;
                showListBox.Items.Clear();
                foreach (string name in names)
                {
                    showListBox.Items.Add(name);
                }
                MessageBox.Show("There are not enough memory");
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            showListBox.Items.Clear();
            foreach (string name in names)
            {
                showListBox.Items.Add(name);
            }
        }
    }
}
