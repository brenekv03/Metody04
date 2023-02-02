using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string  x = "1abc 25 abd gnmoine";
            int pocetCifer;
            int soucetLichychCifer;
            if(!ObsahujeCifru(x,out pocetCifer,out soucetLichychCifer))
            {
                MessageBox.Show("Řetězec neobsahuje cifry");
            }
            else
            {
                MessageBox.Show("Řetězec obsahuje cifry" + "\nSoučet lichych cifer: " + soucetLichychCifer + "\nPočet cifer: " + pocetCifer);
            }
        }
        static private bool ObsahujeCifru(string retezec, out int pocetCifer,out int soucetLichychCifer)
        {
            bool obsahujeCifru = false;
            pocetCifer = 0;
            soucetLichychCifer = 0;
            foreach(char x in retezec)
            {
                if(char.IsNumber(x))
                {
                    obsahujeCifru = true;
                    pocetCifer++;
                    int cifra = int.Parse(x.ToString());
                    if (cifra % 2 != 0) soucetLichychCifer += cifra;
                }
            }
            return obsahujeCifru;
        }
    }
}
