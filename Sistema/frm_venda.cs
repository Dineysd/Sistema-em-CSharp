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
            this.Size = new Size(604, 92);
            this.pessoasBindingSource.DataSource = DataContexFactory.DataContext.Pessoas;
            this.vendasBindingSource.DataSource = DataContexFactory.DataContext.Vendas;
            this.produtoBindingSource.DataSource = DataContexFactory.DataContext.Produto;
            this.status_PagamentoBindingSource.DataSource = DataContexFactory.DataContext.Status_Pagamento;
            this.contas_ReceberBindingSource.DataSource = DataContexFactory.DataContext.Contas_Receber;

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

        public Contas_Receber ContaCorrente
        {
            get
            {
                return (Contas_Receber)this.contas_ReceberBindingSource.Current;
            }
        }

        private void Nova_Venda_Click(object sender, EventArgs e)
        {
            this.Size = new Size(604, 461);
            this.vendasBindingSource.EndEdit();
            DataContexFactory.DataContext.SubmitChanges();

            groupBox_Nova_Venda.Visible = true;
            Nova_Venda.Enabled = false;

            this.itens_VendaBindingSource.DataSource = DataContexFactory
                .DataContext.Itens_Venda.Where (x => x.Codigo_produto == this.VendaCorrente.id_venda);

            novoItem();
            ComboBox_cliente.Enabled = false;
            novo_item.Enabled = false;
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
            novo_item.Enabled = false;
            
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
                novo_item.Enabled = true;
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
            // btn_impromir.Enabled = true;
            cb_status_pgto.Enabled = true;

            this.contas_ReceberBindingSource.AddNew();
            this.ContaCorrente.Codigo_venda = this.VendaCorrente.id_venda;
            this.ContaCorrente.Data_compra = DateTime.Now;
            this.ContaCorrente.Data_vencimento = DateTime.Now;
        }

        private void Cb_status_pgto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_status_pgto.SelectedItem != null)
            {
                var status = (Status_Pagamento)cb_status_pgto.SelectedItem;
                if(status.id_status == 1)
                {
                    this.ContaCorrente.Codigo_status = (int)status.id_status;
                    this.ContaCorrente.Data_pagamento = DateTime.Now;
                    btn_finalizar.Enabled = true;
                    txt_data_venc.Enabled = false;
                }
                else if(status.id_status == 2)
                {
                    this.ContaCorrente.Codigo_status = (int)status.id_status;
                    this.ContaCorrente.Data_vencimento = DateTime.Now;
                    txt_data_venc.Enabled = true;
                    btn_finalizar.Enabled = true;
                }
            }
        }

        private void Btn_finalizar_Click(object sender, EventArgs e)
        {
            this.contas_ReceberBindingSource.EndEdit();
            txt_data_venc.Enabled = false;
            btn_finalizar.Enabled = false;
            cb_status_pgto.Enabled = false;
            btn_impromir.Enabled = true;
            DataContexFactory.DataContext.SubmitChanges();
            MessageBox.Show("Venda Finalizada com Sucesso!");
        }
    }
}
