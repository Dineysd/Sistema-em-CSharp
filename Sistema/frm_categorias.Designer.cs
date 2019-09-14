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
            this.btn_excluir_cat = new System.Windows.Forms.Button();
            this.btn_cancelar_cat = new System.Windows.Forms.Button();
            this.btn_cadastrar_cat = new System.Windows.Forms.Button();
            this.btn_novo_cat = new System.Windows.Forms.Button();
            this.text_categoria_cat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridView2_cat.Location = new System.Drawing.Point(168, 58);
            this.dataGridView2_cat.Name = "dataGridView2_cat";
            this.dataGridView2_cat.ReadOnly = true;
            this.dataGridView2_cat.Size = new System.Drawing.Size(353, 204);
            this.dataGridView2_cat.TabIndex = 31;
            // 
            // btn_excluir_cat
            // 
            this.btn_excluir_cat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_excluir_cat.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_excluir_cat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_excluir_cat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_excluir_cat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir_cat.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_excluir_cat.Location = new System.Drawing.Point(29, 177);
            this.btn_excluir_cat.Name = "btn_excluir_cat";
            this.btn_excluir_cat.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir_cat.TabIndex = 30;
            this.btn_excluir_cat.Text = "Excluir";
            this.btn_excluir_cat.UseVisualStyleBackColor = false;
            this.btn_excluir_cat.Click += new System.EventHandler(this.Btn_excluir_cat_Click);
            // 
            // btn_cancelar_cat
            // 
            this.btn_cancelar_cat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_cancelar_cat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancelar_cat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancelar_cat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancelar_cat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar_cat.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_cancelar_cat.Location = new System.Drawing.Point(29, 239);
            this.btn_cancelar_cat.Name = "btn_cancelar_cat";
            this.btn_cancelar_cat.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar_cat.TabIndex = 29;
            this.btn_cancelar_cat.Text = "Cancelar";
            this.btn_cancelar_cat.UseVisualStyleBackColor = false;
            this.btn_cancelar_cat.Click += new System.EventHandler(this.Btn_cancelar_cat_Click);
            // 
            // btn_cadastrar_cat
            // 
            this.btn_cadastrar_cat.BackColor = System.Drawing.Color.Teal;
            this.btn_cadastrar_cat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cadastrar_cat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cadastrar_cat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cadastrar_cat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar_cat.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_cadastrar_cat.Location = new System.Drawing.Point(29, 118);
            this.btn_cadastrar_cat.Name = "btn_cadastrar_cat";
            this.btn_cadastrar_cat.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar_cat.TabIndex = 28;
            this.btn_cadastrar_cat.Text = "Cadastrar";
            this.btn_cadastrar_cat.UseVisualStyleBackColor = false;
            this.btn_cadastrar_cat.Click += new System.EventHandler(this.Btn_cadastrar_cat_Click);
            // 
            // btn_novo_cat
            // 
            this.btn_novo_cat.BackColor = System.Drawing.Color.Green;
            this.btn_novo_cat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_novo_cat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_novo_cat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_novo_cat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo_cat.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_novo_cat.Location = new System.Drawing.Point(29, 58);
            this.btn_novo_cat.Name = "btn_novo_cat";
            this.btn_novo_cat.Size = new System.Drawing.Size(75, 23);
            this.btn_novo_cat.TabIndex = 27;
            this.btn_novo_cat.Text = "Novo";
            this.btn_novo_cat.UseVisualStyleBackColor = false;
            this.btn_novo_cat.Click += new System.EventHandler(this.Btn_novo_cat_Click);
            // 
            // text_categoria_cat
            // 
            this.text_categoria_cat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.text_categoria_cat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "descricao", true));
            this.text_categoria_cat.Location = new System.Drawing.Point(251, 12);
            this.text_categoria_cat.Name = "text_categoria_cat";
            this.text_categoria_cat.Size = new System.Drawing.Size(187, 20);
            this.text_categoria_cat.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(165, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Categoria";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(sistemadbs.DAL.Categoria);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 120;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 210;
            // 
            // frm_categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Sistema.Properties.Resources.imagem;
            this.ClientSize = new System.Drawing.Size(533, 296);
            this.Controls.Add(this.dataGridView2_cat);
            this.Controls.Add(this.btn_excluir_cat);
            this.Controls.Add(this.btn_cancelar_cat);
            this.Controls.Add(this.btn_cadastrar_cat);
            this.Controls.Add(this.btn_novo_cat);
            this.Controls.Add(this.text_categoria_cat);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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