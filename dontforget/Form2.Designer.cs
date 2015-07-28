namespace dontforget
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.smtp = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FROM";
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(98, 16);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(238, 20);
            this.from.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(15, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "SUBJECT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(15, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "MESSAGE";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(98, 55);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(238, 20);
            this.to.TabIndex = 6;
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(98, 176);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(238, 20);
            this.subject.TabIndex = 7;
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(15, 276);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(318, 192);
            this.message.TabIndex = 9;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(35, 476);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(111, 28);
            this.send.TabIndex = 10;
            this.send.Text = "SEND";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Type in your Accounts and passwords and send a mail.";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(196, 476);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(111, 28);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(15, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "SMTPclient";
            // 
            // smtp
            // 
            this.smtp.Location = new System.Drawing.Point(98, 217);
            this.smtp.Name = "smtp";
            this.smtp.Size = new System.Drawing.Size(238, 20);
            this.smtp.TabIndex = 18;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(98, 135);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(238, 20);
            this.password.TabIndex = 21;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(98, 96);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(238, 20);
            this.username.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(15, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "PASSWORD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(15, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "USERNAME";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(345, 516);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password);
            this.Controls.Add(this.smtp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.send);
            this.Controls.Add(this.message);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.to);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form2";
            this.Text = "SEND MAIL ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox smtp;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}