using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Actual_Assignment
{
    public partial class Form4 : Form
    {
      
        public Form4()
            
        {
            InitializeComponent();

        
            //label event handelrs
            lblop1.MouseDown += label_MouseDown;
            lblop2.MouseDown += label_MouseDown;
            lblop3.MouseDown += label_MouseDown;

            //testbox drag drop and event handlers
            System.Windows.Forms.TextBox tb = new System.Windows.Forms.TextBox();
            tb = tbAns;
            tbAns.AllowDrop = true;
            tbAns.DragEnter += new DragEventHandler(tbAns_DragEnter);
            tbAns.DragDrop += new DragEventHandler(tbAns_DragDrop);
            this.Controls.Add(tbAns);

           
        }
        //Drag enterNumber
        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            label.DoDragDrop(label.Text, DragDropEffects.Copy);
            
        }

      
        private void tbAns_DragEnter(object sender, DragEventArgs e)
        {
            
          
                e.Effect = DragDropEffects.Copy;
          
           

        }
        private void tbAns_DragDrop(object sender, DragEventArgs e)
        {
            tbAns.Text = e.Data.GetData(DataFormats.Text).ToString();
        }


        //Button click method
       
        
       
        public class btnProceed
        {
            public void bery()
            {
                if (btnprser >= 2)
                {
                    Form1.formManage.f4.lblError.Text = "Try again";
                }
            }
            public void reset()
            {
                Form1.formManage.f4.tbAns.Clear(); 
                count++;
                Form1.formManage.f4.lblText3.Text = Texts[count];
                btnprser = 0;
                Form1.formManage.f4.lblError.Text = "";
                lblText();
            }
            public void lblText()
            {
                Form1.formManage.f4.lblop1.Text = lop1T[count];
                Form1.formManage.f4.lblop2.Text = lop2T[count];
                Form1.formManage.f4.lblop3.Text = lop3T[count];
            }
        }

        static public int count = 0;
        static public int btnprser = 0;
        static public string[] Texts =
        {
                                    
            //0
            "Which is the right button?\n A variable with the integer property holds any",
            //1
            "Great Job! \n What value does a Boolean hold? ",
            //2
            "Nice!\n You are trying to write someting, fill in the blanks:\n  Console.__________(\"Hello World\";)",
            //3
            "Nice!\n You are trying to take a user input, fill in the blanks:\n  Console._____________(\"Hello World\";)",
            //4
            "NICE YOURE DONE"

        };
        static public string[] lop1T = { "Charecter", "Number", "WriteLine","ReadLine","" };
        static public string[] lop2T = { "Number", "Sentence", "ReadLine", "WriteLine","" };
        static public string[] lop3T = {"True/False", "True/False", "PrintLine", "TakeInput" , "" };
        private void btnNext_Click(object sender, EventArgs e)
        {
           
            //Changing class name for ease of use
            btnProceed bp = new btnProceed();
            //Array inbound checker
            if (count >= 0 && count <= 4)
            {
                lblText3.Text = Texts[count];
                btnprser++;
                bp.lblText();
                if (count == 0 && tbAns.Text == "Number")
                {
                    bp.reset();
                }
                if (count == 1 && tbAns.Text == "True/False")
                {
                    bp.reset();
                }
                if (count == 2 && tbAns.Text == "WriteLine")
                {
                    bp.reset();
                }
                if (count == 3 && tbAns.Text == "ReadLine")
                {
                    Form2.completionf4++;
                        bp.reset();
                    this.btnNext.Visible = false;
                    
                }

                bp.bery();
            }
            //so the form does nothing when you are done
            else { }
        }
        private void btnf2_Click(object sender, EventArgs e)
        {

            count = 0;
            Form1.formManage.closeSwitch(this, Form1.formManage.f2);

        }

        private void lblText3_Click(object sender, EventArgs e)
        {

        }
    
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
