using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//carrega a Camada de Negócio
using CamadaNegocio;
namespace CamadaApresentacao
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void b_Inserir_Click(object sender, EventArgs e)
        {       
            
            if(tb_nome_do_produto.Text != "" && tb_preco.Text != "" && tb_quantidade.Text != "")
            {
                //nome                             //preço       
                NProduto.Inserir(tb_nome_do_produto.Text, Convert.ToDouble(tb_preco.Text)
                , Convert.ToInt32(tb_quantidade.Text));//quantidade
                MessageBox.Show("Novo Registro Realizado com Sucesso!!", "ajuda do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Limpar textboxs
                tb_nome_do_produto.Clear();
                tb_preco.Clear();
                tb_quantidade.Clear();
            }
            //Todas caixas de textos vázisa
            else if  (tb_nome_do_produto.Text == "" && tb_preco.Text == "" && tb_quantidade.Text == "")
            {
                MessageBox.Show("Favor preencher os campos");
            }
            //falta preencher dois campos
            else if (tb_nome_do_produto.Text == "" && tb_quantidade.Text == "")
            {
                MessageBox.Show("Favor preencher os campos do nome e a quantidade!!");
            }
            else if (tb_nome_do_produto.Text == "" && tb_preco.Text == "")
            {
                MessageBox.Show("Favor preencher os campos do nome e o preço!!");
            }
            else if ( tb_preco.Text == "" && tb_quantidade.Text == "")
            {
                MessageBox.Show("Favor preencher os campos de quantidade e o preço!!");
            }
            else if (tb_preco.Text == "" && tb_nome_do_produto.Text == "")
            {
                MessageBox.Show("Favor preencher os campos do nome e o preço!!");
            }
            //falta preencher um campo
            else if (tb_nome_do_produto.Text == "" )
            {
                MessageBox.Show("Favor preencher o campo do nome!!");
            }
            else if (tb_preco.Text == "")
            {
                MessageBox.Show("Favor preencher o campo do preço!!");
            }
            else if (tb_quantidade.Text == "")
            {
                MessageBox.Show("Favor preencher o campo da quantidade!!");
            }





        }

        private void b_Consultar_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = NProduto.Mostrar();
            l_exibir_total.Visible = true;
            l_exibir_total.Text = "Total de registros: " + Convert.ToString(dataGridView1.Rows.Count);
        }

        private void b_Editar_Click(object sender, EventArgs e)
        {
            NProduto.Editar(Convert.ToInt32(tb_codigo.Text),
               tb_nome_do_produto.Text, Convert.ToDouble(tb_preco.Text), 
               Convert.ToInt32(tb_quantidade.Text));
            MessageBox.Show("Registro Editado com Sucesso!!", "ajuda do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Limpar textboxs
            tb_nome_do_produto.Clear();
            tb_preco.Clear();
            tb_quantidade.Clear();

        }

        private void b_Excluir_Click(object sender, EventArgs e)
        {
            if (tb_codigo.Text != "")
            {
                DialogResult EXCLUIR = MessageBox.Show("Deseja Realmente Excluir o Registro?",
                "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (EXCLUIR == DialogResult.Yes)
                {
                    MessageBox.Show("Registro Excluido com Sucesso!!", "ajuda do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NProduto.Excluir(Convert.ToInt32(tb_codigo.Text));
                }
            }
            else if (tb_codigo.Text == "")
            {
                MessageBox.Show("Favor preencher o campo do código!!");
            }
        }
    }
}
