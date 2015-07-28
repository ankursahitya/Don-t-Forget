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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                try
                {
                    string url = "http://smsc.vianett.no/v3/send.ashx?" +
                        "src="+txtphone.Text+"&" +
                        "dst="+ txtphone.Text + "&" +
                        "msg="+label4.Text+label5.Text+label6.Text+
                        "username="+txtuser.Text;
                    string result = client.DownloadString(url);
                    if (result.Contains("ök"))
                        MessageBox.Show("your message has been sent", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("message send failure", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      
    }
}
