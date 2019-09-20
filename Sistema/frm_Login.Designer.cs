namespace Sistema
{
    partial class frm_Login
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
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label senhaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            usuarioLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = typeof(sistemadbs.DAL.Usuarios);
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.BackColor = System.Drawing.Color.Transparent;
            usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            usuarioLabel.Location = new System.Drawing.Point(26, 68);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(60, 18);
            usuarioLabel.TabIndex = 1;
            usuarioLabel.Text = "Usuário";
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_usuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Usuario", true));
            this.txt_usuario.Location = new System.Drawing.Point(113, 68);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(182, 20);
            this.txt_usuario.TabIndex = 2;
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.BackColor = System.Drawing.Color.Transparent;
            senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            senhaLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            senhaLabel.Location = new System.Drawing.Point(26, 116);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(50, 18);
            senhaLabel.TabIndex = 2;
            senhaLabel.Text = "Senha";
            // 
            // txt_senha
            // 
            this.txt_senha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_senha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Senha", true));
            this.txt_senha.Location = new System.Drawing.Point(113, 116);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(182, 20);
            this.txt_senha.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Green;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_login.Location = new System.Drawing.Point(113, 182);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(78, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_cancelar.Location = new System.Drawing.Point(220, 182);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema.Properties.Resources.imagem_login;
            this.ClientSize = new System.Drawing.Size(400, 273);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.txt_usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_cancelar;
    }
}