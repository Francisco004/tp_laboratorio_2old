using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            cmbOperador.Text = " ";
        }

        private void BtnCerrar_Clic(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero binario = new Numero(lblResultado.Text);

            lblResultado.Text = binario.DecimalBinario(lblResultado.Text);
        }

        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero binario = new Numero(lblResultado.Text);

            lblResultado.Text = binario.BinarioDecimal(lblResultado.Text);

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnOperar_Click(object sender, EventArgs e)
        {
            double prueba;
            string retorno;

            prueba = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);

            retorno = prueba.ToString();

            lblResultado.Text = retorno; 
        }

        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.lblResultado.Text = null;
            this.cmbOperador.Text = " ";
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero n1 = new Numero(numero1);
            Numero n2 = new Numero(numero2);

            return   Entidades.Calculadora.Operar(n1, n2, operador);
        }
        
    }
}
