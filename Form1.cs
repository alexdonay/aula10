
namespace aula10
{
    public partial class FrmCadEmpregado : Form
    {
        public FrmCadEmpregado()
        {
            InitializeComponent();
        }
        
        public List<EmpregadoHorista> horistaList = new List<EmpregadoHorista>();
        public List<EmpregadoComissionado> ComissionadosList = new List<EmpregadoComissionado>();
        private void BtnCadastra_Click(object sender, EventArgs e)
        {
            if (RdHorista.Checked)
            {
                EmpregadoHorista horista = new EmpregadoHorista();
                try
                {
                    horista.PrimeiroNome = TxtNome.Text;
                    horista.SegundoNome = TxtSobrenome.Text;
                    horista.Horas = double.Parse(TxtHoras.Text);
                    horista.Salario = double.Parse(TxtSalario.Text);
                    horista.SalarioTotal = horista.CalculaSalario() + horista.CalculaBonus();
                    horistaList.Add(horista);
                    MessageBox.Show("Dados Cadastrados com sucesso");
                
                }
                catch (Exception err)
                {
                    MessageBox.Show("Algum dado não foi preenchido Corretamente " + err);
                }
            }
            else
            {
                EmpregadoComissionado comissionado = new EmpregadoComissionado();
                try
                {
                    comissionado.Salario = double.Parse(TxtSalario.Text);
                    comissionado.PrimeiroNome = TxtNome.Text;
                    comissionado.SegundoNome = TxtSobrenome.Text;
                    comissionado.Quantidade = int.Parse(TxtQuantidade.Text);
                    comissionado.SalarioTotal = comissionado.CalculaSalario() + comissionado.CalculaBonus();
                    ComissionadosList.Add(comissionado);
                    MessageBox.Show("Dados Cadastrados com sucesso");
                }
                
                catch (Exception err)
                {
                    MessageBox.Show("Algum dado não foi preenchido Corretamente " + err);
                }
                

            }
            TxtSalario.Text = "";
            TxtHoras.Text = "";
            TxtNome.Text = "";
            TxtSobrenome.Text = "";
            TxtQuantidade.Text = "";
            RdHorista.Checked = true;
        }

        private void BtnExibe_Click(object sender, EventArgs e)
        {
            string texto = "";
            foreach(EmpregadoHorista empregado in horistaList)
            {
                texto = texto + "\n" + empregado.ImprimeContraCheque() + "\n";
            }
            foreach (EmpregadoComissionado empregado in ComissionadosList)
            {
                texto = texto +"\n"+ empregado.ImprimeContraCheque() + "\n";
            }
            MessageBox.Show(texto);
        }
    }
}