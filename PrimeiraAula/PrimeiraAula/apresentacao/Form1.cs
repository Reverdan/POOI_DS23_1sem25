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
            controle.numero1 = txbPrimeiroNumero.Text;
            controle.numero2 = txbSegundoNumero.Text;
            controle.executar();
            if (controle.mensagem.Equals(""))
            {
                lblResultado.Text = controle.resultado;
            }
            else
            {
                lblResultado.Text = controle.mensagem;
            }
        }
    }
}
