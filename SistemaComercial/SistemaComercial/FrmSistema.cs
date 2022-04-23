using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///carrega a Camada de Apresentação
using CamadaApresentacao;

namespace SistemaComercial
{
    public partial class FrmSistema : Form
    {
        public FrmSistema()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto formularioproduto = new FrmProduto();
            formularioproduto.Show();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente formulariocliente = new FrmCliente();
            formulariocliente.Show();
        }
    }
}
