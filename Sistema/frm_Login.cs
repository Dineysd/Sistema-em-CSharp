using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemadbs.DAL;

namespace Sistema
{
    public partial class frm_Login : Form
    {
        public bool logar = false;
        public frm_Login()
        {
            InitializeComponent();
        }

        private void efetuarLogin()
        {
            var user = DataContexFactory.DataContext.Usuarios.Count(
                x=> x.Usuario == txt_usuario.Text && x.Senha == txt_senha.Text);

            if(user > 0)
            {
                this.logar = true;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorretos");
            }
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            efetuarLogin();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
