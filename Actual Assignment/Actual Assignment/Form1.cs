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
        Form2 f2 = new Form2();
        public static Form1 f1;
        public Form1()
        {
            InitializeComponent();
            TextBox textBox1 = new TextBox();
            f2.Owner = this;
            tbU = tbUser;
            f1 = this;
        }

        //new form creartion mehtod SHARE THIS WITH OTHER FORMS
        public Form NewForm(Form x)
        {
            x.StartPosition = FormStartPosition.Manual;
            x.Location = this.Location;
            this.Close();
            x.Show();
            return x;

        }

 
        private void btnProc_Click(object sender, EventArgs e)
        {
            //UserName
            Form2.f2.lblU.Text = tbU.Text;

            if (textBox1.Text == "abcd")
            {
                f2.Show();
                this.Hide();
                

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
