using TemperaturaNoite.Modelo;

namespace TemperaturaNoite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string tipo = "";
            if (rdbCF.Checked) tipo = "CF";
            else tipo = "FC";

            Controle controle = new Controle(tipo, txbTemperatura.Text);

            if (controle.mensagem.Equals(""))
                lblResultado.Text = controle.resposta;
            else
            {
                txbTemperatura.Text = "";
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
