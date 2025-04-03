using PrimeiraAula.modelo;

namespace PrimeiraAula
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Executar(string op)
        {
            Controle controle = new Controle();
            controle.executar(txbPrimeiroNumero.Text,
                txbSegundoNumero.Text, op);
            lblResultado.Text = controle.Resultado;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Executar("+");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Executar("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Executar("*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Executar("/");
        }
    }
}
