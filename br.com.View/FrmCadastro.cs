using PdvVendas.br.com.Dao;
using PdvVendas.br.com.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdvVendas.br.com.Cadastro
{
    public partial class FrmCadastro : Form
    {

        private bool eNovo;
        private bool eEditar;

        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void FormatarDataGridView()
        {
            dataListaFuncionarios.Columns[0].HeaderText = "Nº";
            dataListaFuncionarios.Columns[1].HeaderText = "NOME";
            dataListaFuncionarios.Columns[2].HeaderText = "ENDEREÇO";
            dataListaFuncionarios.Columns[3].HeaderText = "TELEFONE";
            dataListaFuncionarios.Columns[4].HeaderText = "CPF";
            dataListaFuncionarios.Columns[5].HeaderText = "CARGO";
            dataListaFuncionarios.Columns[0].Width = 30;
            dataListaFuncionarios.Columns[5].Width = 70;
        }

        public void Limpar()
        {
            this.lblId.Text = string.Empty;
            this.txtNome.Text = string.Empty;
            this.txtEndereco.Text = string.Empty;
            this.mcstxtCpf.Text = string.Empty;
            this.mcstxtTelefone.Text = string.Empty;
            this.cbCargo.Text = string.Empty;
            this.txtNome.Focus();           
        }      

        public void Habilitar(bool valor)
        {
            this.txtNome.ReadOnly = !valor;
            this.txtEndereco.ReadOnly = !valor;
            this.mcstxtCpf.ReadOnly = !valor;
            this.mcstxtTelefone.ReadOnly = !valor;
            this.cbCargo.Enabled = !false;
        } 
        


        private void FrmCadastro_Load(object sender, EventArgs e)
        {           
            this.Habilitar(false);
           

            Fornecedores obj = new Fornecedores();
            FuncionariosDao dao = new FuncionariosDao();
            this.dataListaFuncionarios.DataSource = dao.MostrarFuncionarios();
            this.dataListaFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataListaFuncionarios.DefaultCellStyle.Font = new Font("Century", 8);
            this.dataListaFuncionarios.DefaultCellStyle.ForeColor = Color.White;
            this.dataListaFuncionarios.AlternatingRowsDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            this.dataListaFuncionarios.DefaultCellStyle.BackColor = Color.Tan;
            this.dataListaFuncionarios.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;
            this.dataListaFuncionarios.DefaultCellStyle.SelectionForeColor = Color.Blue;
            this.dataListaFuncionarios.DefaultCellStyle.SelectionBackColor = Color.PaleGreen;
            this.FormatarDataGridView();           
            this.cbCargo.Enabled = false;
        }       

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == string.Empty || txtEndereco.Text == string.Empty ||
               mcstxtTelefone.Text == string.Empty || mcstxtCpf.Text == string.Empty || cbCargo.Text == string.Empty)
                {
                    MessageBox.Show("Preencha todos os campos para Salvar");
                   
                }
                else
                {
                    if (this.eNovo)
                    {
                        Fornecedores obj = new Fornecedores();
                        obj.Nome = txtNome.Text;
                        obj.Endereco = txtEndereco.Text;
                        obj.Telefone = mcstxtTelefone.Text;
                        obj.Cpf = mcstxtCpf.Text;
                        obj.Cargo = cbCargo.Text;

                        FuncionariosDao fdao = new FuncionariosDao();
                        fdao.CadastrarFuncionarios(obj);                       
                    }
                    else
                    {
                        this.eNovo = false;
                        this.eEditar = true;
                        Fornecedores obj = new Fornecedores();
                        obj.Nome = txtNome.Text;
                        obj.Endereco = txtEndereco.Text;
                        obj.Telefone = mcstxtTelefone.Text;
                        obj.Cpf = mcstxtCpf.Text;
                        obj.Cargo = cbCargo.Text;
                        obj.Id = int.Parse(lblId.Text);

                        FuncionariosDao fdao = new FuncionariosDao();
                        fdao.EditarFuncionarios(obj);

                    }
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um Erro ao Salvar: " + erro);
            }
           

            FuncionariosDao dao = new FuncionariosDao();
            dataListaFuncionarios.DataSource = dao.MostrarFuncionarios();
            this.btnNovo.Enabled = true;
            this.btnSalvar.Enabled = true;
            this.btnLimpar.Enabled = true;
            this.Limpar();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty || txtEndereco.Text == string.Empty ||
                mcstxtTelefone.Text == string.Empty || mcstxtCpf.Text == string.Empty || cbCargo.Text == string.Empty)
            {
                this.eNovo = true;
                this.eEditar = false;
                this.btnEditar.Enabled = false;
                
                this.btnLimpar.Enabled = true;
                this.pictFoto.Image = global::PdvVendas.Properties.Resources.noImage;
                this.txtNome.Focus();
              
                this.Habilitar(true);
            }
            else
            {
                MessageBox.Show("Limpe os campos para Cadastrar Novo: ");
            }         
                      
        }

      
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != string.Empty || txtEndereco.Text != string.Empty ||
                 mcstxtTelefone.Text != string.Empty || mcstxtCpf.Text != string.Empty || cbCargo.Text != string.Empty)
            {
                this.Limpar();

                this.Habilitar(false);
            }
            else
            {
                MessageBox.Show("Nao há campos para Limpar: ");
              
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show("Deseja realmente excluir o resgitro! ", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                if (txtNome.Text == string.Empty || txtEndereco.Text == string.Empty ||
               mcstxtTelefone.Text == string.Empty || mcstxtCpf.Text == string.Empty || cbCargo.Text == string.Empty)
                {
                    MessageBox.Show("Selecione um Campo");
                }
                else
                {
                    Fornecedores obj = new Fornecedores();

                    obj.Id = int.Parse(lblId.Text);

                    FuncionariosDao dao = new FuncionariosDao();
                    dao.ExcluirFuncionarios(obj);
                    dataListaFuncionarios.DataSource = dao.MostrarFuncionarios();
                    this.Limpar();
                }
            }
        }

        private void dataListaFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnEditar.Enabled = true;
                   
            lblId.Text = dataListaFuncionarios.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dataListaFuncionarios.CurrentRow.Cells[1].Value.ToString();
            txtEndereco.Text = dataListaFuncionarios.CurrentRow.Cells[2].Value.ToString();
            mcstxtTelefone.Text = dataListaFuncionarios.CurrentRow.Cells[3].Value.ToString();
            mcstxtCpf.Text = dataListaFuncionarios.CurrentRow.Cells[4].Value.ToString();
            cbCargo.Text = dataListaFuncionarios.CurrentRow.Cells[5].Value.ToString();
            
           
            this.Habilitar(true);           
          
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.eEditar = true;
            this.eNovo = false;
            this.btnNovo.Enabled = false;
            this.btnSalvar.Enabled = true;
            this.btnLimpar.Enabled = true;
            if (txtNome.Text == string.Empty || txtEndereco.Text == string.Empty ||
                mcstxtTelefone.Text == string.Empty || mcstxtCpf.Text == string.Empty || cbCargo.Text == string.Empty)
            {
                MessageBox.Show("Selecione um campo para Editar: ");
            }
            else
            {
                this.eNovo = false;
                this.eEditar = true;
                this.Habilitar(true);

            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            FuncionariosDao dao = new FuncionariosDao();
            string nome = txtBuscar.Text;
            dataListaFuncionarios.DataSource = dao.BuscarFuncionarioPorNome(nome);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FuncionariosDao dao = new FuncionariosDao();
            string nome = txtBuscar.Text;
            dataListaFuncionarios.DataSource = dao.BuscarFuncionarioPorNome(nome);

        }
    }
}
