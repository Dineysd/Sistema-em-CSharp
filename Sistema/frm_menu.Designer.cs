namespace Sistema
{
    partial class frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoscategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_produtos = new System.Windows.Forms.Button();
            this.btn_cad_categorias = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_consulta_produtos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_relatorio_produto = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cadastroToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.produtosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.ProdutosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoriasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.CategoriasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoscategoriasToolStripMenuItem});
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.consultasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.consultasToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // produtoscategoriasToolStripMenuItem
            // 
            this.produtoscategoriasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.produtoscategoriasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.produtoscategoriasToolStripMenuItem.Name = "produtoscategoriasToolStripMenuItem";
            this.produtoscategoriasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.produtoscategoriasToolStripMenuItem.Text = "produtos/categorias";
            this.produtoscategoriasToolStripMenuItem.Click += new System.EventHandler(this.ProdutoscategoriasToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaToolStripMenuItem});
            this.vendasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.vendasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.vendasToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vendaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.VendaToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem1});
            this.relatoriosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.relatoriosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatórios";
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.produtosToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.ProdutosToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sairToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // btn_cad_produtos
            // 
            this.btn_cad_produtos.BackColor = System.Drawing.Color.Transparent;
            this.btn_cad_produtos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cad_produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_produtos.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_cad_produtos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_cad_produtos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_cad_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_produtos.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad_produtos.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_cad_produtos.Image = global::Sistema.Properties.Resources.packager_add;
            this.btn_cad_produtos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_produtos.Location = new System.Drawing.Point(21, 43);
            this.btn_cad_produtos.Name = "btn_cad_produtos";
            this.btn_cad_produtos.Size = new System.Drawing.Size(90, 90);
            this.btn_cad_produtos.TabIndex = 2;
            this.btn_cad_produtos.Text = "Cadastrar Produtos";
            this.btn_cad_produtos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_produtos.UseVisualStyleBackColor = false;
            this.btn_cad_produtos.Click += new System.EventHandler(this.Btn_cad_produtos_Click);
            // 
            // btn_cad_categorias
            // 
            this.btn_cad_categorias.BackColor = System.Drawing.Color.Transparent;
            this.btn_cad_categorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cad_categorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_categorias.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_cad_categorias.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cad_categorias.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_cad_categorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_categorias.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad_categorias.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_cad_categorias.Image = global::Sistema.Properties.Resources.category40x40;
            this.btn_cad_categorias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_categorias.Location = new System.Drawing.Point(135, 43);
            this.btn_cad_categorias.Name = "btn_cad_categorias";
            this.btn_cad_categorias.Size = new System.Drawing.Size(92, 90);
            this.btn_cad_categorias.TabIndex = 3;
            this.btn_cad_categorias.Text = "Cadastrar categorias";
            this.btn_cad_categorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_categorias.UseVisualStyleBackColor = false;
            this.btn_cad_categorias.Click += new System.EventHandler(this.Btn_cad_categorias_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.BackColor = System.Drawing.Color.Transparent;
            this.btn_usuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_usuarios.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_usuarios.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_usuarios.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuarios.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuarios.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_usuarios.Image = global::Sistema.Properties.Resources.admin40x40;
            this.btn_usuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_usuarios.Location = new System.Drawing.Point(248, 43);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(92, 90);
            this.btn_usuarios.TabIndex = 4;
            this.btn_usuarios.Text = "Cadastrar Usuarios";
            this.btn_usuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_usuarios.UseVisualStyleBackColor = false;
            this.btn_usuarios.Click += new System.EventHandler(this.Btn_usuarios_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.BackColor = System.Drawing.Color.Transparent;
            this.btn_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clientes.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientes.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_clientes.Image = global::Sistema.Properties.Resources.cadastro_clientes_40_x_40;
            this.btn_clientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_clientes.Location = new System.Drawing.Point(21, 152);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(90, 90);
            this.btn_clientes.TabIndex = 5;
            this.btn_clientes.Text = "Cadastrar Clientes";
            this.btn_clientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_clientes.UseVisualStyleBackColor = false;
            // 
            // btn_consulta_produtos
            // 
            this.btn_consulta_produtos.BackColor = System.Drawing.Color.Transparent;
            this.btn_consulta_produtos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_consulta_produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consulta_produtos.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_consulta_produtos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_consulta_produtos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_consulta_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consulta_produtos.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulta_produtos.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_consulta_produtos.Image = global::Sistema.Properties.Resources.consulta_produto;
            this.btn_consulta_produtos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_consulta_produtos.Location = new System.Drawing.Point(135, 152);
            this.btn_consulta_produtos.Name = "btn_consulta_produtos";
            this.btn_consulta_produtos.Size = new System.Drawing.Size(92, 90);
            this.btn_consulta_produtos.TabIndex = 6;
            this.btn_consulta_produtos.Text = "Consultar Produtos";
            this.btn_consulta_produtos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_consulta_produtos.UseVisualStyleBackColor = false;
            this.btn_consulta_produtos.Click += new System.EventHandler(this.Btn_consulta_produtos_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Image = global::Sistema.Properties.Resources.money40x40;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(248, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 90);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cadastrar Vendas";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_relatorio_produto
            // 
            this.btn_relatorio_produto.BackColor = System.Drawing.Color.Transparent;
            this.btn_relatorio_produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_relatorio_produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_relatorio_produto.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_relatorio_produto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_relatorio_produto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_relatorio_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_relatorio_produto.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_relatorio_produto.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_relatorio_produto.Image = global::Sistema.Properties.Resources.relatorios_40_x_40;
            this.btn_relatorio_produto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_relatorio_produto.Location = new System.Drawing.Point(356, 43);
            this.btn_relatorio_produto.Name = "btn_relatorio_produto";
            this.btn_relatorio_produto.Size = new System.Drawing.Size(92, 90);
            this.btn_relatorio_produto.TabIndex = 8;
            this.btn_relatorio_produto.Text = "Relatório Produtos";
            this.btn_relatorio_produto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_relatorio_produto.UseVisualStyleBackColor = false;
            this.btn_relatorio_produto.Click += new System.EventHandler(this.Btn_relatorio_produto_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Transparent;
            this.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_sair.Image = global::Sistema.Properties.Resources.sair_40_x_38;
            this.btn_sair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sair.Location = new System.Drawing.Point(356, 152);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(92, 90);
            this.btn_sair.TabIndex = 9;
            this.btn_sair.Text = "Sair do Sistema";
            this.btn_sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.Btn_sair_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Sistema.Properties.Resources.imagem;
            this.ClientSize = new System.Drawing.Size(563, 296);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_relatorio_produto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_consulta_produtos);
            this.Controls.Add(this.btn_clientes);
            this.Controls.Add(this.btn_usuarios);
            this.Controls.Add(this.btn_cad_categorias);
            this.Controls.Add(this.btn_cad_produtos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Frm_menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.Button btn_cad_produtos;
        private System.Windows.Forms.Button btn_cad_categorias;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoscategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_consulta_produtos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_relatorio_produto;
        private System.Windows.Forms.Button btn_sair;
    }
}

