using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actual_Assignment
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            Form1.FormSwitcher.SwitchForm(this, Form1.FormSwitcher.f2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbWrite_TextChanged(object sender, EventArgs e)
        {
            string[] lbltextcode = tbWrite.Text.Split('\n');
            int count = 1;
            lblCode.Text = "";

            foreach (string text in lbltextcode)
            {
                lblCode.Text = string.Format("{0}{1}  {2} \n", lblCode.Text, count, text);
                count++;
            }

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            int count = 0;


          






        }
    }
}
