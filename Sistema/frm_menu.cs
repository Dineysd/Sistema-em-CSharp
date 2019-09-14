using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Sistema
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void Frm_menu_Load(object sender, EventArgs e)
        {
            Btn_cad_produtos_Click(sender, e);
            Btn_cad_categorias_Click(sender, e);
        }

        private void Btn_cad_produtos_Click(object sender, EventArgs e)
        {
            frm_produtos frm_prod = new frm_produtos();
            frm_prod.Show();
        }

        private void Btn_cad_categorias_Click(object sender, EventArgs e)
        {
            frm_categorias frm_cat = new frm_categorias();
            frm_cat.Show();
        }

        private void ProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_produtos frm_prod = new frm_produtos();
            frm_prod.Show();
        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categorias frm_cat = new frm_categorias();
            frm_cat.Show();
        }

        private void ProdutoscategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ConsultaProdutos frm_cat = new frm_ConsultaProdutos();
            frm_cat.Show();
        }

        private void VendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_venda frm_v = new frm_venda();
            frm_v.Show();
        }
    }
}
