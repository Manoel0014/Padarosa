namespace Padarosa
{
    partial class FrmComandas
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbLancamentos = new System.Windows.Forms.GroupBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.txbLancaProduto = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblLancaProdutos = new System.Windows.Forms.Label();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txbInforProduto = new System.Windows.Forms.TextBox();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblComanda = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbLancamentos.SuspendLayout();
            this.grbInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(338, 12);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(366, 426);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // grbLancamentos
            // 
            this.grbLancamentos.Controls.Add(this.btnCancelar);
            this.grbLancamentos.Controls.Add(this.btnLancar);
            this.grbLancamentos.Controls.Add(this.txbQuantidade);
            this.grbLancamentos.Controls.Add(this.txbLancaProduto);
            this.grbLancamentos.Controls.Add(this.lblQuantidade);
            this.grbLancamentos.Controls.Add(this.lblLancaProdutos);
            this.grbLancamentos.Enabled = false;
            this.grbLancamentos.Location = new System.Drawing.Point(12, 233);
            this.grbLancamentos.Name = "grbLancamentos";
            this.grbLancamentos.Size = new System.Drawing.Size(312, 196);
            this.grbLancamentos.TabIndex = 1;
            this.grbLancamentos.TabStop = false;
            this.grbLancamentos.Text = "Lançamentos";
            // 
            // btnLancar
            // 
            this.btnLancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.Location = new System.Drawing.Point(40, 113);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(231, 35);
            this.btnLancar.TabIndex = 5;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidade.Location = new System.Drawing.Point(149, 78);
            this.txbQuantidade.Multiline = true;
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(122, 29);
            this.txbQuantidade.TabIndex = 3;
            // 
            // txbLancaProduto
            // 
            this.txbLancaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLancaProduto.Location = new System.Drawing.Point(149, 30);
            this.txbLancaProduto.Multiline = true;
            this.txbLancaProduto.Name = "txbLancaProduto";
            this.txbLancaProduto.Size = new System.Drawing.Size(122, 29);
            this.txbLancaProduto.TabIndex = 2;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(55, 85);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(86, 17);
            this.lblQuantidade.TabIndex = 1;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblLancaProdutos
            // 
            this.lblLancaProdutos.AutoSize = true;
            this.lblLancaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLancaProdutos.Location = new System.Drawing.Point(74, 37);
            this.lblLancaProdutos.Name = "lblLancaProdutos";
            this.lblLancaProdutos.Size = new System.Drawing.Size(69, 17);
            this.lblLancaProdutos.TabIndex = 0;
            this.lblLancaProdutos.Text = "Produtos:";
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.btnContinuar);
            this.grbInformacoes.Controls.Add(this.txbInforProduto);
            this.grbInformacoes.Controls.Add(this.txbComanda);
            this.grbInformacoes.Controls.Add(this.lblProduto);
            this.grbInformacoes.Controls.Add(this.lblComanda);
            this.grbInformacoes.Location = new System.Drawing.Point(12, 12);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(312, 200);
            this.grbInformacoes.TabIndex = 2;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(40, 149);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(231, 35);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txbInforProduto
            // 
            this.txbInforProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInforProduto.Location = new System.Drawing.Point(150, 94);
            this.txbInforProduto.Multiline = true;
            this.txbInforProduto.Name = "txbInforProduto";
            this.txbInforProduto.ReadOnly = true;
            this.txbInforProduto.Size = new System.Drawing.Size(121, 38);
            this.txbInforProduto.TabIndex = 3;
            // 
            // txbComanda
            // 
            this.txbComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(150, 46);
            this.txbComanda.Multiline = true;
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(121, 38);
            this.txbComanda.TabIndex = 2;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(53, 97);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(91, 25);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto: ";
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(35, 59);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(109, 25);
            this.lblComanda.TabIndex = 0;
            this.lblComanda.Text = "Comanda: ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(40, 154);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(231, 35);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.grbLancamentos);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "FrmComandas";
            this.Text = "FrmComandas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbLancamentos.ResumeLayout(false);
            this.grbLancamentos.PerformLayout();
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbLancamentos;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.Label lblLancaProdutos;
        private System.Windows.Forms.TextBox txbInforProduto;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TextBox txbLancaProduto;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Button btnCancelar;
    }
}