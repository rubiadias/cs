using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppWF_com_camadas.Model;

namespace AppWF_com_camadas.View
{
    public partial class TelaDeCadastro : Form
    {
        public TelaPrincipal TelaPrincipal { get; set; }

        public TelaDeCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.Matricula = txtMatricula.Text;
            aluno.Nome = txtNome.Text;

            Prova prova1 = new Prova();
            prova1.Nota = double.Parse(txtNota1.Text);

            Prova prova2 = new Prova();
            prova2.Nota = double.Parse(txtNota2.Text);

            Prova prova3 = new Prova();
            prova3.Nota = double.Parse(txtNota3.Text);

            aluno.Provas.Add(prova1);
            aluno.Provas.Add(prova2);
            aluno.Provas.Add(prova3);

            ContextoDeDados db = new ContextoDeDados();
            db.Alunos.Add(aluno);
            db.SaveChanges();

            TelaPrincipal.AdicionarAluno(aluno);

            this.Close();

        }
    }
}
