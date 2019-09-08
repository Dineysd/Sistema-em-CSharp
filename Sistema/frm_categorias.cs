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
            if (this.validar())
            {
                this.categoriaBindingSource.EndEdit();
                DataContexFactory.DataContext.SubmitChanges();
                MessageBox.Show("Categoria Inserida com sucesso!");
            }
        }

        private DialogResult MessageConfirmar()
        {
            return MessageBox.Show("Tem Certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void Btn_excluir_cat_Click(object sender, EventArgs e)
        {
            if (MessageConfirmar() == DialogResult.Yes)
            {
                if (this.categoriaPossuiProduto(this.categoriaAtual))
                {
                    MessageBox.Show("Esta Categoria Possui Produtos, Não pode ser excluida!");
                }
                else
                {
                    this.categoriaBindingSource.RemoveCurrent();
                    DataContexFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Categoria Excluida com sucesso!");
                }
            }
        }

        private void Btn_cancelar_cat_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();
        }

        private bool validar()
        {
            if(text_categoria_cat.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo categoria é Obrigatório");
                text_categoria_cat.Focus();
                return false;
            }

            return true;
        }

        public Categoria categoriaAtual
        {
            get
            {
                return (Categoria)this.categoriaBindingSource.Current;
            }
        }

        private bool categoriaPossuiProduto(Categoria categoria)
        {
            var produtos = DataContexFactory.DataContext.Produto.Where(x => x.codCategoria == categoria.codigo);
            if (produtos.Count() > 0)
                return true;
            else
                return false;
            
        }
    }
}
