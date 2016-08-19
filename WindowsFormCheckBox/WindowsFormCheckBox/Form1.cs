using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void chkAceito_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAceito.Checked)
            {
                cmdGravar.Visible = true;
            }
            else
                cmdGravar.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"alsdkj lasdjf lakjsdf;l kajdsf ;lkajsdfl kjadsflk alsdkja sdlfkj asdlfkj a;sdlfkja;lsdkf j
asldfkj alsdjf lakjsdf lkajsdfl kjasdlfkj alsdkfj laksdjf lkajdsflk jasdf
aslkdfj alsdkjf lakjsdfl kjasdlfk jalsdkfj laksjdf lkajsdflk jalsdkfj a
dasldkfj alskdjfl aksjdfl kajsdlfk jalsdfkj alksjdf lkajsdfl 
alsdkfjlaksdjf lakjsdfl kajsdfl kjasdlf kjasdlfk jalsdkfj laksdjf 
asdlfk jalsdkfj laksdjf lkajsdfl kjasdlfkj alsdkjf 
alskdfj laksdjf lakjsdfl kjasdlfk jalsdkfj laksjdf ");

            txtAceito.Text = str.ToString();
        }

        
    }
}
