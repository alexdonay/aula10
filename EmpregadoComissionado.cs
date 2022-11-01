using System;
namespace aula10
{
	public class EmpregadoComissionado : Empregado
	{
		public double Comissao { get; set; }
		public int Quantidade { get; set; }

		public EmpregadoComissionado()
		{
		}
		public void AdicionaVendas(int quantidade)
        {
			this.Quantidade += quantidade;
        }
		public void RemoveVendas()
        {
            this.Quantidade -= Quantidade;
        }
        public override double CalculaSalario()
        {
            return base.Salario * this.Quantidade;
        }
        public override double CalculaBonus()
        {
            return this.CalculaSalario() * 0.05;
        }
    }

}
