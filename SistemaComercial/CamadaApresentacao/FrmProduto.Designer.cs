
namespace CamadaApresentacao
{
    partial class FrmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.b_Inserir = new System.Windows.Forms.Button();
            this.b_Editar = new System.Windows.Forms.Button();
            this.b_Excluir = new System.Windows.Forms.Button();
            this.b_Consultar = new System.Windows.Forms.Button();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.tb_nome_do_produto = new System.Windows.Forms.TextBox();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.l_exibir_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade";
            // 
            // b_Inserir
            // 
            this.b_Inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Inserir.Location = new System.Drawing.Point(41, 338);
            this.b_Inserir.Name = "b_Inserir";
            this.b_Inserir.Size = new System.Drawing.Size(100, 40);
            this.b_Inserir.TabIndex = 4;
            this.b_Inserir.Text = "Inserir";
            this.b_Inserir.UseVisualStyleBackColor = true;
            this.b_Inserir.Click += new System.EventHandler(this.b_Inserir_Click);
            // 
            // b_Editar
            // 
            this.b_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Editar.Location = new System.Drawing.Point(176, 337);
            this.b_Editar.Name = "b_Editar";
            this.b_Editar.Size = new System.Drawing.Size(100, 40);
            this.b_Editar.TabIndex = 5;
            this.b_Editar.Text = "Editar";
            this.b_Editar.UseVisualStyleBackColor = true;
            this.b_Editar.Click += new System.EventHandler(this.b_Editar_Click);
            // 
            // b_Excluir
            // 
            this.b_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Excluir.Location = new System.Drawing.Point(357, 337);
            this.b_Excluir.Name = "b_Excluir";
            this.b_Excluir.Size = new System.Drawing.Size(100, 40);
            this.b_Excluir.TabIndex = 6;
            this.b_Excluir.Text = "Excluir";
            this.b_Excluir.UseVisualStyleBackColor = true;
            this.b_Excluir.Click += new System.EventHandler(this.b_Excluir_Click);
            // 
            // b_Consultar
            // 
            this.b_Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Consultar.Location = new System.Drawing.Point(694, 337);
            this.b_Consultar.Name = "b_Consultar";
            this.b_Consultar.Size = new System.Drawing.Size(105, 40);
            this.b_Consultar.TabIndex = 7;
            this.b_Consultar.Text = "Consultar";
            this.b_Consultar.UseVisualStyleBackColor = true;
            this.b_Consultar.Click += new System.EventHandler(this.b_Consultar_Click);
            // 
            // tb_codigo
            // 
            this.tb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo.Location = new System.Drawing.Point(70, 77);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(119, 30);
            this.tb_codigo.TabIndex = 8;
            // 
            // tb_nome_do_produto
            // 
            this.tb_nome_do_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome_do_produto.Location = new System.Drawing.Point(70, 166);
            this.tb_nome_do_produto.Name = "tb_nome_do_produto";
            this.tb_nome_do_produto.Size = new System.Drawing.Size(330, 30);
            this.tb_nome_do_produto.TabIndex = 9;
            // 
            // tb_preco
            // 
            this.tb_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_preco.Location = new System.Drawing.Point(70, 250);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(119, 30);
            this.tb_preco.TabIndex = 10;
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_quantidade.Location = new System.Drawing.Point(257, 249);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(119, 30);
            this.tb_quantidade.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(425, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(388, 266);
            this.dataGridView1.TabIndex = 12;
            // 
            // l_exibir_total
            // 
            this.l_exibir_total.AutoSize = true;
            this.l_exibir_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_exibir_total.Location = new System.Drawing.Point(420, 9);
            this.l_exibir_total.Name = "l_exibir_total";
            this.l_exibir_total.Size = new System.Drawing.Size(0, 25);
            this.l_exibir_total.TabIndex = 13;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.l_exibir_total);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_quantidade);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.tb_nome_do_produto);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.b_Consultar);
            this.Controls.Add(this.b_Excluir);
            this.Controls.Add(this.b_Editar);
            this.Controls.Add(this.b_Inserir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmProduto";
            this.Text = "FrmProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_Inserir;
        private System.Windows.Forms.Button b_Editar;
        private System.Windows.Forms.Button b_Excluir;
        private System.Windows.Forms.Button b_Consultar;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_nome_do_produto;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label l_exibir_total;
    }
}