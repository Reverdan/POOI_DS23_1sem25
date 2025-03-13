using PrimeiraAula.modelo;

namespace PrimeiraAula
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.executar(txbPrimeiroNumero.Text, txbSegundoNumero.Text);
            lblResultado.Text = controle.mensagem;
        }
    }
}
