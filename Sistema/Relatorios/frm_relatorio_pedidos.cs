using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Relatorios
{
    public partial class frm_relatorio_pedidos : Form
    {
        public frm_relatorio_pedidos()
        {
            InitializeComponent();
        }

        private void Frm_relatorio_pedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.tb_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_produtoTableAdapter.Fill(this.dataSet1.tb_produto);

            this.reportViewer1.RefreshReport();
        }
    }
}
