namespace Actual_Assignment
{
    partial class Form4
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
            this.btnf2 = new System.Windows.Forms.Button();
            this.lblop1 = new System.Windows.Forms.Label();
            this.lblop2 = new System.Windows.Forms.Label();
            this.lblop3 = new System.Windows.Forms.Label();
            this.tbAns = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.panBorder = new System.Windows.Forms.Panel();
            this.lblText3 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnf2
            // 
            this.btnf2.Location = new System.Drawing.Point(0, 1);
            this.btnf2.Name = "btnf2";
            this.btnf2.Size = new System.Drawing.Size(136, 71);
            this.btnf2.TabIndex = 0;
            this.btnf2.Text = "Form2  (placeholder)";
            this.btnf2.UseVisualStyleBackColor = true;
            this.btnf2.Click += new System.EventHandler(this.btnf2_Click);
            // 
            // lblop1
            // 
            this.lblop1.AutoSize = true;
            this.lblop1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblop1.Location = new System.Drawing.Point(27, 167);
            this.lblop1.Name = "lblop1";
            this.lblop1.Size = new System.Drawing.Size(0, 13);
            this.lblop1.TabIndex = 5;
            // 
            // lblop2
            // 
            this.lblop2.AutoSize = true;
            this.lblop2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblop2.Location = new System.Drawing.Point(27, 195);
            this.lblop2.Name = "lblop2";
            this.lblop2.Size = new System.Drawing.Size(0, 13);
            this.lblop2.TabIndex = 6;
            // 
            // lblop3
            // 
            this.lblop3.AutoSize = true;
            this.lblop3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblop3.Location = new System.Drawing.Point(27, 225);
            this.lblop3.Name = "lblop3";
            this.lblop3.Size = new System.Drawing.Size(0, 13);
            this.lblop3.TabIndex = 7;
            // 
            // tbAns
            // 
            this.tbAns.Location = new System.Drawing.Point(3, 107);
            this.tbAns.Name = "tbAns";
            this.tbAns.ReadOnly = true;
            this.tbAns.Size = new System.Drawing.Size(100, 20);
            this.tbAns.TabIndex = 8;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(243, 106);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "btnNext";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panBorder
            // 
            this.panBorder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panBorder.Controls.Add(this.tbAns);
            this.panBorder.Controls.Add(this.btnNext);
            this.panBorder.Controls.Add(this.lblText3);
            this.panBorder.Cursor = System.Windows.Forms.Cursors.Default;
            this.panBorder.Location = new System.Drawing.Point(117, 117);
            this.panBorder.Name = "panBorder";
            this.panBorder.Size = new System.Drawing.Size(319, 130);
            this.panBorder.TabIndex = 10;
            // 
            // lblText3
            // 
            this.lblText3.AutoSize = true;
            this.lblText3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblText3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblText3.Location = new System.Drawing.Point(-4, 0);
            this.lblText3.Name = "lblText3";
            this.lblText3.Size = new System.Drawing.Size(220, 26);
            this.lblText3.TabIndex = 9;
            this.lblText3.Text = "Hello this is your introduction to basics of c#, \r\n(Write eplaation);";
            this.lblText3.Click += new System.EventHandler(this.lblText3_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(395, 101);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 13);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "lblError";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(757, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 40);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblop3);
            this.Controls.Add(this.lblop2);
            this.Controls.Add(this.lblop1);
            this.Controls.Add(this.btnf2);
            this.Controls.Add(this.panBorder);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panBorder.ResumeLayout(false);
            this.panBorder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnf2;
        private System.Windows.Forms.Label lblop1;
        private System.Windows.Forms.Label lblop2;
        private System.Windows.Forms.Label lblop3;
        private System.Windows.Forms.TextBox tbAns;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panBorder;
        private System.Windows.Forms.Label lblText3;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnExit;
    }
}