using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class easyEcalc : UserControl
    {
        private string[] powindex = { "Y","Z","E","P","T","G","M","k"," ",
            "m","u","n","p","f","a","z","y" };

        private string expchange(double num) {
            string buffer =null;
            double pownum = 1 * Math.Pow(10, 24);

            for(int i = 0; i < powindex.Length; ++i)
            {
                if (num > pownum)
                {
                    num /= pownum;
                    buffer = num.ToString("f2") +"  "+ powindex[i];                    
                    break;
                }
                else {
                    pownum /= 1000;
                }
            }
            return buffer;
        }


        public easyEcalc()
        {
            InitializeComponent();
        }

        private void easyEcalc_Load(object sender, EventArgs e)
        {

        }
        public void Disp(calcmaster master,string text) {

            Regex re = new Regex(@"[^-+0-9eE\.]");
            string buffer = re.Replace(text, "");
            double tempnum;
            if (double.TryParse(buffer, out tempnum))
            {
                for (int i = 0; i < text.Length; ++i)
                {
                    double pownum = 1 * Math.Pow(10, 24);
                    for (int j = 0; j < powindex.Length; ++j)
                    {
                        if (text[i] == powindex[j][0])
                        {
                            tempnum *= pownum;
                            if (powindex[j][0] != ' ')
                            {
                                break;
                            }
                        }
                        pownum /= 1000;
                    }
                }
                // display
                tempnum = Math.Abs(tempnum);

                master.SetData(tempnum);
                eVtextBox.Text = master.eV.ToString("f3");
                HztextBox.Text = expchange(master.Hz);
                mtextBox.Text = expchange(master.lambda);
                TtextBox.Text = master.T.ToString("f3");
                JtextBox.Text = master.J.ToString("e3");
            }
            else {
                eVtextBox.Text = "Error(invalid)";
                HztextBox.Text = "Error(invalid)";
                mtextBox.Text = "Error(invalid)";
                TtextBox.Text = "Error(invalid)";
                JtextBox.Text = "Error(invalid)";

            }



        }

    }

    public class calcmaster
    {
        double eVdata;
        double Hzdata;
        double lambdadata;
        double Tdata;
        double Jdata;

        public double eV
        {
            set { this.eVdata = value; }
            get { return this.eVdata; }
        }

        public double Hz
        {
            set { this.Hzdata = value; }
            get { return this.Hzdata; }
        }

        public double lambda
        {
            set { this.lambdadata = value; }
            get { return this.lambdadata; }
        }
        public double T
        {
            set { this.Tdata = value; }
            get { return this.Tdata; }
        }

        public double J
        {
            set { this.Jdata = value; }
            get { return this.Jdata; }
        }

        public calcmaster()
        {
            SetData(1);
        }

        public calcmaster(double data)
        {
            SetData(data);
        }

        public virtual void SetData(double data) { }
        protected virtual void calc() { }

    }

    public class eVto : calcmaster
    {
        protected override void calc()
        {
            //eV = eV;
            Hz = eV * 2.41799 * Math.Pow(10, 14);
            lambda = 2.99792458 * Math.Pow(10, 8) / Hz;
            T = eV * 1.16045 * Math.Pow(10, 4);
            J = eV * 3.82742 * Math.Pow(10, -20);
        }
        public eVto()
        {
        }
        public eVto(double data) : base(data)
        {
        }
        public override void SetData(double data)
        {
            this.eV = data;
            calc();
        }
    }

    public class Hzto : calcmaster
    {
        protected override void calc()
        {
            eV = Hz * 4.13567 * Math.Pow(10, -15);
            //  Hz = Hz;
            lambda = 2.99792458 * Math.Pow(10, 8) / Hz;
            T = Hz * 4.79924 * Math.Pow(10, -11);
            J = Hz * 6.62607 * Math.Pow(10, -34);
        }
        public Hzto()
        {
        }
        public Hzto(double data) : base(data)
        {
        }
        public override void SetData(double data)
        {
            this.Hz = data;
            calc();
        }
    }

    public class Lambdato : calcmaster
    {
        protected override void calc()
        {
            Hz = 2.99792458 * Math.Pow(10, 8) / lambda;
            eV = Hz * 4.13567 * Math.Pow(10, -15);
            Hz = Hz;
            //lambda = lambda;
            T = Hz * 4.79924 * Math.Pow(10, -11);
            J = Hz * 6.62607 * Math.Pow(10, -34);
        }
        public Lambdato()
        {
        }
        public Lambdato(double data) : base(data)
        {
        }
        public override void SetData(double data)
        {
            this.lambda = data;
            calc();
        }
    }

    public class Tto : calcmaster
    {
        protected override void calc()
        {
            eV = T * 8.61734 * Math.Pow(10, -5);
            Hz = T * 2.08366 * Math.Pow(10, 10);
            lambda = 2.99792458 * Math.Pow(10, 8) / Hz;
            //T = T;
            J = T * 1.38065 * Math.Pow(10, -23);
        }
        public Tto()
        {
        }
        public Tto(double data) : base(data)
        {
        }
        public override void SetData(double data)
        {
            this.T = data;
            calc();
        }
    }

    public class Jto : calcmaster
    {
        protected override void calc()
        {
            eV = J * 6.24151 * Math.Pow(10, 18);
            Hz = J * 1.50919 * Math.Pow(10, 33);
            lambda = 2.99792458 * Math.Pow(10, 8) / Hz;
            T = J * 7.24296 * Math.Pow(10, 22);
            //J = J;
        }
        public Jto()
        {
        }
        public Jto(double data) : base(data)
        {
        }
        public override void SetData(double data)
        {
            this.J = data;
            calc();
        }
    }

}

