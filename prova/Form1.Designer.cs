namespace prova
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVenda = new System.Windows.Forms.Label();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.lblQntd = new System.Windows.Forms.Label();
            this.produto = new System.Windows.Forms.TextBox();
            this.V = new System.Windows.Forms.Label();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.txtv_unitario = new System.Windows.Forms.TextBox();
            this.bt_inserir = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.Produ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vunita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.Label();
            this.alterar_quantidade = new System.Windows.Forms.TextBox();
            this.bt_alterar = new System.Windows.Forms.Button();
            this.oloco_total = new System.Windows.Forms.Label();
            this.bt_gravar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_finalizar = new System.Windows.Forms.Button();
            this.venda = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.tvendas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Location = new System.Drawing.Point(162, 35);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(41, 13);
            this.lblVenda.TabIndex = 0;
            this.lblVenda.Text = "Venda:";
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Location = new System.Drawing.Point(162, 73);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(47, 13);
            this.lblProdutos.TabIndex = 1;
            this.lblProdutos.Text = "Produto:";
            // 
            // lblQntd
            // 
            this.lblQntd.AutoSize = true;
            this.lblQntd.Location = new System.Drawing.Point(144, 109);
            this.lblQntd.Name = "lblQntd";
            this.lblQntd.Size = new System.Drawing.Size(65, 13);
            this.lblQntd.TabIndex = 2;
            this.lblQntd.Text = "Quantidade:";
            // 
            // produto
            // 
            this.produto.Location = new System.Drawing.Point(234, 70);
            this.produto.Name = "produto";
            this.produto.Size = new System.Drawing.Size(510, 20);
            this.produto.TabIndex = 3;
            // 
            // V
            // 
            this.V.AutoSize = true;
            this.V.Location = new System.Drawing.Point(136, 144);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(73, 13);
            this.V.TabIndex = 4;
            this.V.Text = "Valor Unitário:";
            this.V.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(234, 106);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(139, 20);
            this.txtquantidade.TabIndex = 5;
            // 
            // txtv_unitario
            // 
            this.txtv_unitario.Location = new System.Drawing.Point(234, 137);
            this.txtv_unitario.Name = "txtv_unitario";
            this.txtv_unitario.Size = new System.Drawing.Size(139, 20);
            this.txtv_unitario.TabIndex = 6;
            // 
            // bt_inserir
            // 
            this.bt_inserir.Location = new System.Drawing.Point(465, 98);
            this.bt_inserir.Name = "bt_inserir";
            this.bt_inserir.Size = new System.Drawing.Size(122, 59);
            this.bt_inserir.TabIndex = 7;
            this.bt_inserir.Text = "Inseir";
            this.bt_inserir.UseVisualStyleBackColor = true;
            this.bt_inserir.Click += new System.EventHandler(this.bt_inserir_Click);
            // 
            // bt_remover
            // 
            this.bt_remover.Location = new System.Drawing.Point(629, 98);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(115, 59);
            this.bt_remover.TabIndex = 8;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = true;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.AllowUserToAddRows = false;
            this.dgv_produtos.AllowUserToDeleteRows = false;
            this.dgv_produtos.AllowUserToOrderColumns = true;
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produ,
            this.Quant,
            this.Vunita});
            this.dgv_produtos.Location = new System.Drawing.Point(139, 194);
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.ReadOnly = true;
            this.dgv_produtos.Size = new System.Drawing.Size(605, 297);
            this.dgv_produtos.TabIndex = 9;
            this.dgv_produtos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_produtos_CellClick);
            this.dgv_produtos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Produ
            // 
            this.Produ.HeaderText = "Produto";
            this.Produ.Name = "Produ";
            this.Produ.ReadOnly = true;
            // 
            // Quant
            // 
            this.Quant.HeaderText = "Quantidade";
            this.Quant.Name = "Quant";
            this.Quant.ReadOnly = true;
            // 
            // Vunita
            // 
            this.Vunita.HeaderText = "V.Unitário";
            this.Vunita.Name = "Vunita";
            this.Vunita.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.AutoSize = true;
            this.Value.Location = new System.Drawing.Point(136, 552);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(198, 13);
            this.Value.TabIndex = 10;
            this.Value.Text = "Alterar Quantidade do item selecionado: ";
            this.Value.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // alterar_quantidade
            // 
            this.alterar_quantidade.Location = new System.Drawing.Point(350, 549);
            this.alterar_quantidade.Name = "alterar_quantidade";
            this.alterar_quantidade.Size = new System.Drawing.Size(118, 20);
            this.alterar_quantidade.TabIndex = 11;
            // 
            // bt_alterar
            // 
            this.bt_alterar.Location = new System.Drawing.Point(506, 546);
            this.bt_alterar.Name = "bt_alterar";
            this.bt_alterar.Size = new System.Drawing.Size(130, 24);
            this.bt_alterar.TabIndex = 12;
            this.bt_alterar.Text = "Alterar Quantidade";
            this.bt_alterar.UseVisualStyleBackColor = true;
            this.bt_alterar.Click += new System.EventHandler(this.bt_alterar_Click);
            // 
            // oloco_total
            // 
            this.oloco_total.AutoSize = true;
            this.oloco_total.Location = new System.Drawing.Point(136, 606);
            this.oloco_total.Name = "oloco_total";
            this.oloco_total.Size = new System.Drawing.Size(83, 13);
            this.oloco_total.TabIndex = 13;
            this.oloco_total.Text = "Total da Venda:";
            // 
            // bt_gravar
            // 
            this.bt_gravar.Location = new System.Drawing.Point(139, 696);
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.Size = new System.Drawing.Size(122, 59);
            this.bt_gravar.TabIndex = 14;
            this.bt_gravar.Text = "Gravar Venda";
            this.bt_gravar.UseVisualStyleBackColor = true;
            this.bt_gravar.Click += new System.EventHandler(this.bt_gravar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(327, 696);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(122, 59);
            this.bt_cancelar.TabIndex = 15;
            this.bt_cancelar.Text = "Cancelar Venda";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_finalizar
            // 
            this.bt_finalizar.Location = new System.Drawing.Point(514, 696);
            this.bt_finalizar.Name = "bt_finalizar";
            this.bt_finalizar.Size = new System.Drawing.Size(122, 59);
            this.bt_finalizar.TabIndex = 16;
            this.bt_finalizar.Text = "Finalizar Sistema";
            this.bt_finalizar.UseVisualStyleBackColor = true;
            // 
            // venda
            // 
            this.venda.AutoSize = true;
            this.venda.Location = new System.Drawing.Point(247, 606);
            this.venda.Name = "venda";
            this.venda.Size = new System.Drawing.Size(0, 13);
            this.venda.TabIndex = 17;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(231, 606);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 13);
            this.total.TabIndex = 18;
            // 
            // tvendas
            // 
            this.tvendas.AutoSize = true;
            this.tvendas.Location = new System.Drawing.Point(247, 35);
            this.tvendas.Name = "tvendas";
            this.tvendas.Size = new System.Drawing.Size(0, 13);
            this.tvendas.TabIndex = 19;
            this.tvendas.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 851);
            this.Controls.Add(this.tvendas);
            this.Controls.Add(this.total);
            this.Controls.Add(this.venda);
            this.Controls.Add(this.bt_finalizar);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_gravar);
            this.Controls.Add(this.oloco_total);
            this.Controls.Add(this.bt_alterar);
            this.Controls.Add(this.alterar_quantidade);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.dgv_produtos);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.bt_inserir);
            this.Controls.Add(this.txtv_unitario);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.V);
            this.Controls.Add(this.produto);
            this.Controls.Add(this.lblQntd);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.lblVenda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Label lblQntd;
        private System.Windows.Forms.TextBox produto;
        private System.Windows.Forms.Label V;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.TextBox txtv_unitario;
        private System.Windows.Forms.Button bt_inserir;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.Label Value;
        private System.Windows.Forms.TextBox alterar_quantidade;
        private System.Windows.Forms.Button bt_alterar;
        private System.Windows.Forms.Label oloco_total;
        private System.Windows.Forms.Button bt_gravar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_finalizar;
        private System.Windows.Forms.Label venda;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vunita;
        private System.Windows.Forms.Label tvendas;
    }
}

