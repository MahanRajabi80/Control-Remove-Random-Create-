using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_12_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //--------------------------------------------------------------
        private void ClearForm_NotRemoveAllButton()
        {
            this.Controls.SetChildIndex(btnRemoveAll, 0);
            while (this.Controls.Count > 1)
                this.Controls[1].Dispose();
        }
        //--------------------------------------------------------------
        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            ClearForm_NotRemoveAllButton();
        }
        //--------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int ControlNumber = rand.Next(1, 8);// [1,8) = [1,7] = 7 ta control
            Control newControl = new Control();
            switch(ControlNumber)
            {
                case 1: 
                    newControl = new Label();
                    newControl.Text = "Label";
                    break;
                case 2:
                    newControl = new Button();
                    newControl.Text = "Button";
                    break;
                case 3:
                    newControl = new TextBox();
                    newControl.Text = "TextBox";
                    break;
                case 4:
                    newControl = new CheckBox();
                    newControl.Text = "CheckBox";
                    break;
                case 5:
                    newControl = new RadioButton();
                    newControl.Text = "RadioButton";
                    break;
                case 6:
                    newControl = new ListBox();
                    newControl.Text = "ListBox";
                    break;
                case 7:
                    newControl = new ComboBox();
                    newControl.Text = "ComboBox";
                    break;
            }
            newControl.Location = new Point(rand.Next(this.Width), rand.Next(this.Top));
            this.Controls.Add(newControl);
            ///////
            timer1.Interval = rand.Next(100, 1001);//[0.1,1] second;
        }
    }
}
