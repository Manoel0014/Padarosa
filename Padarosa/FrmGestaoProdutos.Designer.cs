namespace Padarosa
{
    partial class FrmGestaoProdutos
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
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.lblEditarCategoria = new System.Windows.Forms.Label();
            this.cmbEditarCategoria = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbEditarPreco = new System.Windows.Forms.TextBox();
            this.lblEditarNome = new System.Windows.Forms.Label();
            this.lblEditarPreco = new System.Windows.Forms.Label();
            this.txbEditarNome = new System.Windows.Forms.TextBox();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.lblApagar = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.lblCadastroCategoria = new System.Windows.Forms.Label();
            this.cmbCadastrarCategoria = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbCadastrarPreco = new System.Windows.Forms.TextBox();
            this.lblCadastrarPreco = new System.Windows.Forms.Label();
            this.txbCadastrarNome = new System.Windows.Forms.TextBox();
            this.lblCadastroNome = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            this.grbCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.lblEditarCategoria);
            this.grbEditar.Controls.Add(this.cmbEditarCategoria);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbEditarPreco);
            this.grbEditar.Controls.Add(this.lblEditarNome);
            this.grbEditar.Controls.Add(this.lblEditarPreco);
            this.grbEditar.Controls.Add(this.txbEditarNome);
            this.grbEditar.Enabled = false;
            this.grbEditar.Location = new System.Drawing.Point(265, 249);
            this.grbEditar.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grbEditar.Size = new System.Drawing.Size(242, 190);
            this.grbEditar.TabIndex = 6;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // lblEditarCategoria
            // 
            this.lblEditarCategoria.AutoSize = true;
            this.lblEditarCategoria.Location = new System.Drawing.Point(44, 105);
            this.lblEditarCategoria.Name = "lblEditarCategoria";
            this.lblEditarCategoria.Size = new System.Drawing.Size(58, 13);
            this.lblEditarCategoria.TabIndex = 9;
            this.lblEditarCategoria.Text = "Categoria: ";
            // 
            // cmbEditarCategoria
            // 
            this.cmbEditarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditarCategoria.FormattingEnabled = true;
            this.cmbEditarCategoria.Location = new System.Drawing.Point(108, 97);
            this.cmbEditarCategoria.Name = "cmbEditarCategoria";
            this.cmbEditarCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbEditarCategoria.TabIndex = 14;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(62, 137);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(146, 34);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbEditarPreco
            // 
            this.txbEditarPreco.Location = new System.Drawing.Point(108, 69);
            this.txbEditarPreco.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txbEditarPreco.Name = "txbEditarPreco";
            this.txbEditarPreco.Size = new System.Drawing.Size(121, 20);
            this.txbEditarPreco.TabIndex = 12;
            // 
            // lblEditarNome
            // 
            this.lblEditarNome.AutoSize = true;
            this.lblEditarNome.Location = new System.Drawing.Point(14, 44);
            this.lblEditarNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditarNome.Name = "lblEditarNome";
            this.lblEditarNome.Size = new System.Drawing.Size(93, 13);
            this.lblEditarNome.TabIndex = 7;
            this.lblEditarNome.Text = "Nome do Produto:";
            // 
            // lblEditarPreco
            // 
            this.lblEditarPreco.AutoSize = true;
            this.lblEditarPreco.Location = new System.Drawing.Point(59, 72);
            this.lblEditarPreco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditarPreco.Name = "lblEditarPreco";
            this.lblEditarPreco.Size = new System.Drawing.Size(41, 13);
            this.lblEditarPreco.TabIndex = 11;
            this.lblEditarPreco.Text = "Preço: ";
            // 
            // txbEditarNome
            // 
            this.txbEditarNome.Location = new System.Drawing.Point(108, 40);
            this.txbEditarNome.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txbEditarNome.Name = "txbEditarNome";
            this.txbEditarNome.Size = new System.Drawing.Size(121, 20);
            this.txbEditarNome.TabIndex = 8;
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.lblApagar);
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.Location = new System.Drawing.Point(11, 449);
            this.grbApagar.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grbApagar.Size = new System.Drawing.Size(502, 99);
            this.grbApagar.TabIndex = 7;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagar.Location = new System.Drawing.Point(23, 55);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(287, 20);
            this.lblApagar.TabIndex = 1;
            this.lblApagar.Text = "Selecione o produto que deseja apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Crimson;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnApagar.Location = new System.Drawing.Point(354, 44);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(130, 46);
            this.btnApagar.TabIndex = 0;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.lblCadastroCategoria);
            this.grbCadastrar.Controls.Add(this.cmbCadastrarCategoria);
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.txbCadastrarPreco);
            this.grbCadastrar.Controls.Add(this.lblCadastrarPreco);
            this.grbCadastrar.Controls.Add(this.txbCadastrarNome);
            this.grbCadastrar.Controls.Add(this.lblCadastroNome);
            this.grbCadastrar.Location = new System.Drawing.Point(11, 249);
            this.grbCadastrar.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grbCadastrar.Size = new System.Drawing.Size(240, 190);
            this.grbCadastrar.TabIndex = 5;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastro";
            // 
            // lblCadastroCategoria
            // 
            this.lblCadastroCategoria.AutoSize = true;
            this.lblCadastroCategoria.Location = new System.Drawing.Point(36, 105);
            this.lblCadastroCategoria.Name = "lblCadastroCategoria";
            this.lblCadastroCategoria.Size = new System.Drawing.Size(58, 13);
            this.lblCadastroCategoria.TabIndex = 8;
            this.lblCadastroCategoria.Text = "Categoria: ";
            // 
            // cmbCadastrarCategoria
            // 
            this.cmbCadastrarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCadastrarCategoria.FormattingEnabled = true;
            this.cmbCadastrarCategoria.Location = new System.Drawing.Point(98, 97);
            this.cmbCadastrarCategoria.Name = "cmbCadastrarCategoria";
            this.cmbCadastrarCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCadastrarCategoria.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(50, 137);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(146, 34);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbCadastrarPreco
            // 
            this.txbCadastrarPreco.Location = new System.Drawing.Point(98, 69);
            this.txbCadastrarPreco.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txbCadastrarPreco.Name = "txbCadastrarPreco";
            this.txbCadastrarPreco.Size = new System.Drawing.Size(121, 20);
            this.txbCadastrarPreco.TabIndex = 3;
            // 
            // lblCadastrarPreco
            // 
            this.lblCadastrarPreco.AutoSize = true;
            this.lblCadastrarPreco.Location = new System.Drawing.Point(56, 76);
            this.lblCadastrarPreco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCadastrarPreco.Name = "lblCadastrarPreco";
            this.lblCadastrarPreco.Size = new System.Drawing.Size(38, 13);
            this.lblCadastrarPreco.TabIndex = 2;
            this.lblCadastrarPreco.Text = "Preço:";
            // 
            // txbCadastrarNome
            // 
            this.txbCadastrarNome.Location = new System.Drawing.Point(98, 40);
            this.txbCadastrarNome.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txbCadastrarNome.Name = "txbCadastrarNome";
            this.txbCadastrarNome.Size = new System.Drawing.Size(121, 20);
            this.txbCadastrarNome.TabIndex = 1;
            // 
            // lblCadastroNome
            // 
            this.lblCadastroNome.AutoSize = true;
            this.lblCadastroNome.Location = new System.Drawing.Point(4, 43);
            this.lblCadastroNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCadastroNome.Name = "lblCadastroNome";
            this.lblCadastroNome.Size = new System.Drawing.Size(96, 13);
            this.lblCadastroNome.TabIndex = 0;
            this.lblCadastroNome.Text = "Nome do Produto: ";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(5, 14);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(502, 208);
            this.dgvProdutos.TabIndex = 4;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // FrmGestaoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 562);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "FrmGestaoProdutos";
            this.Text = "FrmGestaoProdutos";
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbEditarPreco;
        private System.Windows.Forms.Label lblEditarNome;
        private System.Windows.Forms.Label lblEditarPreco;
        private System.Windows.Forms.TextBox txbEditarNome;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbCadastrarPreco;
        private System.Windows.Forms.Label lblCadastrarPreco;
        private System.Windows.Forms.TextBox txbCadastrarNome;
        private System.Windows.Forms.Label lblCadastroNome;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblEditarCategoria;
        private System.Windows.Forms.ComboBox cmbEditarCategoria;
        private System.Windows.Forms.Label lblCadastroCategoria;
        private System.Windows.Forms.ComboBox cmbCadastrarCategoria;
    }
}