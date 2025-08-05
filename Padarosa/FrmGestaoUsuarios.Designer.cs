namespace Padarosa
{
    partial class FrmGestaoUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.lblCadastroNome = new System.Windows.Forms.Label();
            this.txbCadastrarNome = new System.Windows.Forms.TextBox();
            this.txbCadastrarEmail = new System.Windows.Forms.TextBox();
            this.lblCadastrarEmail = new System.Windows.Forms.Label();
            this.txbCadastrarSenha = new System.Windows.Forms.TextBox();
            this.lblCadastrarSenha = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbEditarSenha = new System.Windows.Forms.TextBox();
            this.lblEditarSenha = new System.Windows.Forms.Label();
            this.txbEditarEmail = new System.Windows.Forms.TextBox();
            this.lblEditarEmail = new System.Windows.Forms.Label();
            this.txbEditarNome = new System.Windows.Forms.TextBox();
            this.lblEditarNome = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblApagar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(22, 12);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(502, 208);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.txbCadastrarSenha);
            this.grbCadastrar.Controls.Add(this.lblCadastrarSenha);
            this.grbCadastrar.Controls.Add(this.txbCadastrarEmail);
            this.grbCadastrar.Controls.Add(this.lblCadastrarEmail);
            this.grbCadastrar.Controls.Add(this.txbCadastrarNome);
            this.grbCadastrar.Controls.Add(this.lblCadastroNome);
            this.grbCadastrar.Location = new System.Drawing.Point(22, 233);
            this.grbCadastrar.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grbCadastrar.Size = new System.Drawing.Size(240, 190);
            this.grbCadastrar.TabIndex = 1;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastro";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.lblApagar);
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.Location = new System.Drawing.Point(22, 450);
            this.grbApagar.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grbApagar.Size = new System.Drawing.Size(502, 99);
            this.grbApagar.TabIndex = 3;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbEditarEmail);
            this.grbEditar.Controls.Add(this.txbEditarSenha);
            this.grbEditar.Controls.Add(this.lblEditarNome);
            this.grbEditar.Controls.Add(this.lblEditarSenha);
            this.grbEditar.Controls.Add(this.txbEditarNome);
            this.grbEditar.Controls.Add(this.lblEditarEmail);
            this.grbEditar.Enabled = false;
            this.grbEditar.Location = new System.Drawing.Point(278, 233);
            this.grbEditar.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grbEditar.Size = new System.Drawing.Size(242, 190);
            this.grbEditar.TabIndex = 2;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // lblCadastroNome
            // 
            this.lblCadastroNome.AutoSize = true;
            this.lblCadastroNome.Location = new System.Drawing.Point(6, 44);
            this.lblCadastroNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCadastroNome.Name = "lblCadastroNome";
            this.lblCadastroNome.Size = new System.Drawing.Size(88, 13);
            this.lblCadastroNome.TabIndex = 0;
            this.lblCadastroNome.Text = "Nome Completo: ";
            // 
            // txbCadastrarNome
            // 
            this.txbCadastrarNome.Location = new System.Drawing.Point(98, 40);
            this.txbCadastrarNome.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txbCadastrarNome.Name = "txbCadastrarNome";
            this.txbCadastrarNome.Size = new System.Drawing.Size(100, 20);
            this.txbCadastrarNome.TabIndex = 1;
            // 
            // txbCadastrarEmail
            // 
            this.txbCadastrarEmail.Location = new System.Drawing.Point(98, 66);
            this.txbCadastrarEmail.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txbCadastrarEmail.Name = "txbCadastrarEmail";
            this.txbCadastrarEmail.Size = new System.Drawing.Size(100, 20);
            this.txbCadastrarEmail.TabIndex = 3;
            // 
            // lblCadastrarEmail
            // 
            this.lblCadastrarEmail.AutoSize = true;
            this.lblCadastrarEmail.Location = new System.Drawing.Point(58, 70);
            this.lblCadastrarEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCadastrarEmail.Name = "lblCadastrarEmail";
            this.lblCadastrarEmail.Size = new System.Drawing.Size(38, 13);
            this.lblCadastrarEmail.TabIndex = 2;
            this.lblCadastrarEmail.Text = "Email: ";
            // 
            // txbCadastrarSenha
            // 
            this.txbCadastrarSenha.Location = new System.Drawing.Point(98, 96);
            this.txbCadastrarSenha.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txbCadastrarSenha.Name = "txbCadastrarSenha";
            this.txbCadastrarSenha.PasswordChar = '▲';
            this.txbCadastrarSenha.Size = new System.Drawing.Size(100, 20);
            this.txbCadastrarSenha.TabIndex = 5;
            // 
            // lblCadastrarSenha
            // 
            this.lblCadastrarSenha.AutoSize = true;
            this.lblCadastrarSenha.Location = new System.Drawing.Point(50, 99);
            this.lblCadastrarSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCadastrarSenha.Name = "lblCadastrarSenha";
            this.lblCadastrarSenha.Size = new System.Drawing.Size(44, 13);
            this.lblCadastrarSenha.TabIndex = 4;
            this.lblCadastrarSenha.Text = "Senha: ";
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
            // txbEditarSenha
            // 
            this.txbEditarSenha.Location = new System.Drawing.Point(108, 96);
            this.txbEditarSenha.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txbEditarSenha.Name = "txbEditarSenha";
            this.txbEditarSenha.Size = new System.Drawing.Size(100, 20);
            this.txbEditarSenha.TabIndex = 12;
            // 
            // lblEditarSenha
            // 
            this.lblEditarSenha.AutoSize = true;
            this.lblEditarSenha.Location = new System.Drawing.Point(58, 99);
            this.lblEditarSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditarSenha.Name = "lblEditarSenha";
            this.lblEditarSenha.Size = new System.Drawing.Size(44, 13);
            this.lblEditarSenha.TabIndex = 11;
            this.lblEditarSenha.Text = "Senha: ";
            // 
            // txbEditarEmail
            // 
            this.txbEditarEmail.Location = new System.Drawing.Point(108, 66);
            this.txbEditarEmail.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txbEditarEmail.Name = "txbEditarEmail";
            this.txbEditarEmail.Size = new System.Drawing.Size(100, 20);
            this.txbEditarEmail.TabIndex = 10;
            // 
            // lblEditarEmail
            // 
            this.lblEditarEmail.AutoSize = true;
            this.lblEditarEmail.Location = new System.Drawing.Point(62, 70);
            this.lblEditarEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditarEmail.Name = "lblEditarEmail";
            this.lblEditarEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEditarEmail.TabIndex = 9;
            this.lblEditarEmail.Text = "Email: ";
            // 
            // txbEditarNome
            // 
            this.txbEditarNome.Location = new System.Drawing.Point(108, 40);
            this.txbEditarNome.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txbEditarNome.Name = "txbEditarNome";
            this.txbEditarNome.Size = new System.Drawing.Size(100, 20);
            this.txbEditarNome.TabIndex = 8;
            // 
            // lblEditarNome
            // 
            this.lblEditarNome.AutoSize = true;
            this.lblEditarNome.Location = new System.Drawing.Point(14, 44);
            this.lblEditarNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditarNome.Name = "lblEditarNome";
            this.lblEditarNome.Size = new System.Drawing.Size(88, 13);
            this.lblEditarNome.TabIndex = 7;
            this.lblEditarNome.Text = "Nome Completo: ";
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
            // FrmGestaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 584);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvUsuarios);
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "FrmGestaoUsuarios";
            this.Text = "FrmGestaoUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.TextBox txbCadastrarEmail;
        private System.Windows.Forms.Label lblCadastrarEmail;
        private System.Windows.Forms.TextBox txbCadastrarNome;
        private System.Windows.Forms.Label lblCadastroNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbCadastrarSenha;
        private System.Windows.Forms.Label lblCadastrarSenha;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbEditarEmail;
        private System.Windows.Forms.TextBox txbEditarSenha;
        private System.Windows.Forms.Label lblEditarNome;
        private System.Windows.Forms.Label lblEditarSenha;
        private System.Windows.Forms.TextBox txbEditarNome;
        private System.Windows.Forms.Label lblEditarEmail;
    }
}