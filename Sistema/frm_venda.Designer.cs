namespace Sistema
{
    partial class frm_venda
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
            System.Windows.Forms.Label codigo_Pessoa_VendaLabel;
            System.Windows.Forms.Label id_vendaLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label codigo_produtoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label valor_vendaLabel;
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.Label valor_pagoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_venda));
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComboBox_cliente = new System.Windows.Forms.ComboBox();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Nova_Venda = new System.Windows.Forms.Button();
            this.groupBox_Nova_Venda = new System.Windows.Forms.GroupBox();
            this.txt_valor_produto = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_produto = new System.Windows.Forms.ComboBox();
            this.itens_VendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dg_vendas = new System.Windows.Forms.DataGridView();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.txt_codigo_venda = new System.Windows.Forms.TextBox();
            this.novo_item = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_valor_total = new System.Windows.Forms.TextBox();
            this.txt_valor_pago = new System.Windows.Forms.TextBox();
            this.txt_desconto = new System.Windows.Forms.TextBox();
            this.btn_fechar_pedido = new System.Windows.Forms.Button();
            this.btn_fechar_venda = new System.Windows.Forms.Button();
            this.btn_impromir = new System.Windows.Forms.Button();
            codigo_Pessoa_VendaLabel = new System.Windows.Forms.Label();
            id_vendaLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            codigo_produtoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            valor_vendaLabel = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            valor_pagoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            this.groupBox_Nova_Venda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_VendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_vendas)).BeginInit();
            this.SuspendLayout();
            // 
            // codigo_Pessoa_VendaLabel
            // 
            codigo_Pessoa_VendaLabel.AutoSize = true;
            codigo_Pessoa_VendaLabel.BackColor = System.Drawing.Color.Transparent;
            codigo_Pessoa_VendaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigo_Pessoa_VendaLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            codigo_Pessoa_VendaLabel.Location = new System.Drawing.Point(24, 17);
            codigo_Pessoa_VendaLabel.Name = "codigo_Pessoa_VendaLabel";
            codigo_Pessoa_VendaLabel.Size = new System.Drawing.Size(46, 13);
            codigo_Pessoa_VendaLabel.TabIndex = 1;
            codigo_Pessoa_VendaLabel.Text = "Cliente";
            // 
            // id_vendaLabel
            // 
            id_vendaLabel.AutoSize = true;
            id_vendaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_vendaLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            id_vendaLabel.Location = new System.Drawing.Point(5, 18);
            id_vendaLabel.Name = "id_vendaLabel";
            id_vendaLabel.Size = new System.Drawing.Size(90, 13);
            id_vendaLabel.TabIndex = 0;
            id_vendaLabel.Text = "Codigo Venda:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantidadeLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            quantidadeLabel.Location = new System.Drawing.Point(5, 57);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(76, 13);
            quantidadeLabel.TabIndex = 4;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // codigo_produtoLabel
            // 
            codigo_produtoLabel.AutoSize = true;
            codigo_produtoLabel.Location = new System.Drawing.Point(178, 17);
            codigo_produtoLabel.Name = "codigo_produtoLabel";
            codigo_produtoLabel.Size = new System.Drawing.Size(55, 13);
            codigo_produtoLabel.TabIndex = 8;
            codigo_produtoLabel.Text = "Produto:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(5, 97);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(40, 13);
            valorLabel.TabIndex = 9;
            valorLabel.Text = "Valor:";
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataSource = typeof(sistemadbs.DAL.Vendas);
            // 
            // ComboBox_cliente
            // 
            this.ComboBox_cliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBox_cliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendasBindingSource, "Codigo_Pessoa_Venda", true));
            this.ComboBox_cliente.DataSource = this.pessoasBindingSource;
            this.ComboBox_cliente.DisplayMember = "Nome";
            this.ComboBox_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_cliente.FormattingEnabled = true;
            this.ComboBox_cliente.Location = new System.Drawing.Point(126, 14);
            this.ComboBox_cliente.Name = "ComboBox_cliente";
            this.ComboBox_cliente.Size = new System.Drawing.Size(291, 21);
            this.ComboBox_cliente.TabIndex = 2;
            this.ComboBox_cliente.ValueMember = "Codigo_pessoa";
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataSource = typeof(sistemadbs.DAL.Pessoas);
            // 
            // Nova_Venda
            // 
            this.Nova_Venda.BackColor = System.Drawing.Color.Green;
            this.Nova_Venda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Nova_Venda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Nova_Venda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Nova_Venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nova_Venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nova_Venda.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Nova_Venda.Location = new System.Drawing.Point(451, 12);
            this.Nova_Venda.Name = "Nova_Venda";
            this.Nova_Venda.Size = new System.Drawing.Size(94, 23);
            this.Nova_Venda.TabIndex = 3;
            this.Nova_Venda.Text = "Nova Venda";
            this.Nova_Venda.UseVisualStyleBackColor = false;
            this.Nova_Venda.Click += new System.EventHandler(this.Nova_Venda_Click);
            // 
            // groupBox_Nova_Venda
            // 
            this.groupBox_Nova_Venda.BackColor = System.Drawing.Color.Green;
            this.groupBox_Nova_Venda.Controls.Add(this.btn_impromir);
            this.groupBox_Nova_Venda.Controls.Add(this.btn_fechar_venda);
            this.groupBox_Nova_Venda.Controls.Add(this.btn_fechar_pedido);
            this.groupBox_Nova_Venda.Controls.Add(this.txt_desconto);
            this.groupBox_Nova_Venda.Controls.Add(this.txt_valor_pago);
            this.groupBox_Nova_Venda.Controls.Add(this.txt_valor_total);
            this.groupBox_Nova_Venda.Controls.Add(valor_pagoLabel);
            this.groupBox_Nova_Venda.Controls.Add(descontoLabel);
            this.groupBox_Nova_Venda.Controls.Add(valor_vendaLabel);
            this.groupBox_Nova_Venda.Controls.Add(this.novo_item);
            this.groupBox_Nova_Venda.Controls.Add(valorLabel);
            this.groupBox_Nova_Venda.Controls.Add(this.txt_valor_produto);
            this.groupBox_Nova_Venda.Controls.Add(codigo_produtoLabel);
            this.groupBox_Nova_Venda.Controls.Add(this.cb_produto);
            this.groupBox_Nova_Venda.Controls.Add(this.dg_vendas);
            this.groupBox_Nova_Venda.Controls.Add(quantidadeLabel);
            this.groupBox_Nova_Venda.Controls.Add(this.txt_quantidade);
            this.groupBox_Nova_Venda.Controls.Add(id_vendaLabel);
            this.groupBox_Nova_Venda.Controls.Add(this.txt_codigo_venda);
            this.groupBox_Nova_Venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_Nova_Venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Nova_Venda.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox_Nova_Venda.Location = new System.Drawing.Point(9, 58);
            this.groupBox_Nova_Venda.Name = "groupBox_Nova_Venda";
            this.groupBox_Nova_Venda.Size = new System.Drawing.Size(567, 334);
            this.groupBox_Nova_Venda.TabIndex = 4;
            this.groupBox_Nova_Venda.TabStop = false;
            this.groupBox_Nova_Venda.Text = "Nova Venda";
            this.groupBox_Nova_Venda.Visible = false;
            // 
            // txt_valor_produto
            // 
            this.txt_valor_produto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_valor_produto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "valor", true));
            this.txt_valor_produto.Location = new System.Drawing.Point(8, 110);
            this.txt_valor_produto.Name = "txt_valor_produto";
            this.txt_valor_produto.ReadOnly = true;
            this.txt_valor_produto.Size = new System.Drawing.Size(152, 20);
            this.txt_valor_produto.TabIndex = 10;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(sistemadbs.DAL.Produto);
            // 
            // cb_produto
            // 
            this.cb_produto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_produto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cb_produto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itens_VendaBindingSource, "Codigo_produto", true));
            this.cb_produto.DataSource = this.produtoBindingSource;
            this.cb_produto.DisplayMember = "descricao";
            this.cb_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_produto.FormattingEnabled = true;
            this.cb_produto.Location = new System.Drawing.Point(181, 33);
            this.cb_produto.Name = "cb_produto";
            this.cb_produto.Size = new System.Drawing.Size(152, 21);
            this.cb_produto.TabIndex = 9;
            this.cb_produto.ValueMember = "codigo";
            this.cb_produto.SelectedIndexChanged += new System.EventHandler(this.Cb_produto_SelectedIndexChanged);
            // 
            // itens_VendaBindingSource
            // 
            this.itens_VendaBindingSource.DataSource = typeof(sistemadbs.DAL.Itens_Venda);
            // 
            // dg_vendas
            // 
            this.dg_vendas.AllowUserToAddRows = false;
            this.dg_vendas.AllowUserToDeleteRows = false;
            this.dg_vendas.AutoGenerateColumns = false;
            this.dg_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.Column1});
            this.dg_vendas.DataSource = this.itens_VendaBindingSource;
            this.dg_vendas.Location = new System.Drawing.Point(6, 134);
            this.dg_vendas.Name = "dg_vendas";
            this.dg_vendas.ReadOnly = true;
            this.dg_vendas.Size = new System.Drawing.Size(552, 147);
            this.dg_vendas.TabIndex = 8;
            this.dg_vendas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Dg_vendas_CellFormatting);
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_quantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itens_VendaBindingSource, "Quantidade", true));
            this.txt_quantidade.Location = new System.Drawing.Point(8, 74);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(152, 20);
            this.txt_quantidade.TabIndex = 5;
            // 
            // txt_codigo_venda
            // 
            this.txt_codigo_venda.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_codigo_venda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "id_venda", true));
            this.txt_codigo_venda.Location = new System.Drawing.Point(8, 34);
            this.txt_codigo_venda.Name = "txt_codigo_venda";
            this.txt_codigo_venda.ReadOnly = true;
            this.txt_codigo_venda.Size = new System.Drawing.Size(152, 20);
            this.txt_codigo_venda.TabIndex = 1;
            // 
            // novo_item
            // 
            this.novo_item.BackColor = System.Drawing.Color.RoyalBlue;
            this.novo_item.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.novo_item.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.novo_item.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.novo_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novo_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novo_item.ForeColor = System.Drawing.SystemColors.Desktop;
            this.novo_item.Location = new System.Drawing.Point(358, 31);
            this.novo_item.Name = "novo_item";
            this.novo_item.Size = new System.Drawing.Size(94, 23);
            this.novo_item.TabIndex = 11;
            this.novo_item.Text = "Novo Item";
            this.novo_item.UseVisualStyleBackColor = false;
            this.novo_item.Click += new System.EventHandler(this.Novo_item_Click);
            // 
            // valor_vendaLabel
            // 
            valor_vendaLabel.AutoSize = true;
            valor_vendaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            valor_vendaLabel.Location = new System.Drawing.Point(19, 299);
            valor_vendaLabel.Name = "valor_vendaLabel";
            valor_vendaLabel.Size = new System.Drawing.Size(65, 13);
            valor_vendaLabel.TabIndex = 11;
            valor_vendaLabel.Text = "Valor total";
            // 
            // descontoLabel
            // 
            descontoLabel.AutoSize = true;
            descontoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            descontoLabel.Location = new System.Drawing.Point(196, 299);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(65, 13);
            descontoLabel.TabIndex = 12;
            descontoLabel.Text = "Desconto:";
            // 
            // valor_pagoLabel
            // 
            valor_pagoLabel.AutoSize = true;
            valor_pagoLabel.BackColor = System.Drawing.Color.Transparent;
            valor_pagoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            valor_pagoLabel.Location = new System.Drawing.Point(380, 299);
            valor_pagoLabel.Name = "valor_pagoLabel";
            valor_pagoLabel.Size = new System.Drawing.Size(72, 13);
            valor_pagoLabel.TabIndex = 14;
            valor_pagoLabel.Text = "Valor pago:";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Codigo_produto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Codigo Produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 118;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor Item";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Valor Total";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // txt_valor_total
            // 
            this.txt_valor_total.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_valor_total.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "Valor_venda", true));
            this.txt_valor_total.Location = new System.Drawing.Point(90, 296);
            this.txt_valor_total.Name = "txt_valor_total";
            this.txt_valor_total.ReadOnly = true;
            this.txt_valor_total.Size = new System.Drawing.Size(100, 20);
            this.txt_valor_total.TabIndex = 15;
            // 
            // txt_valor_pago
            // 
            this.txt_valor_pago.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_valor_pago.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "Valor_pago", true));
            this.txt_valor_pago.Location = new System.Drawing.Point(458, 296);
            this.txt_valor_pago.Name = "txt_valor_pago";
            this.txt_valor_pago.ReadOnly = true;
            this.txt_valor_pago.Size = new System.Drawing.Size(100, 20);
            this.txt_valor_pago.TabIndex = 16;
            // 
            // txt_desconto
            // 
            this.txt_desconto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_desconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "Desconto", true));
            this.txt_desconto.Location = new System.Drawing.Point(267, 296);
            this.txt_desconto.Name = "txt_desconto";
            this.txt_desconto.ReadOnly = true;
            this.txt_desconto.Size = new System.Drawing.Size(100, 20);
            this.txt_desconto.TabIndex = 17;
            // 
            // btn_fechar_pedido
            // 
            this.btn_fechar_pedido.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_fechar_pedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_fechar_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar_pedido.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_fechar_pedido.Location = new System.Drawing.Point(449, 100);
            this.btn_fechar_pedido.Name = "btn_fechar_pedido";
            this.btn_fechar_pedido.Size = new System.Drawing.Size(112, 23);
            this.btn_fechar_pedido.TabIndex = 18;
            this.btn_fechar_pedido.Text = "Fechar Pedido";
            this.btn_fechar_pedido.UseVisualStyleBackColor = false;
            this.btn_fechar_pedido.Click += new System.EventHandler(this.Btn_fechar_pedido_Click);
            // 
            // btn_fechar_venda
            // 
            this.btn_fechar_venda.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_fechar_venda.Enabled = false;
            this.btn_fechar_venda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_fechar_venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar_venda.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_fechar_venda.Location = new System.Drawing.Point(449, 71);
            this.btn_fechar_venda.Name = "btn_fechar_venda";
            this.btn_fechar_venda.Size = new System.Drawing.Size(112, 23);
            this.btn_fechar_venda.TabIndex = 19;
            this.btn_fechar_venda.Text = "Fechar Venda";
            this.btn_fechar_venda.UseVisualStyleBackColor = false;
            this.btn_fechar_venda.Click += new System.EventHandler(this.Btn_fechar_venda_Click);
            // 
            // btn_impromir
            // 
            this.btn_impromir.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_impromir.Enabled = false;
            this.btn_impromir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_impromir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_impromir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_impromir.Location = new System.Drawing.Point(486, 31);
            this.btn_impromir.Name = "btn_impromir";
            this.btn_impromir.Size = new System.Drawing.Size(75, 23);
            this.btn_impromir.TabIndex = 20;
            this.btn_impromir.Text = "Imprimir";
            this.btn_impromir.UseVisualStyleBackColor = false;
            // 
            // frm_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema.Properties.Resources.imagem;
            this.ClientSize = new System.Drawing.Size(588, 53);
            this.Controls.Add(this.groupBox_Nova_Venda);
            this.Controls.Add(this.Nova_Venda);
            this.Controls.Add(codigo_Pessoa_VendaLabel);
            this.Controls.Add(this.ComboBox_cliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Frm_venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            this.groupBox_Nova_Venda.ResumeLayout(false);
            this.groupBox_Nova_Venda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_VendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_vendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendasBindingSource;
        private System.Windows.Forms.ComboBox ComboBox_cliente;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private System.Windows.Forms.Button Nova_Venda;
        private System.Windows.Forms.GroupBox groupBox_Nova_Venda;
        private System.Windows.Forms.BindingSource itens_VendaBindingSource;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.TextBox txt_codigo_venda;
        private System.Windows.Forms.ComboBox cb_produto;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridView dg_vendas;
        private System.Windows.Forms.TextBox txt_valor_produto;
        private System.Windows.Forms.Button novo_item;
        private System.Windows.Forms.Button btn_impromir;
        private System.Windows.Forms.Button btn_fechar_venda;
        private System.Windows.Forms.Button btn_fechar_pedido;
        private System.Windows.Forms.TextBox txt_desconto;
        private System.Windows.Forms.TextBox txt_valor_pago;
        private System.Windows.Forms.TextBox txt_valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}