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
    public partial class Form1 : Form
    {

        
        public Form1()
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
            if (textBox1.Text == "Ziemia" || textBox1.Text == "ziemia")
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
