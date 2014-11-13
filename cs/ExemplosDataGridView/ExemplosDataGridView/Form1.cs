using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemplosDataGridView
{
    public partial class Form1 : Form
    {
        List<Produto> produtos;
        public Form1()
        {
            InitializeComponent();
            produtos = new List<Produto>();
            produtos.Add(new Produto(1, "Produto 1", 999.99, true, DateTime.Now));
            produtos.Add(new Produto(2, "Produto 2", 2000, false, DateTime.Now));
            produtos.Add(new Produto(3, "Produto 3", 3000, true, DateTime.Now));
            produtos.Add(new Produto(4, "Produto 4", 4000, false, DateTime.Now));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Produto produto = (Produto)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                //MessageBox.Show("Produto: " + produto.Descricao);
            }
            catch (Exception)
            {
                MessageBox.Show("Não conseguiu obter o Produto!");
            }
            
        }


        public class Produto
        {
            public int Id { get; set; }
            public string Descricao { get; set; }
            public double Preco { get; set; }
            public bool IsAtivo { get; set; }
            public DateTime DataCadastro { get; set; }

            public Produto(int Id, string Descricao, double Preco, bool IsAtivo, DateTime DataCadastro)
            {
                this.Id = Id;
                this.Descricao = Descricao;
                this.Preco = Preco;
                this.IsAtivo = IsAtivo;
                this.DataCadastro = DataCadastro;
            }
        }

        public void PopularGrid()
        {   
            //Limpa a grid.
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;

            //Popula os dados.
            dataGridView1.DataSource = produtos;
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            PopularGrid();

            //Criar os botões.
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Ação";
            btn.Text = "Editar";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
        }

        private void btnChecks_Click(object sender, EventArgs e)
        {
            PopularGrid();

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dataGridView1.Columns.Add(chk);
            chk.HeaderText = "CheckBoxes";
            chk.Name = "chk";
            dataGridView1.Rows[2].Cells[3].Value = true;
        }

        private void btnComboBoxes_Click(object sender, EventArgs e)
        {
            PopularGrid();

            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "ComboBoxes";
            cmb.Name = "cmb";
            cmb.MaxDropDownItems = 4;
            cmb.Items.Add("True");
            cmb.Items.Add("False");
            dataGridView1.Columns.Add(cmb);
        }
    }
}
