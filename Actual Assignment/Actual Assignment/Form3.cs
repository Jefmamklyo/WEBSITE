using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actual_Assignment
{

    
    public partial class Form3 : Form
    {
        
        public Label lblErrorpub => lblError;
        //Thism form is for the syntax not block code drag and drop
        
        public Form3()
        {
            InitializeComponent();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        /// <summary>
        /// Class with all methods used in the button below 
        /// </summary>
        /// 
    
        public class textmethods 
        {
            //initialising form 3 in this constructer
            public void bery()
            {
                if (btnprser >= 2)
                {             
                    Form1.formManage.f3.lblError.Text = "Try again";
                }
            }
            public void reset()
            {
                Form1.formManage.f3.tbWrite.Text = "";
                count++;
                Form1.formManage.f3.lblTextDisp.Text = Texts[count];
                btnprser = 0;
                Form1.formManage.f3.lblError.Text = "";
                
            }
            public bool ContainCheck(string x)
            {
                return Form1.formManage.f3.lblCode.Text.Contains(x);
            }
        }

        static public int count = 0;
        static public int btnprser = 0;
        static public string[] Texts = {
                                    
            //0
            "Write a integer variable called 'X' which holds the integer 5",
            //1
            "Great Job! Now write an string called HW that holds \n" +
            "the sentence 'Hello World'",
            //2
            "Nice! Now create a:" +
                "integer called x which holds the number 4,\n" +
                "A integer called y which holds the numebr 7,\n" +
                "Then write both of them printed together\n",
            //3
            "Nice youre done",
            };


        private void btnProceed_Click(object sender, EventArgs e)
        {

           //changing class name
           textmethods tm = new textmethods();
            //Array bounds checker
            if (count >= 0 && count < 4)
            {
                lblTextDisp.Text = Texts[count];
                btnprser++;

                if (count == 0 && tm.ContainCheck("int X = 5;"))
                {
  
                    tm.reset();

                }
                if (count == 1 && tm.ContainCheck("string HW = \"Hello World\";"))
                {

                    tm.reset();
                }
                if (count == 2 && tm.ContainCheck("int x = 4") && tm.ContainCheck("int y = 7") && tm.ContainCheck("Console.WriteLine(x+y)"))
                {
                    Form2.completionf3++;
                    tm.reset();
                    btnProceed.Visible = false;
                   
                }
                tm.bery();
            }
            //So the form does nothing when you are done
            else {}

        }
        private void btnF2_Click(object sender, EventArgs e)
        {
            count = 0;
            Form1.formManage.closeSwitch(this, Form1.formManage.f2);

        }
        private void lblError_Click(object sender, EventArgs e)
        {

        }
    }
}
