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
using MaterialSkin.Controls;

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

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.AddNew();
        }

        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (this.validar())
            {
                this.produtoBindingSource.EndEdit();
                DataContexFactory.DataContext.SubmitChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Produto Inserida com sucesso!");
            }
        }

        private bool validar()
        {
            if (text_descricao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Descrição é Obrigatório");
                text_descricao.Focus();
                return false;
            }

            return true;
        }
        private DialogResult MessageConfirmar()
        {
            return MessageBox.Show("Tem Certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageConfirmar() == DialogResult.Yes)
            {
                    this.produtoBindingSource.RemoveCurrent();
                    DataContexFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Produto Excluido com sucesso!");
                
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.CancelEdit();
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.Value != null && e.ColumnIndex == 3)
            {
                e.Value = ((Categoria)e.Value).descricao;
            }
        }
    }
}
