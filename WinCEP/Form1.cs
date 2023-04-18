using CEPBLL;

namespace WinCEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncontraCEP_Click(object sender, EventArgs e)
        {
            ConsultaCEP consultaCEP = new ConsultaCEP();
            CEP cep = consultaCEP.Consultar(MtxtCEP.Text);
            txtEndereco.Text = cep.Logradouro;
            txtCidade.Text = $"{cep.Localidade} / {cep.Uf}";
            
        }

        private void lbCEP_Click(object sender, EventArgs e)
        {

        }

        private void MtxtCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}