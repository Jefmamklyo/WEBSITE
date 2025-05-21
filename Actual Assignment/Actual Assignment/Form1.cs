using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actual_Assignment
{
    public partial class Form1 : Form
    {
        
      
        


        //FormSwitch
        public static class formManage
        {
            public static Form1 f1;
            public static Form2 f2;
            public static Form3 f3;
            public static Form4 f4;

            static formManage() // Initiliaes Forms
            {
       
            }

            public static void SwitchForm(Form thisForm, Form switchForm)
            {
         
                switchForm.StartPosition = FormStartPosition.Manual;
                switchForm.Location = thisForm.Location;
                switchForm.Show();
                thisForm.Hide();
            }
            public static void closeSwitch(Form thisForm, Form switchForm)
            {
                switchForm.StartPosition = FormStartPosition.Manual;
                switchForm.Location = thisForm.Location;
                switchForm.Show();
                thisForm.Close();
            }
        }
        //
        //
        //
        //
        //
        Form2 f2 = new Form2();
       
        public Form1()
        {
            InitializeComponent();
            TextBox textBox1 = new TextBox();

        }

        
       
        private void btnProc_Click(object sender, EventArgs e)
        {
 

            if (textBox1.Text == "abcd")
            {
                formManage.f2 = new Form2();
                formManage.f2.lblName.Text = tbUser.Text;
                formManage.SwitchForm(this, formManage.f2);

            }
            else
            {
                lblDisp.Text = "PassWord is Wrong";

            }

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}