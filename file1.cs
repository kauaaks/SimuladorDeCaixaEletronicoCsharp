using System;
using System.IO;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class MainForm : Form
    {
        // Variáveis para saldo e notas
        private decimal saldoUsuario = 1000.00m;
        private int notas100 = 20;
        private int notas50 = 20;
        private int notas20 = 25;
        private int notas10 = 30;

        public MainForm()
        {
            InitializeComponent();
            AtualizarInterface();
        }

        private void AtualizarInterface()
        {
            lblSaldo.Text = $"Saldo: R$ {saldoUsuario:F2}";
            lblNotas100.Text = $"R$ 100: {notas100}";
            lblNotas50.Text = $"R$ 50: {notas50}";
            lblNotas20.Text = $"R$ 20: {notas20}";
            lblNotas10.Text = $"R$ 10: {notas10}";
            lblTotalCaixa.Text = $"Total no Caixa: R$ {CalcularTotalCaixa():F2}";
        }

        private decimal CalcularTotalCaixa()
        {
            return (notas100 * 100) + (notas50 * 50) + (notas20 * 20) + (notas10 * 10);
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtValor.Text, out decimal valor) || valor <= 0)
            {
                MessageBox.Show("Digite um valor válido para saque.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (valor % 10 != 0)
            {
                MessageBox.Show("O valor do saque deve ser múltiplo de 10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (valor > saldoUsuario)
            {
                MessageBox.Show("Saldo insuficiente para realizar o saque.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (valor > CalcularTotalCaixa())
            {
                MessageBox.Show("O caixa não possui notas suficientes para este valor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcular notas
            int[] notasUsadas = CalcularNotas(valor);
            if (notasUsadas == null)
            {
                MessageBox.Show("Não foi possível realizar o saque com as notas disponíveis.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Atualizar saldo e notas
            saldoUsuario -= valor;
            notas100 -= notasUsadas[0];
            notas50 -= notasUsadas[1];
            notas20 -= notasUsadas[2];
            notas10 -= notasUsadas[3];

            // Gerar comprovante
            GerarComprovante(valor, notasUsadas);

            // Atualizar interface
            AtualizarInterface();

            // Mostrar mensagem de sucesso
            string mensagemNotas = $"Notas entregues:\n" +
                                  $"- {notasUsadas[0]} x R$ 100\n" +
                                  $"- {notasUsadas[1]} x R$ 50\n" +
                                  $"- {notasUsadas[2]} x R$ 20\n" +
                                  $"- {notasUsadas[3]} x R$ 10";
            MessageBox.Show($"Saque realizado com sucesso!\n\n{mensagemNotas}\n\nNovo saldo: R$ {saldoUsuario:F2}", 
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int[] CalcularNotas(decimal valor)
        {
            int[] notas = new int[4]; // [0]=100, [1]=50, [2]=20, [3]=10
            decimal valorRestante = valor;

            // Notas de 100
            notas[0] = Math.Min((int)(valorRestante / 100), notas100);
            valorRestante -= notas[0] * 100;

            // Notas de 50
            notas[1] = Math.Min((int)(valorRestante / 50), notas50);
            valorRestante -= notas[1] * 50;

            // Notas de 20
            notas[2] = Math.Min((int)(valorRestante / 20), notas20);
            valorRestante -= notas[2] * 20;

            // Notas de 10
            notas[3] = Math.Min((int)(valorRestante / 10), notas10);
            valorRestante -= notas[3] * 10;

            // Se ainda restar valor, não foi possível atender
            if (valorRestante > 0)
            {
                return null;
            }

            return notas;
        }

        private void GerarComprovante(decimal valor, int[] notasUsadas)
        {
            string nomeArquivo = $"Comprovante_{DateTime.Now:ddMMyyyy_HHmmss}.txt";
            string caminho = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nomeArquivo);

            string conteudo = $"Comprovante de Saque - Caixa Eletrônico\n\n" +
                              $"Data/Hora: {DateTime.Now:dd/MM/yyyy HH:mm}\n" +
                              $"Valor solicitado: R$ {valor:F2}\n\n" +
                              $"Notas entregues:\n" +
                              $"- {notasUsadas[0]} x R$ 100\n" +
                              $"- {notasUsadas[1]} x R$ 50\n" +
                              $"- {notasUsadas[2]} x R$ 20\n" +
                              $"- {notasUsadas[3]} x R$ 10\n\n" +
                              $"Saldo restante: R$ {saldoUsuario:F2}\n\n" +
                              $"Obrigado por utilizar nosso caixa!";

            try
            {
                File.WriteAllText(caminho, conteudo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar comprovante: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtValor.Text, out decimal valor) || valor <= 0)
            {
                MessageBox.Show("Digite um valor válido para depósito.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (valor % 10 != 0)
            {
                MessageBox.Show("O valor do depósito deve ser múltiplo de 10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saldoUsuario += valor;
            AtualizarInterface();

            MessageBox.Show($"Depósito realizado com sucesso!\n\nNovo saldo: R$ {saldoUsuario:F2}", 
                          "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            txtValor.Focus();
        }
    }
}
