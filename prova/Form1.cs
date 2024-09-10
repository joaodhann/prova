using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace prova
{
    public partial class Form1 : Form
    {
        //double ttotal;
        double contador = 0;
        int numerovendas;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_inserir_Click(object sender, EventArgs e)
        {
            //Adiciona o conteúdo das caixas de texto nas colunas correspondentes
            double quantidade = double.Parse(txtquantidade.Text);
            double v_unitario = double.Parse(txtv_unitario.Text);
            dgv_produtos.Rows.Add(produto.Text, txtquantidade.Text, txtv_unitario.Text);
            double ttotal = quantidade * v_unitario;
            contador += ttotal;
            total.Text = contador.ToString();
            
            //Limpa as caixas de texto
            produto.Clear();
            txtquantidade.Clear();
            txtv_unitario.Clear();
            //Exibe uma mensagem ao usuário de Inclusão com sucesso!
            MessageBox.Show("Produto Incluido com sucesso", "Inclusão",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //Exibe na label o contador de linhas do GridView atualizado após a remoção
            total.Text = contador.ToString();
            tvendas.Text = dgv_produtos.RowCount.ToString();
        }

        private void bt_remover_Click(object sender, EventArgs e)
        {
            //Verifica a existência de linhas no Grid
            if (dgv_produtos.RowCount > 0)
            {
               
                //Exibe uma mensagem ao usuário de exclusão com sucesso!
                MessageBox.Show("Aluno Excluído com sucesso", "Exclusão",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                contador -= double.Parse(dgv_produtos.CurrentRow.Cells["Quant"].Value.ToString())* double.Parse(dgv_produtos.CurrentRow.Cells["Vunita"].Value.ToString());
                //Exibe na label o contador de linhas do GridView atualizado após a remoção
                total.Text = contador.ToString();
                //Remove a linha selecionada do Grid
                dgv_produtos.Rows.RemoveAt(dgv_produtos.CurrentCell.RowIndex); 
                tvendas.Text = dgv_produtos.RowCount.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgv_produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verifica a existência de linhas no Grid
            if (dgv_produtos.RowCount > 0 )
            {
            //Move o conteúdo da primeira célula da linha selecionado para a caixa de texto
             alterar_quantidade.Text = dgv_produtos.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void bt_alterar_Click(object sender, EventArgs e)
        {
            if(alterar_quantidade.Text != "")
            {
                //Move o novo valor da caixa de texto Alteração para a célula selecionada
                dgv_produtos.CurrentRow.Cells[0].Value = alterar_quantidade.Text;
                //Exibe a mensagem de alteração com sucesso
                MessageBox.Show("Aluno Alterado com sucesso", "Exclusão",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bt_finalizar_Click(object sender, EventArgs e)
        {
            //Finaliza a aplicação
            Application.Exit();
        }

        private void bt_gravar_Click(object sender, EventArgs e)
        {
            //Gravar tudo
            dgv_produtos.Rows.Clear();
            contador = 0;
            total.Text = contador.ToString();
            tvendas.Text = dgv_produtos.RowCount.ToString();
            
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            dgv_produtos.Rows.Clear();
            contador = 0;
            total.Text = contador.ToString();
            tvendas.Text = dgv_produtos.RowCount.ToString();
        }
    }
}
