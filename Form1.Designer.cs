namespace PdvVendas
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.MenuMovimentacao = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuMovLancarVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuMovEntradasESaidas = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuMovDespezas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuRelaProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuRelaVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuRelaMovimentacao = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuRelaDespezas = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuRelaEntradasESaidas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItensVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFluxoDeCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuCadastrarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.bubMenuCadastrarFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuCadastrarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuCadastrarFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuProdutoConsultarEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuProdutoConsultarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuFuncionariosConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuClientesConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuFornecedoresConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 129);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1248, 10);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.BackgroundImage = global::PdvVendas.Properties.Resources.texturaExpert;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 388);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrar,
            this.menuProdutos,
            this.menuFuncionarios,
            this.menuClientes,
            this.menuFornecedores});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(20);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(200, 151);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.menuStrip2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1048, 32);
            this.panel3.TabIndex = 2;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMovimentacao,
            this.menuRelatorio,
            this.menuItensVendas,
            this.menuFluxoDeCaixa,
            this.menuSair});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1048, 31);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MenuMovimentacao
            // 
            this.MenuMovimentacao.Checked = true;
            this.MenuMovimentacao.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.MenuMovimentacao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuMovLancarVendas,
            this.subMenuMovEntradasESaidas,
            this.subMenuMovDespezas});
            this.MenuMovimentacao.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuMovimentacao.Image = global::PdvVendas.Properties.Resources.Despesas;
            this.MenuMovimentacao.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.MenuMovimentacao.Name = "MenuMovimentacao";
            this.MenuMovimentacao.Size = new System.Drawing.Size(162, 27);
            this.MenuMovimentacao.Text = "Movimentação";
            // 
            // subMenuMovLancarVendas
            // 
            this.subMenuMovLancarVendas.Name = "subMenuMovLancarVendas";
            this.subMenuMovLancarVendas.Size = new System.Drawing.Size(221, 28);
            this.subMenuMovLancarVendas.Text = "Lançar Vendas";
            // 
            // subMenuMovEntradasESaidas
            // 
            this.subMenuMovEntradasESaidas.Name = "subMenuMovEntradasESaidas";
            this.subMenuMovEntradasESaidas.Size = new System.Drawing.Size(221, 28);
            this.subMenuMovEntradasESaidas.Text = "Entradas / Saidas";
            // 
            // subMenuMovDespezas
            // 
            this.subMenuMovDespezas.Name = "subMenuMovDespezas";
            this.subMenuMovDespezas.Size = new System.Drawing.Size(221, 28);
            this.subMenuMovDespezas.Text = "Despezas";
            // 
            // menuRelatorio
            // 
            this.menuRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRelaProdutos,
            this.subMenuRelaVendas,
            this.subMenuRelaMovimentacao,
            this.subMenuRelaDespezas,
            this.subMenuRelaEntradasESaidas});
            this.menuRelatorio.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuRelatorio.Image = global::PdvVendas.Properties.Resources.Relatory;
            this.menuRelatorio.Name = "menuRelatorio";
            this.menuRelatorio.Size = new System.Drawing.Size(125, 27);
            this.menuRelatorio.Text = "Relatórios";
            // 
            // subMenuRelaProdutos
            // 
            this.subMenuRelaProdutos.Name = "subMenuRelaProdutos";
            this.subMenuRelaProdutos.Size = new System.Drawing.Size(221, 28);
            this.subMenuRelaProdutos.Text = "Produtos";
            // 
            // subMenuRelaVendas
            // 
            this.subMenuRelaVendas.Name = "subMenuRelaVendas";
            this.subMenuRelaVendas.Size = new System.Drawing.Size(221, 28);
            this.subMenuRelaVendas.Text = "Vendas";
            // 
            // subMenuRelaMovimentacao
            // 
            this.subMenuRelaMovimentacao.Name = "subMenuRelaMovimentacao";
            this.subMenuRelaMovimentacao.Size = new System.Drawing.Size(221, 28);
            this.subMenuRelaMovimentacao.Text = "Movimentação";
            // 
            // subMenuRelaDespezas
            // 
            this.subMenuRelaDespezas.Name = "subMenuRelaDespezas";
            this.subMenuRelaDespezas.Size = new System.Drawing.Size(221, 28);
            this.subMenuRelaDespezas.Text = "Despesas";
            // 
            // subMenuRelaEntradasESaidas
            // 
            this.subMenuRelaEntradasESaidas.Name = "subMenuRelaEntradasESaidas";
            this.subMenuRelaEntradasESaidas.Size = new System.Drawing.Size(221, 28);
            this.subMenuRelaEntradasESaidas.Text = "Entradas / Saídas";
            // 
            // menuItensVendas
            // 
            this.menuItensVendas.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItensVendas.Image = global::PdvVendas.Properties.Resources.Moviment;
            this.menuItensVendas.Name = "menuItensVendas";
            this.menuItensVendas.Size = new System.Drawing.Size(157, 27);
            this.menuItensVendas.Text = "Itens de Venda";
            // 
            // menuFluxoDeCaixa
            // 
            this.menuFluxoDeCaixa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFluxoDeCaixa.Image = global::PdvVendas.Properties.Resources.Pagamento;
            this.menuFluxoDeCaixa.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.menuFluxoDeCaixa.MergeIndex = 10;
            this.menuFluxoDeCaixa.Name = "menuFluxoDeCaixa";
            this.menuFluxoDeCaixa.Size = new System.Drawing.Size(165, 27);
            this.menuFluxoDeCaixa.Text = "Fluxo de Caixa";
            // 
            // menuSair
            // 
            this.menuSair.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSair.Image = global::PdvVendas.Properties.Resources.Close;
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(71, 27);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click_1);
            // 
            // menuCadastrar
            // 
            this.menuCadastrar.Checked = true;
            this.menuCadastrar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuCadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuCadastrarProduto,
            this.bubMenuCadastrarFuncionario,
            this.subMenuCadastrarClientes,
            this.subMenuCadastrarFornecedores});
            this.menuCadastrar.Image = global::PdvVendas.Properties.Resources.Cadastrar;
            this.menuCadastrar.Name = "menuCadastrar";
            this.menuCadastrar.Size = new System.Drawing.Size(193, 29);
            this.menuCadastrar.Text = "Cadastrar";
            // 
            // subMenuCadastrarProduto
            // 
            this.subMenuCadastrarProduto.Name = "subMenuCadastrarProduto";
            this.subMenuCadastrarProduto.Size = new System.Drawing.Size(198, 30);
            this.subMenuCadastrarProduto.Text = "Produtos";
            // 
            // bubMenuCadastrarFuncionario
            // 
            this.bubMenuCadastrarFuncionario.Name = "bubMenuCadastrarFuncionario";
            this.bubMenuCadastrarFuncionario.Size = new System.Drawing.Size(198, 30);
            this.bubMenuCadastrarFuncionario.Text = "Funcionários";
            this.bubMenuCadastrarFuncionario.Click += new System.EventHandler(this.bubMenuCadastrarFuncionario_Click_1);
            // 
            // subMenuCadastrarClientes
            // 
            this.subMenuCadastrarClientes.Name = "subMenuCadastrarClientes";
            this.subMenuCadastrarClientes.Size = new System.Drawing.Size(198, 30);
            this.subMenuCadastrarClientes.Text = "Clientes";
            // 
            // subMenuCadastrarFornecedores
            // 
            this.subMenuCadastrarFornecedores.Name = "subMenuCadastrarFornecedores";
            this.subMenuCadastrarFornecedores.Size = new System.Drawing.Size(198, 30);
            this.subMenuCadastrarFornecedores.Text = "Fornecedores";
            // 
            // menuProdutos
            // 
            this.menuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuProdutoConsultarEstoque,
            this.subMenuProdutoConsultarProduto});
            this.menuProdutos.Image = global::PdvVendas.Properties.Resources.Product;
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(193, 29);
            this.menuProdutos.Text = "Produtos";
            // 
            // subMenuProdutoConsultarEstoque
            // 
            this.subMenuProdutoConsultarEstoque.Name = "subMenuProdutoConsultarEstoque";
            this.subMenuProdutoConsultarEstoque.Size = new System.Drawing.Size(238, 30);
            this.subMenuProdutoConsultarEstoque.Text = "Estoque";
            // 
            // subMenuProdutoConsultarProduto
            // 
            this.subMenuProdutoConsultarProduto.Name = "subMenuProdutoConsultarProduto";
            this.subMenuProdutoConsultarProduto.Size = new System.Drawing.Size(238, 30);
            this.subMenuProdutoConsultarProduto.Text = "Consultar Produto";
            // 
            // menuFuncionarios
            // 
            this.menuFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuFuncionariosConsultar});
            this.menuFuncionarios.Image = global::PdvVendas.Properties.Resources.Funcionarios;
            this.menuFuncionarios.Name = "menuFuncionarios";
            this.menuFuncionarios.Size = new System.Drawing.Size(193, 29);
            this.menuFuncionarios.Text = "Funcionários";
            // 
            // subMenuFuncionariosConsultar
            // 
            this.subMenuFuncionariosConsultar.Name = "subMenuFuncionariosConsultar";
            this.subMenuFuncionariosConsultar.Size = new System.Drawing.Size(275, 30);
            this.subMenuFuncionariosConsultar.Text = "Consultar  Funcionário";
            // 
            // menuClientes
            // 
            this.menuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuClientesConsultar});
            this.menuClientes.Image = global::PdvVendas.Properties.Resources.Clientes;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(193, 29);
            this.menuClientes.Text = "Clientes";
            // 
            // subMenuClientesConsultar
            // 
            this.subMenuClientesConsultar.Name = "subMenuClientesConsultar";
            this.subMenuClientesConsultar.Size = new System.Drawing.Size(237, 30);
            this.subMenuClientesConsultar.Text = "Consultar Clientes";
            // 
            // menuFornecedores
            // 
            this.menuFornecedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuFornecedoresConsultar});
            this.menuFornecedores.Image = global::PdvVendas.Properties.Resources.Fornecedor;
            this.menuFornecedores.Name = "menuFornecedores";
            this.menuFornecedores.Size = new System.Drawing.Size(193, 29);
            this.menuFornecedores.Text = "Fornecedores";
            // 
            // subMenuFornecedoresConsultar
            // 
            this.subMenuFornecedoresConsultar.Name = "subMenuFornecedoresConsultar";
            this.subMenuFornecedoresConsultar.Size = new System.Drawing.Size(284, 30);
            this.subMenuFornecedoresConsultar.Text = "Consultar Fornecedores";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1248, 517);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrar;
        private System.Windows.Forms.ToolStripMenuItem subMenuCadastrarProduto;
        private System.Windows.Forms.ToolStripMenuItem bubMenuCadastrarFuncionario;
        private System.Windows.Forms.ToolStripMenuItem subMenuCadastrarClientes;
        private System.Windows.Forms.ToolStripMenuItem subMenuCadastrarFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuProdutos;
        private System.Windows.Forms.ToolStripMenuItem subMenuProdutoConsultarEstoque;
        private System.Windows.Forms.ToolStripMenuItem subMenuProdutoConsultarProduto;
        private System.Windows.Forms.ToolStripMenuItem menuFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem subMenuFuncionariosConsultar;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.ToolStripMenuItem subMenuClientesConsultar;
        private System.Windows.Forms.ToolStripMenuItem menuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem subMenuFornecedoresConsultar;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentacao;
        private System.Windows.Forms.ToolStripMenuItem subMenuMovLancarVendas;
        private System.Windows.Forms.ToolStripMenuItem subMenuMovEntradasESaidas;
        private System.Windows.Forms.ToolStripMenuItem subMenuMovDespezas;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorio;
        private System.Windows.Forms.ToolStripMenuItem subMenuRelaProdutos;
        private System.Windows.Forms.ToolStripMenuItem subMenuRelaVendas;
        private System.Windows.Forms.ToolStripMenuItem subMenuRelaMovimentacao;
        private System.Windows.Forms.ToolStripMenuItem subMenuRelaDespezas;
        private System.Windows.Forms.ToolStripMenuItem subMenuRelaEntradasESaidas;
        private System.Windows.Forms.ToolStripMenuItem menuItensVendas;
        private System.Windows.Forms.ToolStripMenuItem menuFluxoDeCaixa;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
    }
}

