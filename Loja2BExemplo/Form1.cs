namespace Loja2BExemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            try
            {
                // =========================================================
                //   INSTANCIA(Criação do objeto na memória)
                // =========================================================
                Pedido pedido = new Pedido();
                // =========================================================
                // PROPRIEDADE (ATRIBUIÇÃO DE DADOS )
                // Pegamos o texto das caixas (TextBox) e convertemos
                // =========================================================
                pedido.NomeDoce = txtNomeDoce.Text;
                // Pode usar txtNomeDoce se preferir renomear na tela
                pedido.PrecoUnitario = Convert.ToDouble(txtPrecoUnitario.Text);
                // Preço unitário do doce
                pedido.Quantidade = int.Parse(txtQuantidade.Text);
                // Quantidade desejada
                pedido.IdadeCliente = int.Parse(txtIdadeCliente.Text);
                // Idade do comprador
                // =========================================================
                // UTILIZAÇÃO DO OBJETO
                // Chamamos os métodos da classe e exibimos nas Labels
                // =========================================================
                double desconto = pedido.CalcularDesconto();
                double valorFinal = pedido.CalcularValorFinal();
                double parcela = pedido.CalcularParcela();
                bool brindeAprovado = pedido.ValidarBrinde();
                // Exibindo os dados formatados na tela
                lblResultadoNome.Text = $"{pedido.NomeDoce.ToUpper()}";
                lblDesconto.Text = $"R$ {desconto:N2}";
                lblValorFinal.Text = $"R$ {valorFinal:N2}";
                lblParcela.Text = $"3x de R$ {parcela:N2}";
                //Limpando campos
                txtNomeDoce.Clear();
                txtPrecoUnitario.Clear();
                txtQuantidade.Clear();
                txtIdadeCliente.Clear();
                if (brindeAprovado)
                {
                    lblStatus.Text = "PARABÉNS! Você ganhou um brinde surpresa!";
                    lblStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblStatus.Text = "Compra padrão realizada com sucesso!";
                    lblStatus.ForeColor = Color.Blue;
                }
            }
            catch (FormatException)
            {
                // Tratamento simples caso o usuario digite texto onde deveria ser número
                MessageBox.Show("Preencha os campos numéricos corretamente!",
                "Erro de Digitação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
    }
}
