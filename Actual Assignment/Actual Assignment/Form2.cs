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
    public partial class Form2 : Form
    {
        //TotalCinpoletoin shower varibable
        static int tcomp;
        //UserName
        public Label lblU;
        public static Form2 f2;
        //OwnerShip
        Form3 f3 = new Form3();
     
        //new form creartion mehtod SHARE THIS WITH OTHER FORMS
        public Form Method(Form x)
        {
            x.StartPosition = FormStartPosition.Manual;
            x.Location = this.Location;
            this.Close();
            x.Show();
            return x;
        }

        public Form2()
        {
            InitializeComponent();
            f2 = this;
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
            Method(f3);
        }
    }
}
