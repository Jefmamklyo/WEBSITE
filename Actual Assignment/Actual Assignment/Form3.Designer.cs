namespace Actual_Assignment
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnF2 = new System.Windows.Forms.Button();
            this.tbWrite = new System.Windows.Forms.TextBox();
            this.lblTextDisp = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(759, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 27);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnF2
            // 
            this.btnF2.Location = new System.Drawing.Point(1, 0);
            this.btnF2.Name = "btnF2";
            this.btnF2.Size = new System.Drawing.Size(123, 66);
            this.btnF2.TabIndex = 2;
            this.btnF2.Text = "Form2 PlaceHolder";
            this.btnF2.UseVisualStyleBackColor = true;
            this.btnF2.Click += new System.EventHandler(this.btnF2_Click);
            // 
            // tbWrite
            // 
            this.tbWrite.Location = new System.Drawing.Point(1, 108);
            this.tbWrite.Multiline = true;
            this.tbWrite.Name = "tbWrite";
            this.tbWrite.Size = new System.Drawing.Size(139, 36);
            this.tbWrite.TabIndex = 3;
            this.tbWrite.Text = " ";
            this.tbWrite.TextChanged += new System.EventHandler(this.tbWrite_TextChanged);
            // 
            // lblTextDisp
            // 
            this.lblTextDisp.AutoSize = true;
            this.lblTextDisp.Location = new System.Drawing.Point(154, 7);
            this.lblTextDisp.Name = "lblTextDisp";
            this.lblTextDisp.Size = new System.Drawing.Size(204, 26);
            this.lblTextDisp.TabIndex = 4;
            this.lblTextDisp.Text = "This is your introduction on syntax\r\n{finish this sentence about what syntax is}\r" +
    "\n";
            this.lblTextDisp.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(146, 111);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(42, 13);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "lblCode";
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(668, 414);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(75, 23);
            this.btnProceed.TabIndex = 6;
            this.btnProceed.Text = "button Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(-2, 147);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(38, 13);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "errorlbl";
            this.lblError.Click += new System.EventHandler(this.lblError_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 78);
            this.label1.TabIndex = 8;
            this.label1.Text = "This labael is here to tell you wha tto do\r\n\r\nMake another course For a drag and " +
    "drop thing basics\r\n\r\nMake aonther course fo rsyntax which teachees \r\nlike consol" +
    "e.write lien or read line\r\n";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblTextDisp);
            this.Controls.Add(this.tbWrite);
            this.Controls.Add(this.btnF2);
            this.Controls.Add(this.btnClose);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnF2;
        private System.Windows.Forms.TextBox tbWrite;
        private System.Windows.Forms.Label lblTextDisp;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label1;
    }
}