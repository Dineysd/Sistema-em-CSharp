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
    public partial class frm_produtos : Form
    {
        public frm_produtos()
        {
            InitializeComponent();
        }

        private void Frm_produtos_Load(object sender, EventArgs e)
        {
            this.produtoBindingSource.DataSource = DataContexFactory.DataContext.Produto;
            this.categoriaBindingSource.DataSource = DataContexFactory.DataContext.Categoria;
        }
    }
}
