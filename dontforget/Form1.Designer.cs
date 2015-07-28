namespace dontforget
{
    partial class Form1
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
            this.ANYTHING = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "DON\'T FORGET";
            // 
            // ANYTHING
            // 
            this.ANYTHING.AutoSize = true;
            this.ANYTHING.BackColor = System.Drawing.Color.Red;
            this.ANYTHING.Font = new System.Drawing.Font("Segoe Script", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANYTHING.Location = new System.Drawing.Point(175, 185);
            this.ANYTHING.Name = "ANYTHING";
            this.ANYTHING.Size = new System.Drawing.Size(425, 106);
            this.ANYTHING.TabIndex = 1;
            this.ANYTHING.Text = "ANYTHING";
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.SystemColors.Highlight;
            this.enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.enter.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(251, 334);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(257, 113);
            this.enter.TabIndex = 2;
            this.enter.Text = "ENTER";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(809, 507);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.ANYTHING);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ANYTHING;
        private System.Windows.Forms.Button enter;
    }
}

