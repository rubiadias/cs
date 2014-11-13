using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_01_WF
{
    public partial class Form1 : Form
    {
        string mensagem;

        public Form1()
        {
            InitializeComponent();
            mensagem = lblMedia.Text;
        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(txtNota1.Text);
            double nota2 = double.Parse(txtNota2.Text);
            double nota3 = double.Parse(txtNota3.Text);

            double totalDasNotas = nota1 + nota2 + nota3;
            double media = Math.Round(totalDasNotas / 3, 2);

            lblMedia.Text = mensagem + media.ToString();
        }
    }
}
