namespace Padarosa
{
    partial class FrmCaixa
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
            this.lblNdeCaixa = new System.Windows.Forms.Label();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.dgvComanda = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.cbxPagamentoRecebido = new System.Windows.Forms.CheckBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnEncerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNdeCaixa
            // 
            this.lblNdeCaixa.AutoSize = true;
            this.lblNdeCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNdeCaixa.Location = new System.Drawing.Point(192, 22);
            this.lblNdeCaixa.Name = "lblNdeCaixa";
            this.lblNdeCaixa.Size = new System.Drawing.Size(167, 31);
            this.lblNdeCaixa.TabIndex = 0;
            this.lblNdeCaixa.Text = "N° de caixa: ";
            // 
            // txbComanda
            // 
            this.txbComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(365, 12);
            this.txbComanda.Multiline = true;
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(131, 49);
            this.txbComanda.TabIndex = 1;
            // 
            // dgvComanda
            // 
            this.dgvComanda.AllowUserToAddRows = false;
            this.dgvComanda.AllowUserToDeleteRows = false;
            this.dgvComanda.AllowUserToResizeColumns = false;
            this.dgvComanda.AllowUserToResizeRows = false;
            this.dgvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComanda.Location = new System.Drawing.Point(13, 93);
            this.dgvComanda.Name = "dgvComanda";
            this.dgvComanda.Size = new System.Drawing.Size(748, 209);
            this.dgvComanda.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(514, 12);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(118, 49);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // cbxPagamentoRecebido
            // 
            this.cbxPagamentoRecebido.AutoSize = true;
            this.cbxPagamentoRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPagamentoRecebido.Location = new System.Drawing.Point(533, 354);
            this.cbxPagamentoRecebido.Name = "cbxPagamentoRecebido";
            this.cbxPagamentoRecebido.Size = new System.Drawing.Size(218, 29);
            this.cbxPagamentoRecebido.TabIndex = 4;
            this.cbxPagamentoRecebido.Text = "Pagamento Recebido";
            this.cbxPagamentoRecebido.UseVisualStyleBackColor = true;
            this.cbxPagamentoRecebido.CheckedChanged += new System.EventHandler(this.cbxPagamentoRecebido_CheckedChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(546, 314);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(0, 31);
            this.lblValor.TabIndex = 5;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Enabled = false;
            this.btnEncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.Location = new System.Drawing.Point(533, 389);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(218, 33);
            this.btnEncerrar.TabIndex = 6;
            this.btnEncerrar.Text = "Encerrar Comanda";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.cbxPagamentoRecebido);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvComanda);
            this.Controls.Add(this.txbComanda);
            this.Controls.Add(this.lblNdeCaixa);
            this.Name = "FrmCaixa";
            this.Text = "FrmCaixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNdeCaixa;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.DataGridView dgvComanda;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.CheckBox cbxPagamentoRecebido;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnEncerrar;
    }
}