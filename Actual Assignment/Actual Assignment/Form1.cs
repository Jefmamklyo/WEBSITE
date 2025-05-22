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
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            TextBox textBox1 = new TextBox();
            
            tbU = tbUser;
            Form f1 = this;
        }


        //FormSwitch
        public static class FormSwitcher
        {
                public static Form1 f1;
                public static Form2 f2;
                public static Form3 f3;

                static FormSwitcher() // Initiliaes Forms
                {
                    f1 = new Form1();
                    f2 = new Form2();
                    f3 = new Form3();
                }

                public static void SwitchForm(Form currentForm, Form nextForm)
            {
                nextForm.StartPosition = FormStartPosition.Manual;
                nextForm.Location = currentForm.Location;

                nextForm.Show();
                currentForm.Hide();
            }
        }
        private void btnProc_Click(object sender, EventArgs e)
        {

            FormSwitcher.f2.lblU.Text = tbU.Text;
           

            if (textBox1.Text == "abcd")
            {
               FormSwitcher.SwitchForm(this,FormSwitcher.f2);
               
            }
            else
            {
                lblDisp.Text = "PassWord is Wrong" ;

            }
          
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
