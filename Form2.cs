using MyFirst_WindowsFormApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirst_WindowsFormApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShowPart1_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm1 = new MessageBoxForm3();
            frm1.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            /*
             if(checkBox1.Checked == true)
            {
                MessageBox.Show(checkBox1.Checked.ToString());
            }
            */
            MessageBox.Show(checkBox1.Checked.ToString());

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button3.Enabled = checkBox1.Checked;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Resources.PictureOnejpg;
            pictureBox1.Image = Resources.picture2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\photo.jpg");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox1.MaskFull)
            {
                pictureBox1.Image = Resources.picture2;
            }
            else
            {
                pictureBox1.Image = Resources.PictureOnejpg;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.google.com/");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 5; i++)
            {
                checkedListBox1.Items.Add("item" + i);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.RemoveAt(2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= checkedListBox1.CheckedItems.Count; i++)
            {
                MessageBox.Show(checkedListBox1.CheckedItems[i].ToString());
            }
        }
    }
}

