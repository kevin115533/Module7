using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Kevin Tran
 * ITD 1253
 * Due Date: Oct 22
 */

namespace Module6MethodsProjectDL
{
    public partial class frmCatchersMitt : Form
    {
        // Public Contsants to use
        const byte ADD = 0;
        const byte SUBTRACT = 1;
        const byte MULTIPLY = 2;
        const byte DIVIDE = 3;
        const byte MODULUS = 4;

        public frmCatchersMitt()
        {
            InitializeComponent();
        }

        //Put Your method here

        private void btnModulus_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = txtLeft.Text;
            szRight = txtRight.Text;

            try
            {
                dLeft = Convert.ToDecimal(szLeft);
                dRight = Convert.ToDecimal(szRight);
            }
            catch (System.FormatException) {}
            if (!Decimal.TryParse(txtLeft.Text, out dLeft) || !Decimal.TryParse(txtRight.Text, out dRight))
            {
                lblAnswer.Text = "Error, please use numeric value";
                if (szLeft == "" || szRight == "")
                {
                    lblAnswer.Text = lblAnswer.Text + "Error, operand values are blank";
                }
            }
            else if (dLeft < 0.0m || dRight < 0.0m)
            {
                lblAnswer.Text = "Negatives can't be used with Modulus";
            }
            
            else
            {
                dAnswer = dLeft % dRight;
                szAnswer = dAnswer.ToString();
                szEquation = szLeft + " % " + szRight + " = " + szAnswer;
                lblAnswer.Text = "";
                lblAnswer.Text = szEquation;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = txtLeft.Text;
            szRight = txtRight.Text;

            try
            {
                dLeft = Convert.ToDecimal(szLeft);
                dRight = Convert.ToDecimal(szRight);
            }
            catch (System.FormatException){}
            if (!Decimal.TryParse(txtLeft.Text, out dLeft) || !Decimal.TryParse(txtRight.Text, out dRight))
            {
                lblAnswer.Text = "Error, please use numeric value";
                if (szLeft == "" || szRight == "")
                {
                    lblAnswer.Text = lblAnswer.Text + "Error, operand values are blank";
                }
            }

            else if (dRight == 0.0m)
            {
                lblAnswer.Text = "You can not divide by 0";
            }
            else
            {
                dAnswer = dLeft / dRight;
                szAnswer = dAnswer.ToString();
                szEquation = szLeft + " / " + szRight + " = " + szAnswer;
                lblAnswer.Text = "";
                lblAnswer.Text = szEquation;
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = txtLeft.Text;
            szRight = txtRight.Text;

            try
            {
                dLeft = Convert.ToDecimal(szLeft);
                dRight = Convert.ToDecimal(szRight);
            }
            catch (System.FormatException){ }
            if (!Decimal.TryParse(txtLeft.Text, out dLeft) || !Decimal.TryParse(txtRight.Text, out dRight))
            {
                lblAnswer.Text = "Error, please use numeric value";
                if (szLeft == "" || szRight == "")
                {
                    lblAnswer.Text = lblAnswer.Text + "Error, operand values are blank";
                }
            }

            else
            {
                dAnswer = dLeft * dRight;
                szAnswer = dAnswer.ToString();
                szEquation = szLeft + " * " + szRight + " = " + szAnswer;
                lblAnswer.Text = "";
                lblAnswer.Text = szEquation;
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = txtLeft.Text;
            szRight = txtRight.Text;

            try
            {
                dLeft = Convert.ToDecimal(szLeft);
                dRight = Convert.ToDecimal(szRight);
            }
            catch (System.FormatException){}
            if (!Decimal.TryParse(txtLeft.Text, out dLeft) || !Decimal.TryParse(txtRight.Text, out dRight))
            {
                lblAnswer.Text = "Error, please use numeric value";
                if (szLeft == "" || szRight == "")
                {
                    lblAnswer.Text = lblAnswer.Text + "Error, operand values are blank";
                }
            }

            else
            {
                dAnswer = dLeft - dRight;
                szAnswer = dAnswer.ToString();
                szEquation = szLeft + " - " + szRight + " = " + szAnswer;
                lblAnswer.Text = "";
                lblAnswer.Text = szEquation;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = txtLeft.Text;
            szRight = txtRight.Text;

            try
            {
                dLeft = Convert.ToDecimal(szLeft);
                dRight = Convert.ToDecimal(szRight);
            }
            catch (System.FormatException) {
               
            }
            if(!Decimal.TryParse(txtLeft.Text, out dLeft) || !Decimal.TryParse(txtRight.Text, out dRight))
            {
                lblAnswer.Text = "Error, please use numeric value";
                if (szLeft == "" || szRight == "")
                {
                    lblAnswer.Text = lblAnswer.Text + "Error, operand values are blank";
                }
            }
            
            else
            {
                dAnswer = dLeft + dRight;
                szAnswer = dAnswer.ToString();
                szEquation = szLeft + " + " + szRight + " = " + szAnswer;
                lblAnswer.Text = "";
                lblAnswer.Text = szEquation;
            }
        }
        
        private void frmCatchersMitt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
