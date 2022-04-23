using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNegocio;
namespace CamadaApresentacao
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void b_InserirC_Click(object sender, EventArgs e)
        {
            if (tb_nome_do_cliente.Text != "" && tb_endereco.Text != "" && tb_cidade.Text != "")
            {

                NCliente.Inserir(tb_nome_do_cliente.Text, tb_endereco.Text
                , tb_cidade.Text);
                MessageBox.Show("Novo Registro Realizado com Sucesso!!", "ajuda do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Limpar textboxs
                tb_nome_do_cliente.Clear();
                tb_endereco.Clear();
                tb_cidade.Clear();
            }
            //Todas caixas de textos vázisa
            else if (tb_nome_do_cliente.Text == "" && tb_endereco.Text == "" && tb_cidade.Text == "")
            {
                MessageBox.Show("Favor preencher os campos");
            }
            //falta preencher dois campos
            else if (tb_nome_do_cliente.Text == "" && tb_endereco.Text == "")
            {
                MessageBox.Show("Favor preencher os campos do nome e a quantidade!!");
            }
            else if (tb_nome_do_cliente.Text == "" && tb_cidade.Text == "")
            {
                MessageBox.Show("Favor preencher os campos do nome e o preço!!");
            }
            else if (tb_endereco.Text == "" && tb_cidade.Text == "")
            {
                MessageBox.Show("Favor preencher os campos de quantidade e o preço!!");
            }
            else if (tb_endereco.Text == "" && tb_nome_do_cliente.Text == "")
            {
                MessageBox.Show("Favor preencher os campos do nome e o preço!!");
            }
            //falta preencher um campo
            else if (tb_nome_do_cliente.Text == "")
            {
                MessageBox.Show("Favor preencher o campo do nome!!");
            }
            else if (tb_endereco.Text == "")
            {
                MessageBox.Show("Favor preencher o campo do preço!!");
            }
            else if (tb_cidade.Text == "")
            {
                MessageBox.Show("Favor preencher o campo da quantidade!!");
            }

        }

        private void b_EditarC_Click(object sender, EventArgs e)
        {
            NCliente.Editar(Convert.ToInt32(tb_codigoC.Text),tb_nome_do_cliente.Text, tb_endereco.Text
                , tb_cidade.Text);
            MessageBox.Show("Registro Editado com Sucesso!!", "ajuda do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Limpar textboxs
            tb_nome_do_cliente.Clear();
            tb_endereco.Clear();
            tb_cidade.Clear();

        }

        private void b_ExcluirC_Click(object sender, EventArgs e)
        {
            if (tb_codigoC.Text != "")
            {
                DialogResult EXCLUIR = MessageBox.Show("Deseja Realmente Excluir o Registro?",
                "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (EXCLUIR == DialogResult.Yes)
                {
                    MessageBox.Show("Registro Excluido com Sucesso!!", "ajuda do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NCliente.Excluir(Convert.ToInt32(tb_codigoC.Text));
                }
            }
            else if (tb_codigoC.Text == "")
            {
                MessageBox.Show("Favor preencher o campo do código!!");
            }
        }

        private void b_ConsultarC_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = NCliente.Mostrar();
            l_exibir_total.Visible = true;
            l_exibir_total.Text = "Total de registros: " + Convert.ToString(dataGridView1.Rows.Count);
        }
    }
}
