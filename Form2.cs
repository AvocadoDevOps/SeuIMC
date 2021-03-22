using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SeuIMC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.Show();
            double imc, altura2, peso2, final2;
            peso2 = double.Parse(peso.Text);
            altura2 = double.Parse(altura.Text);
            imc = peso2 / (altura2 * altura2);
            final2 = imc * 10000;
            MessageBox.Show("Seu Imc eh: " + final2, "Resultado", MessageBoxButtons.OK);
            
        }

        private void peso_TextChanged(object sender, EventArgs e)
        {

        }

        private void final_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
