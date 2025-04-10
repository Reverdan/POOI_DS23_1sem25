using NumeroPrimoNoite.modelo;

namespace NumeroPrimoNoite
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle(txbNumero.Text);
            lblResposta.Text = controle.Mensagem;
        }
    }
}
