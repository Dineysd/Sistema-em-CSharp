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
    public partial class frm_categorias : Form
    {
        public frm_categorias()
        {
            InitializeComponent();
        }

        private void Frm_categorias_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContexFactory.DataContext.Categoria;
        }

        private void Btn_novo_cat_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.AddNew();
        }

        private void Btn_cadastrar_cat_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.EndEdit();
            DataContexFactory.DataContext.SubmitChanges();
            MessageBox.Show("Categoria Inserida com sucesso!");
        }

        private void Btn_excluir_cat_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.RemoveCurrent();
            DataContexFactory.DataContext.SubmitChanges();
            MessageBox.Show("Categoria Excluida com sucesso!");
        }

        private void Btn_cancelar_cat_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();
        }
    }
}
