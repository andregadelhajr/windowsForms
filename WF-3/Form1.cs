using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriarPasta_Click(object sender, EventArgs e)
        {
            string pastaCriada = @"C:\" + txtCriarPasta.Text;
            if (!Directory.Exists(pastaCriada))
            {
                Directory.CreateDirectory(pastaCriada);
                MessageBox.Show("Pasta Criada com Sucesso!");
            }
            else
            {
                MessageBox.Show("Pasta já existente", "",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletaPasta_Click(object sender, EventArgs e)
        {
            string pastaDeletar = @"C:\" + txtDeletaPasta.Text;
            if (Directory.Exists(pastaDeletar))
            {
                Directory.Delete(pastaDeletar, true);
                MessageBox.Show("Pasta Deletada com Sucesso!");
            }
            else
            {
                MessageBox.Show("Pasta Não Existente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            string nomeArquivo = txtNomeArq.Text;
            string pastaOrigem = @"C:\" + txtArqOrigem.Text;
            string pastaDestino = @"C:\"+ txtArqOrigem.Text + @"\" + txtArqDestino.Text ;

            string arquivoOrigem = Path.Combine(pastaOrigem, nomeArquivo);
            string arquivoDestino = Path.Combine(pastaDestino, nomeArquivo);

            File.Move(arquivoOrigem, arquivoDestino);
            MessageBox.Show("Arquivo Movido!");
        }

        private void txtArqOrigem_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
