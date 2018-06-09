namespace WinForm_Controle_De_Estoque.Formularios.Cadastros
{
    partial class frmCadVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblN = new System.Windows.Forms.LinkLabel();
            this.lblCliente = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.RichTextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLocalizaPedido = new System.Windows.Forms.Button();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQtdVenda = new System.Windows.Forms.TextBox();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.grbPedido = new System.Windows.Forms.GroupBox();
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.grbItens = new System.Windows.Forms.GroupBox();
            this.lblTotalPedido = new System.Windows.Forms.Label();
            this.lblTotalProduto = new System.Windows.Forms.Label();
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.grbPesquisaPedido = new System.Windows.Forms.GroupBox();
            this.txtNumPedidoPesq = new System.Windows.Forms.TextBox();
            this.ErrErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.categoriaTableAdapter1 = new WinForm_Controle_De_Estoque.Dados.DataSet_Dados_do_BancoTableAdapters.CategoriaTableAdapter();
            this.dataSet_Dados_do_Banco = new WinForm_Controle_De_Estoque.Dados.DataSet_Dados_do_Banco();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new WinForm_Controle_De_Estoque.Dados.DataSet_Dados_do_BancoTableAdapters.ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.grbPedido.SuspendLayout();
            this.grbItens.SuspendLayout();
            this.grbPesquisaPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_do_Banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(26, 32);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(19, 13);
            this.lblN.TabIndex = 0;
            this.lblN.TabStop = true;
            this.lblN.Text = "Nº";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(142, 32);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.TabStop = true;
            this.lblCliente.Text = "Cliente:";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(304, 16);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(62, 13);
            this.linkLabel3.TabIndex = 3;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Quantidade";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(439, 20);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(33, 13);
            this.linkLabel4.TabIndex = 2;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Data:";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(6, 16);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(40, 13);
            this.linkLabel5.TabIndex = 5;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Código";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(372, 16);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(52, 13);
            this.linkLabel6.TabIndex = 4;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "$ Unitário";
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(457, 16);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(54, 13);
            this.linkLabel7.TabIndex = 7;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Total Item";
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Location = new System.Drawing.Point(107, 57);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(68, 13);
            this.linkLabel8.TabIndex = 6;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Observação:";
            // 
            // linkLabel9
            // 
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.Location = new System.Drawing.Point(352, 205);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(94, 13);
            this.linkLabel9.TabIndex = 9;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "$ Total do Pedido:";
            // 
            // linkLabel10
            // 
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.Location = new System.Drawing.Point(121, 16);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(55, 13);
            this.linkLabel10.TabIndex = 8;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "Descrição";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(6, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(71, 20);
            this.txtCodigo.TabIndex = 10;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(193, 60);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(241, 64);
            this.txtObservacao.TabIndex = 11;
            this.txtObservacao.Text = "";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DataSource = this.clienteBindingSource;
            this.cmbCliente.DisplayMember = "cli_NomeRazao";
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(193, 32);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(241, 21);
            this.cmbCliente.TabIndex = 12;
            this.cmbCliente.ValueMember = "cli_Id";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(475, 57);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Location = new System.Drawing.Point(83, 32);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(34, 23);
            this.btnBuscarProduto.TabIndex = 15;
            this.btnBuscarProduto.Text = "...";
            this.btnBuscarProduto.UseVisualStyleBackColor = true;
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(29, 423);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 16;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(113, 423);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(511, 423);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 19;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(427, 423);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 18;
            this.btnGravar.Text = "Gravar Venda";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnLocalizaPedido
            // 
            this.btnLocalizaPedido.Location = new System.Drawing.Point(102, 18);
            this.btnLocalizaPedido.Name = "btnLocalizaPedido";
            this.btnLocalizaPedido.Size = new System.Drawing.Size(71, 23);
            this.btnLocalizaPedido.TabIndex = 20;
            this.btnLocalizaPedido.Text = "Localizar";
            this.btnLocalizaPedido.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(556, 61);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(34, 23);
            this.btnAdicionarItem.TabIndex = 21;
            this.btnAdicionarItem.Text = "add";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Location = new System.Drawing.Point(556, 90);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(34, 23);
            this.btnRemoverItem.TabIndex = 22;
            this.btnRemoverItem.Text = "Remover";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao,
            this.Quantidade,
            this.Unitario,
            this.TotalItem});
            this.dgvItem.Location = new System.Drawing.Point(6, 61);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.Size = new System.Drawing.Size(544, 129);
            this.dgvItem.TabIndex = 23;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Unitario
            // 
            this.Unitario.HeaderText = "$ Unitário";
            this.Unitario.Name = "Unitario";
            this.Unitario.ReadOnly = true;
            // 
            // TotalItem
            // 
            this.TotalItem.HeaderText = "Total Item";
            this.TotalItem.Name = "TotalItem";
            this.TotalItem.ReadOnly = true;
            // 
            // txtQtdVenda
            // 
            this.txtQtdVenda.Location = new System.Drawing.Point(307, 34);
            this.txtQtdVenda.Name = "txtQtdVenda";
            this.txtQtdVenda.Size = new System.Drawing.Size(59, 20);
            this.txtQtdVenda.TabIndex = 24;
            this.txtQtdVenda.Leave += new System.EventHandler(this.txtQtdVenda_Leave);
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.Location = new System.Drawing.Point(375, 35);
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.Size = new System.Drawing.Size(71, 20);
            this.txtValorUnit.TabIndex = 25;
            this.txtValorUnit.Leave += new System.EventHandler(this.txtValorUnit_Leave);
            // 
            // grbPedido
            // 
            this.grbPedido.Controls.Add(this.lblNumeroPedido);
            this.grbPedido.Controls.Add(this.dtpDataVenda);
            this.grbPedido.Controls.Add(this.btnCancelar);
            this.grbPedido.Controls.Add(this.linkLabel4);
            this.grbPedido.Controls.Add(this.linkLabel8);
            this.grbPedido.Location = new System.Drawing.Point(12, 12);
            this.grbPedido.Name = "grbPedido";
            this.grbPedido.Size = new System.Drawing.Size(609, 125);
            this.grbPedido.TabIndex = 27;
            this.grbPedido.TabStop = false;
            this.grbPedido.Text = "Pedido";
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumeroPedido.Location = new System.Drawing.Point(39, 16);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(72, 25);
            this.lblNumeroPedido.TabIndex = 15;
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVenda.Location = new System.Drawing.Point(478, 17);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(101, 20);
            this.dtpDataVenda.TabIndex = 0;
            // 
            // grbItens
            // 
            this.grbItens.Controls.Add(this.lblTotalPedido);
            this.grbItens.Controls.Add(this.btnRemoverItem);
            this.grbItens.Controls.Add(this.txtValorUnit);
            this.grbItens.Controls.Add(this.btnAdicionarItem);
            this.grbItens.Controls.Add(this.lblTotalProduto);
            this.grbItens.Controls.Add(this.txtQtdVenda);
            this.grbItens.Controls.Add(this.lblDescricaoProduto);
            this.grbItens.Controls.Add(this.dgvItem);
            this.grbItens.Controls.Add(this.linkLabel9);
            this.grbItens.Controls.Add(this.linkLabel5);
            this.grbItens.Controls.Add(this.txtCodigo);
            this.grbItens.Controls.Add(this.btnBuscarProduto);
            this.grbItens.Controls.Add(this.linkLabel10);
            this.grbItens.Controls.Add(this.linkLabel3);
            this.grbItens.Controls.Add(this.linkLabel7);
            this.grbItens.Controls.Add(this.linkLabel6);
            this.grbItens.Location = new System.Drawing.Point(12, 148);
            this.grbItens.Name = "grbItens";
            this.grbItens.Size = new System.Drawing.Size(609, 238);
            this.grbItens.TabIndex = 28;
            this.grbItens.TabStop = false;
            this.grbItens.Text = "Itens";
            // 
            // lblTotalPedido
            // 
            this.lblTotalPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalPedido.Location = new System.Drawing.Point(472, 204);
            this.lblTotalPedido.Name = "lblTotalPedido";
            this.lblTotalPedido.Size = new System.Drawing.Size(78, 23);
            this.lblTotalPedido.TabIndex = 26;
            // 
            // lblTotalProduto
            // 
            this.lblTotalProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalProduto.Location = new System.Drawing.Point(460, 32);
            this.lblTotalProduto.Name = "lblTotalProduto";
            this.lblTotalProduto.Size = new System.Drawing.Size(78, 23);
            this.lblTotalProduto.TabIndex = 17;
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescricaoProduto.Location = new System.Drawing.Point(123, 32);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(172, 23);
            this.lblDescricaoProduto.TabIndex = 16;
            // 
            // grbPesquisaPedido
            // 
            this.grbPesquisaPedido.Controls.Add(this.txtNumPedidoPesq);
            this.grbPesquisaPedido.Controls.Add(this.btnLocalizaPedido);
            this.grbPesquisaPedido.Location = new System.Drawing.Point(227, 405);
            this.grbPesquisaPedido.Name = "grbPesquisaPedido";
            this.grbPesquisaPedido.Size = new System.Drawing.Size(179, 53);
            this.grbPesquisaPedido.TabIndex = 29;
            this.grbPesquisaPedido.TabStop = false;
            this.grbPesquisaPedido.Text = "Informe o Nº da Venda";
            // 
            // txtNumPedidoPesq
            // 
            this.txtNumPedidoPesq.Location = new System.Drawing.Point(6, 20);
            this.txtNumPedidoPesq.Name = "txtNumPedidoPesq";
            this.txtNumPedidoPesq.Size = new System.Drawing.Size(90, 20);
            this.txtNumPedidoPesq.TabIndex = 21;
            // 
            // ErrErro
            // 
            this.ErrErro.ContainerControl = this;
            // 
            // categoriaTableAdapter1
            // 
            this.categoriaTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet_Dados_do_Banco
            // 
            this.dataSet_Dados_do_Banco.DataSetName = "DataSet_Dados_do_Banco";
            this.dataSet_Dados_do_Banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dataSet_Dados_do_Banco;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 470);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.grbPedido);
            this.Controls.Add(this.grbItens);
            this.Controls.Add(this.grbPesquisaPedido);
            this.Name = "frmCadVendas";
            this.Text = "Lançamento de Vendas";
            this.Load += new System.EventHandler(this.frmCadVendas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadVendas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.grbPedido.ResumeLayout(false);
            this.grbPedido.PerformLayout();
            this.grbItens.ResumeLayout(false);
            this.grbItens.PerformLayout();
            this.grbPesquisaPedido.ResumeLayout(false);
            this.grbPesquisaPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrErro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_do_Banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblN;
        private System.Windows.Forms.LinkLabel lblCliente;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.RichTextBox txtObservacao;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLocalizaPedido;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.TextBox txtQtdVenda;
        private System.Windows.Forms.TextBox txtValorUnit;
        private System.Windows.Forms.GroupBox grbPedido;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.GroupBox grbItens;
        private System.Windows.Forms.Label lblTotalPedido;
        private System.Windows.Forms.Label lblTotalProduto;
        private System.Windows.Forms.Label lblDescricaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalItem;
        private System.Windows.Forms.GroupBox grbPesquisaPedido;
        private System.Windows.Forms.TextBox txtNumPedidoPesq;
        private System.Windows.Forms.ErrorProvider ErrErro;
        private Dados.DataSet_Dados_do_BancoTableAdapters.CategoriaTableAdapter categoriaTableAdapter1;
        private Dados.DataSet_Dados_do_Banco dataSet_Dados_do_Banco;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Dados.DataSet_Dados_do_BancoTableAdapters.ClienteTableAdapter clienteTableAdapter;
    }
}