using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dontforget
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void CMDCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CMDLOGIN_Click(object sender, EventArgs e)
        {
            if (TXTUSR.Text == "")
            {
                MessageBox.Show("Enter USERNAME");
            }
            else if (TXTPASS.Text == "")
            {
                MessageBox.Show("ënter PASSWORD");
            }
            else
            {
                if(TXTUSR.Text=="ädmin")
                {
                    if (TXTPASS.Text == "ädmin")
                    {
                        this.Close();
                        
                    }
                }
                Form2 f2 = new Form2();
                f2.Show();
            }
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void TXTUSR_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            

        }
    }
}
