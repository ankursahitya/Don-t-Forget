using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;


namespace dontforget
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void send_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage(from.Text, to.Text, subject.Text, message.Text);
            SmtpClient client = new SmtpClient(smtp.Text);
            client.Port = 465;
            client.Credentials = new System.Net.NetworkCredential(username.Text,password.Text);
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("mail Sent", "SUCCESS", MessageBoxButtons.OK);


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
