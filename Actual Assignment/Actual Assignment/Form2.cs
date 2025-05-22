using System;
using System.Windows.Forms;

namespace Actual_Assignment
{
    public partial class Form2 : Form
    {
        
        //TotalCinpoletoin shower varibable
        static int tcomp;
        //UserName
        public Label lblU;



        //new form creartion mehtod SHARE THIS WITH OTHER FORMS


        public Form2()
        {
            InitializeComponent();
            lblU = lblName;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tComp_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You've completed {tcomp}");
           
        }
        
        private void btnF3_Click(object sender, EventArgs e)
        {
            Form1.FormSwitcher.SwitchForm(this,Form1.FormSwitcher.f3);
        }
    }
}
