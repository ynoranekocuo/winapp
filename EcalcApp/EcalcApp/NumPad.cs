using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcalcApp
{
    public partial class NumPad : UserControl
    {
        public NumPad()
        {
            InitializeComponent();
        }

        private void k0_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false) {
                kDisptextBox.Focus();
            }
            SendKeys.Send("0");
        }

        private void k1_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false)
            {
                kDisptextBox.Focus();
            }
            SendKeys.Send("1");
        }

        private void k2_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false)
            {
                kDisptextBox.Focus();
            }
            SendKeys.Send("2");
        }

        private void k3_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false)
            {
                kDisptextBox.Focus();
            }
            SendKeys.Send("3");
        }

        private void k4_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false)
            {
                kDisptextBox.Focus();
            }
            SendKeys.Send("4");
        }

        private void k5_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false)
            {
                kDisptextBox.Focus();
            }
            SendKeys.Send("5");
        }

        private void k6_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false)
            {
                kDisptextBox.Focus();
            }
            SendKeys.Send("6");
        }

        private void k7_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false)
            {
                kDisptextBox.Focus();
            }
            SendKeys.Send("7");
        }

        private void k8_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false)
            {
                kDisptextBox.Focus();
            }
            SendKeys.Send("8");
        }

        private void k9_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false)
            {
                kDisptextBox.Focus();
            }
            SendKeys.Send("9");
        }

        private void km_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false)
            {
                kDisptextBox.Focus();
            }
            SendKeys.Send("-");
        }

        private void kexp_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false)
            {
                kDisptextBox.Focus();
            }
            SendKeys.Send("e");
        }

        private void kEnt_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false)
            {
                kDisptextBox.Focus();
            }
            SendKeys.Send("{Enter}");
        }

        private void klT_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false)
            {
                kDisptextBox.Focus();
            }
            SendKeys.Send("T");
        }

        private void klG_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false)
            {
                kDisptextBox.Focus();
            }
            SendKeys.Send("G");
        }

        private void klM_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false)
            {
                kDisptextBox.Focus();
            }
            SendKeys.Send("M");
        }

        private void ksk_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false)
            {
                kDisptextBox.Focus();
            }
            SendKeys.Send("k");
        }

        private void ksp_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false)
            {
                kDisptextBox.Focus();
            }
            SendKeys.Send("p");
        }

        private void ksn_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false)
            {
                kDisptextBox.Focus();
            }
            SendKeys.Send("n");
        }

        private void ksu_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false)
            {
                kDisptextBox.Focus();
            }
            SendKeys.Send("u");
        }

        private void ksm_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false)
            {
                kDisptextBox.Focus();
            }
            SendKeys.Send("m");
        }

        private void Kdot_button_Click(object sender, EventArgs e)
        {
            if (kDisptextBox.Focused == false)
            {
                kDisptextBox.Focus();
            }
            SendKeys.Send(".");

        }

        private void Kclr_button_Click(object sender, EventArgs e)
        {
            kDisptextBox.Clear();
        }
    }
}
