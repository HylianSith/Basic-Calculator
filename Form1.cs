using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstCalc
{
    public partial class frmFirstCalc : Form
    {
        private string lastNumber;
        private string mathOp;
        public frmFirstCalc()
        {
            InitializeComponent();
        }
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains('.'))
            {
                txtDisplay.Text = txtDisplay.Text + btnDecimal.Text;
            }
        }

        #region Helper Functions
        private void ZeroCheck()
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
        }

        private void FunctionZeroCheck()
        {
            txtDisplay.Tag = txtDisplay.Text;

            txtDisplay.Text = "0";
        }

        private void ClearEntry()
        {
            txtDisplay.Text = "0";
        }
        #endregion
       
        #region Number Button Click
        private void btnGeneric_Click(object sender, EventArgs e)
        {
            ZeroCheck();
            txtDisplay.Text += ((Button)sender).Text;
        }
        #endregion

        #region MathOp Buttons
        private void btnGenericMathOp_Click(object sender, EventArgs e)
        {
            FunctionZeroCheck();
            mathOp = ((Button)sender).Text;
        }
        #endregion

        #region Function Buttons
        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            ClearEntry();
        } //Clear Entry

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (mathOp)
            {
                case "+":
                    txtDisplay.Text = (Convert.ToDouble(txtDisplay.Tag) + Convert.ToDouble(txtDisplay.Text)).ToString();
                    break;

                case "-":
                    txtDisplay.Text = (Convert.ToDouble(txtDisplay.Tag) - Convert.ToDouble(txtDisplay.Text)).ToString();
                    break;

                case "*":
                    txtDisplay.Text = (Convert.ToDouble(txtDisplay.Tag) * Convert.ToDouble(txtDisplay.Text)).ToString();
                    break;

                case "/":
                    txtDisplay.Text = (Convert.ToDouble(txtDisplay.Tag) / Convert.ToDouble(txtDisplay.Text)).ToString();
                    break;

                default:
                    break;
            }

            txtDisplay.Tag = txtDisplay.Text;
        } //Equal

        private void btnClear_Click(object sender, EventArgs e)
        {
            FunctionZeroCheck();
        } //Clear
        #endregion
    }
}
