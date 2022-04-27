using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtValor2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtValor1.Text);
            double b = double.Parse(txtValor2.Text);
            double soma = a + b;

            MessageBox.Show($"A Soma é: {soma}");
        }

        private void btnSubtr_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtValor1.Text);
            double b = double.Parse(txtValor2.Text);
            double subtr = a - b;

            MessageBox.Show($"O resultado da Subtração é: {subtr}");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtValor1.Text);
            double b = double.Parse(txtValor2.Text);
            double mult = a * b;

            MessageBox.Show($"O resultado da Multiplicação é: {mult}");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtValor1.Text);
            double b = double.Parse(txtValor2.Text);
            double div = a / b;

            MessageBox.Show($"O resultado da divisão é: {div}");
        }
    }
}
