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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_venda));
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComboBox_cliente = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            codigo_Pessoa_VendaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataSource = typeof(sistemadbs.DAL.Vendas);
            // 
            // codigo_Pessoa_VendaLabel
            // 
            codigo_Pessoa_VendaLabel.AutoSize = true;
            codigo_Pessoa_VendaLabel.BackColor = System.Drawing.Color.Transparent;
            codigo_Pessoa_VendaLabel.ForeColor = System.Drawing.Color.White;
            codigo_Pessoa_VendaLabel.Location = new System.Drawing.Point(12, 15);
            codigo_Pessoa_VendaLabel.Name = "codigo_Pessoa_VendaLabel";
            codigo_Pessoa_VendaLabel.Size = new System.Drawing.Size(39, 13);
            codigo_Pessoa_VendaLabel.TabIndex = 1;
            codigo_Pessoa_VendaLabel.Text = "Cliente";
            // 
            // ComboBox_cliente
            // 
            this.ComboBox_cliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendasBindingSource, "Codigo_Pessoa_Venda", true));
            this.ComboBox_cliente.DataSource = this.pessoasBindingSource;
            this.ComboBox_cliente.DisplayMember = "Nome";
            this.ComboBox_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_cliente.FormattingEnabled = true;
            this.ComboBox_cliente.Location = new System.Drawing.Point(69, 12);
            this.ComboBox_cliente.Name = "ComboBox_cliente";
            this.ComboBox_cliente.Size = new System.Drawing.Size(152, 21);
            this.ComboBox_cliente.TabIndex = 2;
            this.ComboBox_cliente.ValueMember = "Codigo_pessoa";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(236, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nova Venda";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataSource = typeof(sistemadbs.DAL.Pessoas);
            // 
            // frm_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema.Properties.Resources.imagem;
            this.ClientSize = new System.Drawing.Size(563, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(codigo_Pessoa_VendaLabel);
            this.Controls.Add(this.ComboBox_cliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Frm_venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendasBindingSource;
        private System.Windows.Forms.ComboBox ComboBox_cliente;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private System.Windows.Forms.Button button1;
    }
}