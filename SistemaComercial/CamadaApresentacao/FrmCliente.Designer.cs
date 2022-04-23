
namespace CamadaApresentacao
{
    partial class FrmCliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.tb_nome_do_cliente = new System.Windows.Forms.TextBox();
            this.tb_codigoC = new System.Windows.Forms.TextBox();
            this.b_ConsultarC = new System.Windows.Forms.Button();
            this.b_ExcluirC = new System.Windows.Forms.Button();
            this.b_EditarC = new System.Windows.Forms.Button();
            this.b_InserirC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.l_exibir_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(398, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(388, 266);
            this.dataGridView1.TabIndex = 25;
            // 
            // tb_cidade
            // 
            this.tb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cidade.Location = new System.Drawing.Point(41, 311);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(182, 30);
            this.tb_cidade.TabIndex = 24;
            // 
            // tb_endereco
            // 
            this.tb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_endereco.Location = new System.Drawing.Point(45, 223);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(326, 30);
            this.tb_endereco.TabIndex = 23;
            // 
            // tb_nome_do_cliente
            // 
            this.tb_nome_do_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome_do_cliente.Location = new System.Drawing.Point(41, 139);
            this.tb_nome_do_cliente.Name = "tb_nome_do_cliente";
            this.tb_nome_do_cliente.Size = new System.Drawing.Size(330, 30);
            this.tb_nome_do_cliente.TabIndex = 22;
            // 
            // tb_codigoC
            // 
            this.tb_codigoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigoC.Location = new System.Drawing.Point(43, 56);
            this.tb_codigoC.Name = "tb_codigoC";
            this.tb_codigoC.Size = new System.Drawing.Size(119, 30);
            this.tb_codigoC.TabIndex = 21;
            // 
            // b_ConsultarC
            // 
            this.b_ConsultarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ConsultarC.Location = new System.Drawing.Point(649, 369);
            this.b_ConsultarC.Name = "b_ConsultarC";
            this.b_ConsultarC.Size = new System.Drawing.Size(124, 40);
            this.b_ConsultarC.TabIndex = 20;
            this.b_ConsultarC.Text = "Consultar";
            this.b_ConsultarC.UseVisualStyleBackColor = true;
            this.b_ConsultarC.Click += new System.EventHandler(this.b_ConsultarC_Click);
            // 
            // b_ExcluirC
            // 
            this.b_ExcluirC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ExcluirC.Location = new System.Drawing.Point(334, 369);
            this.b_ExcluirC.Name = "b_ExcluirC";
            this.b_ExcluirC.Size = new System.Drawing.Size(100, 40);
            this.b_ExcluirC.TabIndex = 19;
            this.b_ExcluirC.Text = "Excluir";
            this.b_ExcluirC.UseVisualStyleBackColor = true;
            this.b_ExcluirC.Click += new System.EventHandler(this.b_ExcluirC_Click);
            // 
            // b_EditarC
            // 
            this.b_EditarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_EditarC.Location = new System.Drawing.Point(153, 369);
            this.b_EditarC.Name = "b_EditarC";
            this.b_EditarC.Size = new System.Drawing.Size(100, 40);
            this.b_EditarC.TabIndex = 18;
            this.b_EditarC.Text = "Editar";
            this.b_EditarC.UseVisualStyleBackColor = true;
            this.b_EditarC.Click += new System.EventHandler(this.b_EditarC_Click);
            // 
            // b_InserirC
            // 
            this.b_InserirC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_InserirC.Location = new System.Drawing.Point(18, 370);
            this.b_InserirC.Name = "b_InserirC";
            this.b_InserirC.Size = new System.Drawing.Size(100, 40);
            this.b_InserirC.TabIndex = 17;
            this.b_InserirC.Text = "Inserir";
            this.b_InserirC.UseVisualStyleBackColor = true;
            this.b_InserirC.Click += new System.EventHandler(this.b_InserirC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome do Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código";
            // 
            // l_exibir_total
            // 
            this.l_exibir_total.AutoSize = true;
            this.l_exibir_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_exibir_total.Location = new System.Drawing.Point(393, 26);
            this.l_exibir_total.Name = "l_exibir_total";
            this.l_exibir_total.Size = new System.Drawing.Size(0, 25);
            this.l_exibir_total.TabIndex = 26;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_exibir_total);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_cidade);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.tb_nome_do_cliente);
            this.Controls.Add(this.tb_codigoC);
            this.Controls.Add(this.b_ConsultarC);
            this.Controls.Add(this.b_ExcluirC);
            this.Controls.Add(this.b_EditarC);
            this.Controls.Add(this.b_InserirC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.TextBox tb_nome_do_cliente;
        private System.Windows.Forms.TextBox tb_codigoC;
        private System.Windows.Forms.Button b_ConsultarC;
        private System.Windows.Forms.Button b_ExcluirC;
        private System.Windows.Forms.Button b_EditarC;
        private System.Windows.Forms.Button b_InserirC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_exibir_total;
    }
}