namespace Sistema
{
    partial class frm_categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_categorias));
            this.dataGridView2_cat = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_excluir_cat = new System.Windows.Forms.Button();
            this.btn_cancelar_cat = new System.Windows.Forms.Button();
            this.btn_cadastrar_cat = new System.Windows.Forms.Button();
            this.btn_novo_cat = new System.Windows.Forms.Button();
            this.text_categoria_cat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2_cat
            // 
            this.dataGridView2_cat.AllowUserToAddRows = false;
            this.dataGridView2_cat.AllowUserToDeleteRows = false;
            this.dataGridView2_cat.AutoGenerateColumns = false;
            this.dataGridView2_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_cat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dataGridView2_cat.DataSource = this.categoriaBindingSource;
            this.dataGridView2_cat.Location = new System.Drawing.Point(10, 104);
            this.dataGridView2_cat.Name = "dataGridView2_cat";
            this.dataGridView2_cat.ReadOnly = true;
            this.dataGridView2_cat.Size = new System.Drawing.Size(541, 166);
            this.dataGridView2_cat.TabIndex = 31;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 200;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(sistemadbs.DAL.Categoria);
            // 
            // btn_excluir_cat
            // 
            this.btn_excluir_cat.Location = new System.Drawing.Point(288, 51);
            this.btn_excluir_cat.Name = "btn_excluir_cat";
            this.btn_excluir_cat.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir_cat.TabIndex = 30;
            this.btn_excluir_cat.Text = "Excluir";
            this.btn_excluir_cat.UseVisualStyleBackColor = true;
            this.btn_excluir_cat.Click += new System.EventHandler(this.Btn_excluir_cat_Click);
            // 
            // btn_cancelar_cat
            // 
            this.btn_cancelar_cat.Location = new System.Drawing.Point(379, 51);
            this.btn_cancelar_cat.Name = "btn_cancelar_cat";
            this.btn_cancelar_cat.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar_cat.TabIndex = 29;
            this.btn_cancelar_cat.Text = "Cancelar";
            this.btn_cancelar_cat.UseVisualStyleBackColor = true;
            this.btn_cancelar_cat.Click += new System.EventHandler(this.Btn_cancelar_cat_Click);
            // 
            // btn_cadastrar_cat
            // 
            this.btn_cadastrar_cat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cadastrar_cat.Location = new System.Drawing.Point(194, 51);
            this.btn_cadastrar_cat.Name = "btn_cadastrar_cat";
            this.btn_cadastrar_cat.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar_cat.TabIndex = 28;
            this.btn_cadastrar_cat.Text = "Cadastrar";
            this.btn_cadastrar_cat.UseVisualStyleBackColor = true;
            this.btn_cadastrar_cat.Click += new System.EventHandler(this.Btn_cadastrar_cat_Click);
            // 
            // btn_novo_cat
            // 
            this.btn_novo_cat.Location = new System.Drawing.Point(101, 51);
            this.btn_novo_cat.Name = "btn_novo_cat";
            this.btn_novo_cat.Size = new System.Drawing.Size(75, 23);
            this.btn_novo_cat.TabIndex = 27;
            this.btn_novo_cat.Text = "Novo";
            this.btn_novo_cat.UseVisualStyleBackColor = true;
            this.btn_novo_cat.Click += new System.EventHandler(this.Btn_novo_cat_Click);
            // 
            // text_categoria_cat
            // 
            this.text_categoria_cat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.text_categoria_cat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "descricao", true));
            this.text_categoria_cat.Location = new System.Drawing.Point(68, 14);
            this.text_categoria_cat.Name = "text_categoria_cat";
            this.text_categoria_cat.Size = new System.Drawing.Size(121, 20);
            this.text_categoria_cat.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Categoria";
            // 
            // frm_categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Sistema.Properties.Resources.imagem;
            this.ClientSize = new System.Drawing.Size(563, 296);
            this.Controls.Add(this.dataGridView2_cat);
            this.Controls.Add(this.btn_excluir_cat);
            this.Controls.Add(this.btn_cancelar_cat);
            this.Controls.Add(this.btn_cadastrar_cat);
            this.Controls.Add(this.btn_novo_cat);
            this.Controls.Add(this.text_categoria_cat);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.Frm_categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2_cat;
        private System.Windows.Forms.Button btn_excluir_cat;
        private System.Windows.Forms.Button btn_cancelar_cat;
        private System.Windows.Forms.Button btn_cadastrar_cat;
        private System.Windows.Forms.Button btn_novo_cat;
        private System.Windows.Forms.TextBox text_categoria_cat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}