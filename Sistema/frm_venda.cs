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
    public partial class frm_venda : Form
    {
        public frm_venda()
        {
            InitializeComponent();
        }

        private void Frm_venda_Load(object sender, EventArgs e)
        {
            this.pessoasBindingSource.DataSource = DataContexFactory.DataContext.Pessoas;
            this.vendasBindingSource.DataSource = DataContexFactory.DataContext.Vendas;
            this.produtoBindingSource.DataSource = DataContexFactory.DataContext.Produto;

            this.vendasBindingSource.AddNew();
        }

        public Vendas VendaCorrente
        {
            get
            {
                return (Vendas)this.vendasBindingSource.Current;
            }
        }

        public Itens_Venda ItemCorrente
        {
            get
            {
                return (Itens_Venda)this.itens_VendaBindingSource.Current;
            }
        }

        private void Nova_Venda_Click(object sender, EventArgs e)
        {
            this.Size = new Size(604, 443);
            this.vendasBindingSource.EndEdit();
            DataContexFactory.DataContext.SubmitChanges();

            groupBox_Nova_Venda.Visible = true;
            Nova_Venda.Enabled = false;

            this.itens_VendaBindingSource.DataSource = DataContexFactory
                .DataContext.Itens_Venda.Where (x => x.Codigo_produto == this.VendaCorrente.id_venda);

            novoItem();
            ComboBox_cliente.Enabled = false;
        }

        private void novoItem()
        {
            this.itens_VendaBindingSource.AddNew();
            this.ItemCorrente.Codigo_venda = this.VendaCorrente.id_venda;
            this.ItemCorrente.Quantidade = 1;
        }

        private void Novo_item_Click(object sender, EventArgs e)
        {
            this.itens_VendaBindingSource.EndEdit();
            dg_vendas.Refresh();
            DataContexFactory.DataContext.SubmitChanges();
            calcular_valores();
            novoItem();
            
        }

        private void Dg_vendas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.Value != null && e.ColumnIndex == 1)
            {
                e.Value = ((Produto)e.Value).descricao;
            }
        }

        private void Cb_produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_produto.SelectedItem != null)
            {
                var prod = (Produto)cb_produto.SelectedItem;
                this.ItemCorrente.Codigo_produto = (int)prod.codigo;
                this.ItemCorrente.Valor = (decimal)prod.valor;
            }
        }

        private void calcular_valores()
        {
            decimal total = 0;

            foreach(DataGridViewRow dg in dg_vendas.Rows)
            {
                decimal v1 = Convert.ToDecimal(dg.Cells[2].Value);
                decimal v2 = Convert.ToDecimal(dg.Cells[3].Value);
                decimal subTotal = v1 * v2;
                dg.Cells[4].Value = subTotal;
                total = total + subTotal;
            }

            this.VendaCorrente.Valor_venda = total;
        }

        private DialogResult MessageConfirmar(String msg)
        {
            return MessageBox.Show("Tem Certeza que deseja Finalizar "+ msg +"?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void Btn_fechar_pedido_Click(object sender, EventArgs e)
        {
            if (MessageConfirmar("Pedido") == DialogResult.Yes)
            {
                this.itens_VendaBindingSource.CancelEdit();
                DataContexFactory.DataContext.SubmitChanges();
                this.VendaCorrente.Desconto = 0;
                novo_item.Enabled = false;
                cb_produto.Enabled = false;
                txt_quantidade.Enabled = false;
                txt_desconto.ReadOnly = false;
                txt_desconto.Focus();
                btn_fechar_pedido.Enabled = false;
                btn_fechar_venda.Enabled = true;
                txt_valor_produto.Enabled = false;
                txt_codigo_venda.Enabled = false;
            }
        }

        private void Btn_fechar_venda_Click(object sender, EventArgs e)
        {
            this.VendaCorrente.Desconto = Convert.ToDecimal(txt_desconto.Text);
            this.VendaCorrente.Valor_pago = (decimal)(this.VendaCorrente.Valor_venda - this.VendaCorrente.Desconto);
            this.vendasBindingSource.EndEdit();
            DataContexFactory.DataContext.SubmitChanges();
            txt_desconto.Enabled = false;
            btn_fechar_venda.Enabled = false;
            btn_impromir.Enabled = true;
        }
    }
}
