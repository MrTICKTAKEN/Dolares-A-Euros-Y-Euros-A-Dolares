using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolares_A_Euros_Y_Euros_A_Dolares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void CONVERbutton1_Click(object sender, EventArgs e)
        {
            double cambioDolarEuro = double.Parse(CAMBDOtextBox1.Text);
            double tipoCambioEuroDolar = 1 / cambioDolarEuro;
            double cantidad = double.Parse(CANTItextBox2.Text);
            double euro = ConvertirADolaresAEuros(cantidad, cambioDolarEuro);
            EUaDOlabel4.Text = cantidad + " doláres equivale a " + euro + "euros";
            double dolares = ConvertirAEurosADolares(cantidad, tipoCambioEuroDolar);
            DOaEUlabel5.Text = cantidad + " euros equivale a " + euro + "dolares";
        }
        private double ConvertirAEurosADolares(double cantidad, double tipoCambioEuroDolar)
        {
            return cantidad * tipoCambioEuroDolar;
        }

        private double ConvertirADolaresAEuros(double cantidad, double tipocambioDolarEuro)
        {
            return cantidad * tipocambioDolarEuro;
        }
    }
}
