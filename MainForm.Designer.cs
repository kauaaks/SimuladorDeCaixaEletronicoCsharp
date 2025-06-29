namespace CaixaEletronico
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblNotas100 = new System.Windows.Forms.Label();
            this.lblNotas50 = new System.Windows.Forms.Label();
            this.lblNotas20 = new System.Windows.Forms.Label();
            this.lblNotas10 = new System.Windows.Forms.Label();
            this.lblTotalCaixa = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(100, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Caixa Eletrônico DS";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(30, 60);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(85, 17);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "Saldo: R$ 0";
            // 
            // lblNotas100
            // 
            this.lblNotas100.AutoSize = true;
            this.lblNotas100.Location = new System.Drawing.Point(30, 100);
            this.lblNotas100.Name = "lblNotas100";
            this.lblNotas100.Size = new System.Drawing.Size(58, 13);
            this.lblNotas100.TabIndex = 2;
            this.lblNotas100.Text = "R$ 100: 20";
            // 
            // lblNotas50
            // 
            this.lblNotas50.AutoSize = true;
            this.lblNotas50.Location = new System.Drawing.Point(30, 120);
            this.lblNotas50.Name = "lblNotas50";
            this.lblNotas50.Size = new System.Drawing.Size(52, 13);
            this.lblNotas50.TabIndex = 3;
            this.lblNotas50.Text = "R$ 50: 20";
            // 
            // lblNotas20
            // 
            this.lblNotas20.AutoSize = true;
            this.lblNotas20.Location = new System.Drawing.Point(30, 140);
            this.lblNotas20.Name = "lblNotas20";
            this.lblNotas20.Size = new System.Drawing.Size(52, 13);
            this.lblNotas20.TabIndex = 4;
            this.lblNotas20.Text = "R$ 20: 25";
            // 
            // lblNotas10
            // 
            this.lblNotas10.AutoSize = true;
            this.lblNotas10.Location = new System.Drawing.Point(30, 160);
            this.lblNotas10.Name = "lblNotas10";
            this.lblNotas10.Size = new System.Drawing.Size(52, 13);
            this.lblNotas10.TabIndex = 5;
            this.lblNotas10.Text = "R$ 10: 30";
            // 
            // lblTotalCaixa
            // 
            this.lblTotalCaixa.AutoSize = true;
            this.lblTotalCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCaixa.Location = new System.Drawing.Point(30, 190);
            this.lblTotalCaixa.Name = "lblTotalCaixa";
            this.lblTotalCaixa.Size = new System.Drawing.Size(119, 17);
            this.lblTotalCaixa.TabIndex = 6;
            this.lblTotalCaixa.Text = "Total no Caixa: R$";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(30, 230);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 7;
            this.lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(70, 227);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 8;
            // 
            // btnSaque
            // 
            this.btnSaque.Location = new System.Drawing.Point(180, 225);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(75, 23);
            this.btnSaque.TabIndex = 9;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(180, 255);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(75, 23);
            this.btnDeposito.TabIndex = 10;
            this.btnDeposito.Text = "Depósito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(180, 285);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 330);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnSaque);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblTotalCaixa);
            this.Controls.Add(this.lblNotas10);
            this.Controls.Add(this.lblNotas20);
            this.Controls.Add(this.lblNotas50);
            this.Controls.Add(this.lblNotas100);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "MainForm";
            this.Text = "Caixa Eletrônico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblNotas100;
        private System.Windows.Forms.Label lblNotas50;
        private System.Windows.Forms.Label lblNotas20;
        private System.Windows.Forms.Label lblNotas10;
        private System.Windows.Forms.Label lblTotalCaixa;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnLimpar;
    }
}
