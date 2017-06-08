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

        //Hipotenusa
        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);

            int b = Convert.ToInt32(textBox2.Text);

            double suma = Math.Pow(a, 2) + Math.Pow(b, 2);
            double hipotenusa = Math.Sqrt(suma);
            MessageBox.Show("la hipotenusa es: " + hipotenusa);
        }

        //Vocales
        private void button2_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            Boolean letraa = false;
            Boolean letrae = false;
            Boolean letrai = false;
            Boolean letrao = false;
            Boolean letrau = false;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i].Equals((char)97) || texto[i].Equals((char)65) || texto[i].Equals((char)160))
                {
                    letraa = true;
                }
                if (texto[i].Equals((char)101) || texto[i].Equals((char)69) || texto[i].Equals((char)130))
                {
                    letrae = true;
                }
                if (texto[i].Equals((char)105) || texto[i].Equals((char)73) || texto[i].Equals((char)161))
                {
                    letrai = true;
                }
                if (texto[i].Equals((char)111) || texto[i].Equals((char)79) || texto[i].Equals((char)162))
                {
                    letrao = true;
                }
                if (texto[i].Equals((char)117) || texto[i].Equals((char)85) || texto[i].Equals((char)163))
                {
                    letrau = true;
                }
                else
                {
                    continue;
                }
            }

            if (letraa == true)
            {
                if (letrae == true)
                {
                    if (letrai == true)
                    {
                        if (letrao == true)
                        {
                            if (letrau == true)
                            {
                                MessageBox.Show("La plabra " + texto + " SI CUMPLE");
                            }
                            else
                            {
                                MessageBox.Show("La plabra " + texto + " NO CUMPLE, falta la vocal u");
                            }
                        }
                        else
                        {
                            MessageBox.Show("La plabra " + texto + " NO CUMPLE, falta la vocal o");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La plabra " + texto + " NO CUMPLE, falta la vocal i");
                    }
                }
                else
                {
                    MessageBox.Show("La plabra " + texto + " NO CUMPLE, falta la vocal e");
                }
            }
            else
            {
                MessageBox.Show("La plabra " + texto + " NO CUMPLE, falta la vocal a");
            }

        }

        //Inversion de palabras
        private void button3_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            string y = textBox2.Text;
            string aux1 = "";
            string aux2 = "";
            for (int i = x.Length - 1; i >= 0; i--)
            {
                aux1 += x[i];

            }
            for (int i = y.Length - 1; i >= 0; i--)
            {
                aux2 += y[i];

            }
            MessageBox.Show("palabra invertida: " + aux1 + " " + aux2);
        }
    }
}
