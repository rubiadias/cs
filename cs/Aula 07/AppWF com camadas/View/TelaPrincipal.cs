using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppWF_com_camadas.View;
using AppWF_com_camadas.Model;

namespace AppWF_com_camadas
{
    public partial class TelaPrincipal : Form
    {
        public Aluno alunoSelecionado;
        List<Aluno> listaDeAlunos = new List<Aluno>();

        public TelaPrincipal()
        {
            InitializeComponent();
            ContextoDeDados db = new ContextoDeDados();
            listaDeAlunos = db.Alunos.ToList();
            grdView.DataSource = listaDeAlunos;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            TelaDeCadastro telaDeCadastro = new TelaDeCadastro();
            telaDeCadastro.TelaPrincipal = this;
            telaDeCadastro.Show();
        }

        public void AdicionarAluno(Aluno aluno)
        {
            alunoSelecionado = aluno;
            listaDeAlunos.Add(aluno);

            txtMatricula.Text = alunoSelecionado.Matricula;
            txtNome.Text = alunoSelecionado.Nome;
            txtMedia.Text = alunoSelecionado.GetMedia().ToString();

            grdView.DataSource = null;
            grdView.DataSource = listaDeAlunos;
        }

        private void grdView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            alunoSelecionado = (Aluno)grdView.Rows[e.RowIndex].DataBoundItem;
            txtMatricula.Text = alunoSelecionado.Matricula;
            txtNome.Text = alunoSelecionado.Nome;
            txtMedia.Text = alunoSelecionado.GetMedia().ToString();
        }
    }
}
