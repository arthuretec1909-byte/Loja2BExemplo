namespace Loja2BExemplo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalcular = new Button();
            lblIdadeCliente = new Label();
            lblStatus = new Label();
            lblParcela = new Label();
            lblValorFinal = new Label();
            lblDesconto = new Label();
            lblResultadoNome = new Label();
            lblQuantidade = new Label();
            lblPrecoUnitario = new Label();
            lblNomeDoce = new Label();
            txtIdadeCliente = new TextBox();
            txtQuantidade = new TextBox();
            txtPrecoUnitario = new TextBox();
            txtNomeDoce = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(246, 385);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(154, 44);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click_1;
            // 
            // lblIdadeCliente
            // 
            lblIdadeCliente.AutoSize = true;
            lblIdadeCliente.Location = new Point(105, 175);
            lblIdadeCliente.Name = "lblIdadeCliente";
            lblIdadeCliente.Size = new Size(97, 20);
            lblIdadeCliente.TabIndex = 1;
            lblIdadeCliente.Text = "Idade Cliente";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(105, 369);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status";
            // 
            // lblParcela
            // 
            lblParcela.AutoSize = true;
            lblParcela.Location = new Point(105, 334);
            lblParcela.Name = "lblParcela";
            lblParcela.Size = new Size(56, 20);
            lblParcela.TabIndex = 3;
            lblParcela.Text = "Parcela";
            // 
            // lblValorFinal
            // 
            lblValorFinal.AutoSize = true;
            lblValorFinal.Location = new Point(105, 291);
            lblValorFinal.Name = "lblValorFinal";
            lblValorFinal.Size = new Size(78, 20);
            lblValorFinal.TabIndex = 4;
            lblValorFinal.Text = "Valor Final";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(105, 253);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(72, 20);
            lblDesconto.TabIndex = 5;
            lblDesconto.Text = "Desconto";
            // 
            // lblResultadoNome
            // 
            lblResultadoNome.AutoSize = true;
            lblResultadoNome.Location = new Point(105, 215);
            lblResultadoNome.Name = "lblResultadoNome";
            lblResultadoNome.Size = new Size(50, 20);
            lblResultadoNome.TabIndex = 6;
            lblResultadoNome.Text = "Nome";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(105, 130);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(87, 20);
            lblQuantidade.TabIndex = 7;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblPrecoUnitario
            // 
            lblPrecoUnitario.AutoSize = true;
            lblPrecoUnitario.Location = new Point(105, 80);
            lblPrecoUnitario.Name = "lblPrecoUnitario";
            lblPrecoUnitario.Size = new Size(103, 20);
            lblPrecoUnitario.TabIndex = 8;
            lblPrecoUnitario.Text = "Preco Unitário";
            // 
            // lblNomeDoce
            // 
            lblNomeDoce.AutoSize = true;
            lblNomeDoce.Location = new Point(105, 42);
            lblNomeDoce.Name = "lblNomeDoce";
            lblNomeDoce.Size = new Size(89, 20);
            lblNomeDoce.TabIndex = 9;
            lblNomeDoce.Text = "Nome Doce";
            // 
            // txtIdadeCliente
            // 
            txtIdadeCliente.Location = new Point(235, 175);
            txtIdadeCliente.Name = "txtIdadeCliente";
            txtIdadeCliente.Size = new Size(125, 27);
            txtIdadeCliente.TabIndex = 10;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(235, 130);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(125, 27);
            txtQuantidade.TabIndex = 11;
            // 
            // txtPrecoUnitario
            // 
            txtPrecoUnitario.Location = new Point(235, 80);
            txtPrecoUnitario.Name = "txtPrecoUnitario";
            txtPrecoUnitario.Size = new Size(125, 27);
            txtPrecoUnitario.TabIndex = 12;
            // 
            // txtNomeDoce
            // 
            txtNomeDoce.Location = new Point(235, 39);
            txtNomeDoce.Name = "txtNomeDoce";
            txtNomeDoce.Size = new Size(125, 27);
            txtNomeDoce.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNomeDoce);
            Controls.Add(txtPrecoUnitario);
            Controls.Add(txtQuantidade);
            Controls.Add(txtIdadeCliente);
            Controls.Add(lblNomeDoce);
            Controls.Add(lblPrecoUnitario);
            Controls.Add(lblQuantidade);
            Controls.Add(lblResultadoNome);
            Controls.Add(lblDesconto);
            Controls.Add(lblValorFinal);
            Controls.Add(lblParcela);
            Controls.Add(lblStatus);
            Controls.Add(lblIdadeCliente);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblIdadeCliente;
        private Label lblStatus;
        private Label lblParcela;
        private Label lblValorFinal;
        private Label lblDesconto;
        private Label lblResultadoNome;
        private Label lblQuantidade;
        private Label lblPrecoUnitario;
        private Label lblNomeDoce;
        private TextBox txtIdadeCliente;
        private TextBox txtQuantidade;
        private TextBox txtPrecoUnitario;
        private TextBox txtNomeDoce;
    }
}
