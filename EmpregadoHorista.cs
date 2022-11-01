using System;
namespace aula10
{
	public class EmpregadoHorista :Empregado
	{
		public double Horas { get; set; }
		public EmpregadoHorista()
		{
			
		}
		public void AdicionarHoras(double horas)
		{
			this.Horas += horas;
		}
		public void RemoverHoras(double horas) 
		{
			this.Horas -= horas;
		}
		public override double CalculaSalario()
		{

			return base.Salario * Horas;
    

		}
        public override double CalculaBonus()
        {
            return CalculaSalario() * 0.05;
        }

    }
}

