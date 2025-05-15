namespace Actual_Assignment
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tComp = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnF3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(760, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 27);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // tComp
            // 
            this.tComp.Location = new System.Drawing.Point(13, 69);
            this.tComp.Name = "tComp";
            this.tComp.Size = new System.Drawing.Size(75, 23);
            this.tComp.TabIndex = 1;
            this.tComp.Text = "Total Completion";
            this.tComp.UseVisualStyleBackColor = true;
            this.tComp.Click += new System.EventHandler(this.tComp_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(159, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "UserName";
            // 
            // btnF3
            // 
            this.btnF3.Location = new System.Drawing.Point(13, 278);
            this.btnF3.Name = "btnF3";
            this.btnF3.Size = new System.Drawing.Size(181, 75);
            this.btnF3.TabIndex = 4;
            this.btnF3.Text = "Form3 (placeholder)";
            this.btnF3.UseVisualStyleBackColor = true;
            this.btnF3.Click += new System.EventHandler(this.btnF3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnF3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tComp);
            this.Controls.Add(this.btnClose);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button tComp;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnF3;
    }
}