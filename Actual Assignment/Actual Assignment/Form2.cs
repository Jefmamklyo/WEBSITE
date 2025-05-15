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
        //OwnerShip//FormVariables
        Form3 f3 = new Form3();       
        public static Form2 f2;


        //new form creartion mehtod SHARE THIS WITH OTHER FORMS


        public Form2()
        {
            InitializeComponent();
            f2 = this;
            lblU = lblName;
            f3.Owner = this;
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
            f3.StartPosition = FormStartPosition.Manual;
            f3.Location = this.Location;
            f3.Show();
            this.Hide();
        }
    }
}
