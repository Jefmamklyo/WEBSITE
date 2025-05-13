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
        //Form2 variable
        public static Form2 f2;
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
            Form1.f1.NewForm(f2);

        }
    }
}
