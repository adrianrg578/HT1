using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void hipotenusa() {
            double cateto1 = Convert.ToDouble(textBox1.Text);
            double cateto2 = Convert.ToDouble(textBox2.Text);
            double resultado = 0;

            resultado = Math.Sqrt(Math.Pow(cateto1,2)+Math.Pow(cateto2,2));

            label4.Text = "La hipotenusa es: " +Convert.ToString(resultado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hipotenusa();
        }
    }
}
