using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcalcApp
{
    public partial class EcalcMain : Form
    {
        private easyEcalc.eVto eV;
        private easyEcalc.Hzto Hz;
        private easyEcalc.Lambdato lambda;
        private easyEcalc.Tto T;
        private easyEcalc.Jto J;
        private int defaultwidth,defaultheight;
      

        public EcalcMain()
        {
            InitializeComponent();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if ((keyData & Keys.KeyCode) == Keys.Enter)
            {
                if (easyEcalc1.eVtextBox.Focused)
                {
                    easyEcalc1.Disp(eV, easyEcalc1.eVtextBox.Text);
                }
                else if (easyEcalc1.HztextBox.Focused)
                {
                    easyEcalc1.Disp(Hz, easyEcalc1.HztextBox.Text);
                }
                else if (easyEcalc1.mtextBox.Focused)
                {
                    easyEcalc1.Disp(lambda, easyEcalc1.mtextBox.Text);
                }
                else if (easyEcalc1.TtextBox.Focused)
                {
                    easyEcalc1.Disp(T, easyEcalc1.TtextBox.Text);
                }
                else if (easyEcalc1.JtextBox.Focused)
                {
                    easyEcalc1.Disp(J, easyEcalc1.JtextBox.Text);
                }
                else
                {
                    return base.ProcessDialogKey(keyData);
                }
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void EcalcMain_Load(object sender, EventArgs e)
        {
            eV = new easyEcalc.eVto();
            Hz = new easyEcalc.Hzto();
            lambda = new easyEcalc.Lambdato();
            T = new easyEcalc.Tto();
            J = new easyEcalc.Jto();

            easyEcalc1.Disp(eV, 1.0.ToString());
            defaultwidth = this.Width;
            defaultheight = this.Height;
            vkinvisible();
        }

        private void vkvisible() {
            eVtobutton.Visible = true;
            ftobutton.Visible = true;
            lambdatobutton.Visible = true;
            Ttobutton.Visible = true;
            Jtobutton.Visible = true;
            numPad1.Visible = true;
            this.Width = defaultwidth;
        }
        private void vkinvisible() {
            eVtobutton.Visible = false;
            ftobutton.Visible = false;
            lambdatobutton.Visible = false;
            Ttobutton.Visible = false;
            Jtobutton.Visible = false;
            numPad1.Visible = false;
            this.Width = 350;

        }

        private void eVtobutton_Click(object sender, EventArgs e)
        {
            easyEcalc1.eVtextBox.Text = numPad1.kDisptextBox.Text;
            easyEcalc1.eVtextBox.Focus();
            SendKeys.Send("{Enter}");
            numPad1.kDisptextBox.Clear();

        }

        private void ftobutton_Click(object sender, EventArgs e)
        {
            easyEcalc1.HztextBox.Text = numPad1.kDisptextBox.Text;
            easyEcalc1.HztextBox.Focus();
            SendKeys.Send("{Enter}");
            numPad1.kDisptextBox.Clear();

        }

        private void lambdatobutton_Click(object sender, EventArgs e)
        {
            easyEcalc1.mtextBox.Text = numPad1.kDisptextBox.Text;
            easyEcalc1.mtextBox.Focus();
            SendKeys.Send("{Enter}");
            numPad1.kDisptextBox.Clear();
        }

        private void Ttobutton_Click(object sender, EventArgs e)
        {
            easyEcalc1.TtextBox.Text = numPad1.kDisptextBox.Text;
            easyEcalc1.TtextBox.Focus();
            SendKeys.Send("{Enter}");
            numPad1.kDisptextBox.Clear();

        }

        private void Jtobutton_Click(object sender, EventArgs e)
        {
            easyEcalc1.JtextBox.Text = numPad1.kDisptextBox.Text;
            easyEcalc1.JtextBox.Focus();
            SendKeys.Send("{Enter}");
            numPad1.kDisptextBox.Clear();

        }

        private void numPad1_Load(object sender, EventArgs e)
        {

        }

        private void VirualKeyboardcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (VirualKeyboardcheckBox.Checked)
            {
                vkvisible();
            }
            else {
                vkinvisible();
            }


        }
    }
}
