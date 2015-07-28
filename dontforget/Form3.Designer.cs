namespace dontforget
{
    partial class Form3
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
            this.TXTPASS = new System.Windows.Forms.TextBox();
            this.TXTUSR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CMDCANCEL = new System.Windows.Forms.Button();
            this.CMDLOGIN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTPASS
            // 
            this.TXTPASS.AcceptsReturn = true;
            this.TXTPASS.AcceptsTab = true;
            this.TXTPASS.Location = new System.Drawing.Point(246, 186);
            this.TXTPASS.Name = "TXTPASS";
            this.TXTPASS.PasswordChar = '*';
            this.TXTPASS.Size = new System.Drawing.Size(323, 20);
            this.TXTPASS.TabIndex = 11;
            // 
            // TXTUSR
            // 
            this.TXTUSR.Location = new System.Drawing.Point(246, 127);
            this.TXTUSR.Name = "TXTUSR";
            this.TXTUSR.Size = new System.Drawing.Size(323, 20);
            this.TXTUSR.TabIndex = 10;
            this.TXTUSR.TextChanged += new System.EventHandler(this.TXTUSR_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "PASSWORD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "USERNAME";
            // 
            // CMDCANCEL
            // 
            this.CMDCANCEL.Location = new System.Drawing.Point(453, 253);
            this.CMDCANCEL.Name = "CMDCANCEL";
            this.CMDCANCEL.Size = new System.Drawing.Size(104, 34);
            this.CMDCANCEL.TabIndex = 7;
            this.CMDCANCEL.Text = "CANCEL";
            this.CMDCANCEL.UseVisualStyleBackColor = true;
            this.CMDCANCEL.Click += new System.EventHandler(this.CMDCANCEL_Click);
            // 
            // CMDLOGIN
            // 
            this.CMDLOGIN.Location = new System.Drawing.Point(246, 253);
            this.CMDLOGIN.Name = "CMDLOGIN";
            this.CMDLOGIN.Size = new System.Drawing.Size(124, 34);
            this.CMDLOGIN.TabIndex = 6;
            this.CMDLOGIN.Text = "LOGIN";
            this.CMDLOGIN.UseCompatibleTextRendering = true;
            this.CMDLOGIN.UseVisualStyleBackColor = true;
            this.CMDLOGIN.Click += new System.EventHandler(this.CMDLOGIN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "DON\'T FORGET SIGN IN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "SEND ME DETAILS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTPASS);
            this.Controls.Add(this.TXTUSR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CMDCANCEL);
            this.Controls.Add(this.CMDLOGIN);
            this.Name = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTPASS;
        private System.Windows.Forms.TextBox TXTUSR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CMDCANCEL;
        private System.Windows.Forms.Button CMDLOGIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}