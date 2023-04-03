using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
        }

        private int testResults()
        {
            int wynik = 0;


            if (Button4.Checked)
            {
                wynik++;
            }
            if (Buttonłyba.Checked)
            {
                wynik++;
            }
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                wynik++;
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
                {
                    wynik--;
                }

            }
            if ((textBox1.Text.ToLower().Trim() == "ziemia") || (textBox1.Text.ToLower().Trim() == "earth"))
            {
                wynik++;
            }



            return wynik;
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Ilosc prawidłowych: " + testResults());
        }

       
    }
}