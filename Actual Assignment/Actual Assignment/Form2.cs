using System;
using System.Windows.Forms;

namespace Actual_Assignment
{
    public partial class Form2 : Form
    {

        //TotalCinpoletoin shower varibable
        public static int completionf4 = 0;
        public static int completionf3 = 0;
        //UserName
        public new Label lblU;



        public Form2()
        {
            InitializeComponent();
            Label lblName = new Label();
            lblU = lblName;


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnF3_Click(object sender, EventArgs e)
        {
            Form1.formManage.f3 = new Form3();
            Form1.formManage.SwitchForm(this, Form1.formManage.f3);
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnF4_Click(object sender, EventArgs e)
        {
            Form1.formManage.f4 = new Form4();
            Form1.formManage.SwitchForm(this, Form1.formManage.f4);
        }

        private void btnTcomp_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You've completed:\n " +
                $"Block code Test :{completionf4} times\n" +
                $"Syntax Test {completionf3} times");
        }
    }
}
