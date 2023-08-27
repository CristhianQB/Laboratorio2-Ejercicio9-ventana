using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio2_Ejercicio9_ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtb1.Text);
            int num2 = int.Parse(txtb2.Text);
            int num3 = int.Parse(txtb3.Text);

            if (num1 > num2 && num1 > num3)
            {
                lbl.Text = num1.ToString();
            }
            else if (num2 > num1 && num2 > num3)
            {
                lbl.Text = num2.ToString();
            }
            else lbl.Text = num3.ToString();

        }
    }
}
