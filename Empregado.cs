namespace aula10
{
    public class Empregado
    {
		public string PrimeiroNome { get; set; }
		public string SegundoNome { get; set; }
		public double Salario { get; set; }
		public double SalarioTotal { get; set; }

		public virtual double CalculaSalario()
		{
			return 0;
		}
		public string ImprimeContraCheque()
		{

			return ($"{this.PrimeiroNome} -  {this.SegundoNome} - {this.Salario} - {this.SalarioTotal}");
		}
		public virtual double CalculaBonus()
		{
			return 0;
		}
	}
}
