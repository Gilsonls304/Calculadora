using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class calulos
	{
		public decimal total_investimento { get; set; }
		public decimal totalfinal { get; set; }
		public decimal totalrenda_fixa { get; set; }

		public decimal impostorenda { get; set; }//25%-ate 12 meses; 15% de 13 a 24 meses; 5% de 25% a 36 meses; 1% acima de 36 meses
		public void calcula(int meses, decimal valor, decimal rendimento, decimal rendafixa)
		{
				total_investimento = valor * (rendimento / 100) * meses;
				totalfinal = valor + total_investimento;
				totalrenda_fixa = valor * (rendafixa / 100) * meses;

				if (meses <= 12)
				{
					impostorenda = totalrenda_fixa-totalrenda_fixa * 25 / 100;
				}
				else if (meses > 12 && meses < 25)
				{
					impostorenda = totalrenda_fixa- totalrenda_fixa * 15 / 100;
				}
				else if (meses > 24 && meses < 37)
				{
					impostorenda = totalrenda_fixa- totalrenda_fixa * 5 / 100;
				}
				else if (meses > 36)
				{
					impostorenda = totalrenda_fixa- totalrenda_fixa * 1 / 100;
				}
			
			
		}
	}
}
