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
    public partial class MessageBoxForm3 : Form
    {
        public MessageBoxForm3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi , How are you ?");
        }

        private void btnshowMessagetitle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi , How are you ?","here is the title");
        }

        private void btnMTB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("user pressed ok");
            }
            else
            {
                MessageBox.Show("user pressed cancel");
            }
        }

        private void MTBI_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("user pressed ok");
            }
            else
            {
                MessageBox.Show("user pressed cancel");
            }
        }
    }
}
