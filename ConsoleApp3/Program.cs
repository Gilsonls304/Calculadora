using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			
			decimal valor_aplicado=0;
			decimal rendimento=0;
			decimal renda_fixa=0;
			int quant_meses=0;
			Boolean i = false;	
						
			calulos calculo = new calulos();
		while (i == false)
		{
						
				Console.WriteLine("Digite o valor a ser aplicado (R$):\n ");
				decimal.TryParse(Console.ReadLine(), out valor_aplicado);
				Console.WriteLine("Digite o rendimento mensal desejado, modalidade Poupança (%):\n ");
				decimal.TryParse(Console.ReadLine(), out rendimento);
				Console.WriteLine("Digite a quantidade de meses que o dinheiro ficará aplicado:\n ");
				int.TryParse(Console.ReadLine(), out quant_meses);
				Console.WriteLine("Digite o redimento (%) desejado para renda fixa:\n ");
				decimal.TryParse(Console.ReadLine(), out renda_fixa);

				if (valor_aplicado > 0 && rendimento>0 && renda_fixa>0 && quant_meses>0)
				{

				calculo.calcula(quant_meses, valor_aplicado, rendimento, renda_fixa);

				Console.WriteLine(valor_aplicado + " Reais aplicado na Poupança a um rendimento mensal de " + rendimento + "%, durante "
			+ quant_meses + " meses, rende um total de " + calculo.total_investimento + " Reais \n");
				if (quant_meses <= 12)
				{
					Console.WriteLine(valor_aplicado + " Reais aplicado a uma renda fixa com investimento de " + renda_fixa + "%, durante "
					+ quant_meses + " meses, imposto de renda de 25%, rende um total de " + calculo.impostorenda + " Reais \n");
				}
				else if (quant_meses > 12 && quant_meses < 25)
				{
					Console.WriteLine(valor_aplicado + " Reais aplicado a uma renda fixa com investimento de " + renda_fixa + "%, durante "
					+ quant_meses + " meses, imposto de renda de 15%, rende um total de " + calculo.impostorenda + " Reais \n");

				}
				else if (quant_meses > 24 && quant_meses < 37)
				{
					Console.WriteLine(valor_aplicado + " Reais aplicado a uma renda fixa com investimento de " + renda_fixa + "%, durante "
					+ quant_meses + " meses, imposto de renda de 5%, rende um total de " + calculo.impostorenda + " Reais \n");
				}
				else if (quant_meses > 36)
				{
					Console.WriteLine(valor_aplicado + " Reais aplicado a uma renda fixa com investimento de " + renda_fixa + "%, durante "
					+ quant_meses + " meses, imposto de renda de 1%, rende um total de " + calculo.impostorenda + " Reais \n");
				}

				if (calculo.total_investimento == calculo.impostorenda)
				{
					Console.WriteLine("As duas modalidades de aplicação geram o mesmo retorno de investimento!");
				}
				else if (calculo.total_investimento > calculo.impostorenda)
				{
					Console.WriteLine("A modalidade de aplicação Poupança é mais vantajosa, pois o rendimento de: " +
						calculo.total_investimento + " é maior que " + calculo.impostorenda);
				}
				else
				{
					Console.WriteLine("A modalidade de aplicação renda fixa é mais vantajosa, pois o rendimento de: " +
						calculo.impostorenda + " é maior que " + calculo.total_investimento);
					Console.WriteLine("renda fixa: "+calculo.totalrenda_fixa);
				}

					i = true;

					Console.Read();
					
			}
				else
				{
					Console.WriteLine("Valores negativos ou iguais a zero não são válido, por favor digite novamente \n");
					i = false;
				}
		}
					
			
		}

				
		
	}
}
