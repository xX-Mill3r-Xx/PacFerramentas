namespace Ferramentasuteis.UI
{
    partial class FrmGeradorDeSenhas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeradorDeSenhas));
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnFundoTitulo = new System.Windows.Forms.Panel();
            this.tlpTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.gbSenha = new System.Windows.Forms.GroupBox();
            this.btnCopiarSenha = new System.Windows.Forms.Button();
            this.lbSenha = new System.Windows.Forms.Label();
            this.gbConfiguracoes = new System.Windows.Forms.GroupBox();
            this.lbForcaSenha = new System.Windows.Forms.Label();
            this.cbForcaSenha = new System.Windows.Forms.ComboBox();
            this.pnOpcoes = new System.Windows.Forms.Panel();
            this.btnGerar = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            this.pnFundoTitulo.SuspendLayout();
            this.tlpTitulo.SuspendLayout();
            this.pnPrincipal.SuspendLayout();
            this.gbSenha.SuspendLayout();
            this.gbConfiguracoes.SuspendLayout();
            this.pnOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.Controls.Add(this.pnFundoTitulo, 0, 0);
            this.tlpPrincipal.Controls.Add(this.pnPrincipal, 0, 1);
            this.tlpPrincipal.Controls.Add(this.pnOpcoes, 0, 2);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 3;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpPrincipal.Size = new System.Drawing.Size(389, 233);
            this.tlpPrincipal.TabIndex = 1;
            // 
            // pnFundoTitulo
            // 
            this.pnFundoTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tlpPrincipal.SetColumnSpan(this.pnFundoTitulo, 2);
            this.pnFundoTitulo.Controls.Add(this.tlpTitulo);
            this.pnFundoTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFundoTitulo.Location = new System.Drawing.Point(4, 3);
            this.pnFundoTitulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnFundoTitulo.Name = "pnFundoTitulo";
            this.pnFundoTitulo.Size = new System.Drawing.Size(381, 29);
            this.pnFundoTitulo.TabIndex = 0;
            // 
            // tlpTitulo
            // 
            this.tlpTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.tlpTitulo.ColumnCount = 3;
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitulo.Controls.Add(this.lbTitulo, 1, 0);
            this.tlpTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitulo.Location = new System.Drawing.Point(0, 0);
            this.tlpTitulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tlpTitulo.Name = "tlpTitulo";
            this.tlpTitulo.RowCount = 1;
            this.tlpTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitulo.Size = new System.Drawing.Size(381, 29);
            this.tlpTitulo.TabIndex = 0;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(22, 0);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(146, 21);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Gerador de senhas";
            // 
            // pnPrincipal
            // 
            this.tlpPrincipal.SetColumnSpan(this.pnPrincipal, 2);
            this.pnPrincipal.Controls.Add(this.gbSenha);
            this.pnPrincipal.Controls.Add(this.gbConfiguracoes);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(4, 38);
            this.pnPrincipal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(381, 146);
            this.pnPrincipal.TabIndex = 1;
            // 
            // gbSenha
            // 
            this.gbSenha.Controls.Add(this.btnCopiarSenha);
            this.gbSenha.Controls.Add(this.lbSenha);
            this.gbSenha.Location = new System.Drawing.Point(7, 77);
            this.gbSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbSenha.Name = "gbSenha";
            this.gbSenha.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbSenha.Size = new System.Drawing.Size(366, 66);
            this.gbSenha.TabIndex = 2;
            this.gbSenha.TabStop = false;
            this.gbSenha.Text = "Senha";
            // 
            // btnCopiarSenha
            // 
            this.btnCopiarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopiarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopiarSenha.Image = global::Ferramentasuteis.Properties.Resources.Copy;
            this.btnCopiarSenha.Location = new System.Drawing.Point(328, 22);
            this.btnCopiarSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCopiarSenha.Name = "btnCopiarSenha";
            this.btnCopiarSenha.Size = new System.Drawing.Size(31, 37);
            this.btnCopiarSenha.TabIndex = 1;
            this.btnCopiarSenha.UseVisualStyleBackColor = true;
            this.btnCopiarSenha.Click += new System.EventHandler(this.btnCopiarSenha_Click);
            // 
            // lbSenha
            // 
            this.lbSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(8, 32);
            this.lbSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(313, 24);
            this.lbSenha.TabIndex = 0;
            // 
            // gbConfiguracoes
            // 
            this.gbConfiguracoes.Controls.Add(this.lbForcaSenha);
            this.gbConfiguracoes.Controls.Add(this.cbForcaSenha);
            this.gbConfiguracoes.Location = new System.Drawing.Point(7, 4);
            this.gbConfiguracoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbConfiguracoes.Name = "gbConfiguracoes";
            this.gbConfiguracoes.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbConfiguracoes.Size = new System.Drawing.Size(366, 66);
            this.gbConfiguracoes.TabIndex = 0;
            this.gbConfiguracoes.TabStop = false;
            this.gbConfiguracoes.Text = "Configurações";
            // 
            // lbForcaSenha
            // 
            this.lbForcaSenha.AutoSize = true;
            this.lbForcaSenha.Location = new System.Drawing.Point(7, 42);
            this.lbForcaSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbForcaSenha.Name = "lbForcaSenha";
            this.lbForcaSenha.Size = new System.Drawing.Size(89, 15);
            this.lbForcaSenha.TabIndex = 1;
            this.lbForcaSenha.Text = "Força da senha:";
            // 
            // cbForcaSenha
            // 
            this.cbForcaSenha.FormattingEnabled = true;
            this.cbForcaSenha.Location = new System.Drawing.Point(118, 32);
            this.cbForcaSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbForcaSenha.Name = "cbForcaSenha";
            this.cbForcaSenha.Size = new System.Drawing.Size(241, 23);
            this.cbForcaSenha.TabIndex = 0;
            // 
            // pnOpcoes
            // 
            this.tlpPrincipal.SetColumnSpan(this.pnOpcoes, 2);
            this.pnOpcoes.Controls.Add(this.btnGerar);
            this.pnOpcoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnOpcoes.Location = new System.Drawing.Point(4, 190);
            this.pnOpcoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnOpcoes.Name = "pnOpcoes";
            this.pnOpcoes.Size = new System.Drawing.Size(381, 40);
            this.pnOpcoes.TabIndex = 2;
            // 
            // btnGerar
            // 
            this.btnGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerar.Location = new System.Drawing.Point(282, 7);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(88, 27);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // FrmGeradorDeSenhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 233);
            this.Controls.Add(this.tlpPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmGeradorDeSenhas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmGeradorDeSenhas_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.pnFundoTitulo.ResumeLayout(false);
            this.tlpTitulo.ResumeLayout(false);
            this.tlpTitulo.PerformLayout();
            this.pnPrincipal.ResumeLayout(false);
            this.gbSenha.ResumeLayout(false);
            this.gbConfiguracoes.ResumeLayout(false);
            this.gbConfiguracoes.PerformLayout();
            this.pnOpcoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnFundoTitulo;
        private System.Windows.Forms.TableLayoutPanel tlpTitulo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.GroupBox gbSenha;
        private System.Windows.Forms.Button btnCopiarSenha;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.GroupBox gbConfiguracoes;
        private System.Windows.Forms.Label lbForcaSenha;
        private System.Windows.Forms.ComboBox cbForcaSenha;
        private System.Windows.Forms.Panel pnOpcoes;
        private System.Windows.Forms.Button btnGerar;
    }
}