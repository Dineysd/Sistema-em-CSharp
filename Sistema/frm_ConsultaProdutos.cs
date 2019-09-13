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
    public partial class frm_ConsultaProdutos : Form
    {
        public frm_ConsultaProdutos()
        {
            InitializeComponent();
        }

        private void Frm_ConsultaProdutos_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContexFactory.DataContext.Categoria;
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Pesquisar((int)comboBox_categoria_consulta.SelectedValue);
        }

        public void Pesquisar(int codigoCategoria)
        {
            this.produtoBindingSource.DataSource = DataContexFactory.DataContext.Produto
                .Where(x => x.codCategoria == codigoCategoria);

        }

        
    }
}
