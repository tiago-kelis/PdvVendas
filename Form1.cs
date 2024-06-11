using PdvVendas.br.com.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdvVendas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }      

        private void bubMenuCadastrarFuncionario_Click_1(object sender, EventArgs e)
        {

            FrmCadastro funcionario = new FrmCadastro();
            funcionario.ShowDialog();
        }

        private void menuSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
