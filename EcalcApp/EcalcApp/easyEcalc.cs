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


namespace easyEcalc
{
    public partial class EasyEcalc : UserControl
    {
        private string[] powindex = { "Y","Z","E","P","T","G","M","k"," ",
            "m","u","n","p","f","a","z","y" };

        private string expchange(double num) {
            string buffer =null;
            double pownum = 1 * Math.Pow(10, 24);

            for(int i = 0; i < powindex.Length; ++i)
            {
                if (num >= pownum)
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


        public EasyEcalc()
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
                eVtextBox.Text = expchange(master.eV);
                HztextBox.Text = expchange(master.Hz);
                mtextBox.Text = expchange(master.lambda);
                if (master.T >= 100000) {
                    TtextBox.Text = master.T.ToString("e3");
                }
                else if (master.T >= 0.01)
                {
                    TtextBox.Text = master.T.ToString("f3");
                }
                else {
                    TtextBox.Text = master.T.ToString("e3");
                }

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
            Hz = eV * Phys.eV/Phys.h;
            lambda = Phys.c / Hz;
            T = eV * Phys.eV/Phys.kB;
            J = eV * Phys.eV;
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

            eV = Hz * Phys.h / Phys.eV;
            //  Hz = Hz;
            lambda = Phys.c/ Hz;
            T = Hz * Phys.h/Phys.kB;
            J = Hz * Phys.h;
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
            Hz = Phys.c / lambda;
            eV = Hz * Phys.h / Phys.eV;
            //  Hz = Hz;
            //lambda = Phys.c / Hz;
            T = Hz * Phys.h / Phys.kB;
            J = Hz * Phys.h;
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
            eV = T * Phys.kB / Phys.eV;
            Hz = T * Phys.kB / Phys.h;
            lambda = Phys.c / Hz;
            //T = T;
            J = T * Phys.kB;
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
            eV = J / Phys.eV;
            Hz = J / Phys.h;
            lambda = Phys.c / Hz;
            T = J / Phys.kB;
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

