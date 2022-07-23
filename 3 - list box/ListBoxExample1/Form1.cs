using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBoxExample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddToListBox_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.textBox1.Text))
            {
                if (!this.listBox1.Items.Contains(this.textBox1.Text))
                {
                    this.listBox1.Items.Add(this.textBox1.Text);
                }
                else
                    MessageBox.Show("Strings must be unique");
            }
            else
                MessageBox.Show("Empty string");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCopyFromListBox_Click(object sender, EventArgs e)
        {
            this.listBox2.Items.Clear();

            if(this.listBox1.Items.Count != 0)

            for (int i = 0; i < this.listBox1.Items.Count; i++)
          
                this.listBox2.Items.Add(this.listBox1.Items[i]);
            else
                MessageBox.Show("The first ListBox is empty");
         
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (this.listBox1.Items.Count != 0)
            {
                if (this.listBox1.SelectedItems != null)
                {
                    while (this.listBox1.SelectedItems.Count > 0)
                    {
                        this.listBox1.Items.Remove(this.listBox1.SelectedItems[0]);
                    }
                    //for (int i = 0; i < this.listBox1.SelectedItems.Count; i++)
                    //{
                    //    this.listBox1.Items.Remove(this.listBox1.SelectedItems[i]);
                           
                    //}
                }
            }
        }

    }
}
