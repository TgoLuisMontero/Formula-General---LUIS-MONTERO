using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formula_General___LUIS_MONTERO
{
    public partial class Formula : Form
    {  
        //Objeto
        Clases.C_AplicarFormula formula = new Clases.C_AplicarFormula();
        Clases.C_Validaciones validar = new Clases.C_Validaciones();

        public Formula()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click_1(object sender, EventArgs e)
        {
            double a, b, c;
            if (!validar.validarNumero(edit_A.Text, out a))
            {
                MessageBox.Show("Error (A): Ingresa datos tipo numerico!");
                return;
            }

            if (!validar.validarNumero(edit_B.Text, out b))
            {
                MessageBox.Show("Error (B): Ingresa datos tipo numerico");
                return;
            }

            if (!validar.validarNumero(edit_c.Text, out c))
            {
                MessageBox.Show("Error (C): Ingresa datos tipo numerico");
                return;
            }

            //Validar que 'a' sea distinto de Cero (0)
            if (!validar.EsDistintoDeCero(a))
            {
                MessageBox.Show("Error (A): El valor de 'a' no puede ser cero (0).");
                return;
            }

            //Validar resultado de la raiz
            if (!validar.tieneRaizDeterminada(a, b, c))
            {
                MessageBox.Show("Resultado de la raiz no determinada");
                return;
            }
                
            //Busqueda de resultados para x1 y x2...
            double x1 = formula.CalcularX1(a, b, c);
            double x2 = formula.CalcularX2(a, b, c);

            //Visualizacion de resultados...
            txt_resultadoA.Text = x1.ToString();
            txt_resultadoB.Text = x2.ToString();    
        }
    }
}
