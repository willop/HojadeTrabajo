using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1IPC2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);

            int b = Convert.ToInt32(textBox2.Text);

            double suma = Math.Pow(a, 2) + Math.Pow(b, 2);
            double hipotenusa = Math.Sqrt(suma);
            MessageBox.Show("la hipotenusa es: " + hipotenusa);
        }
    }
}
