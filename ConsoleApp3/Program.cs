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
						
			calulos calculo = new calulos();//Instanciando a classe que possui o método 
											//que calcula os rendimentos e imposto de renda

			while (i == false)//Repete a solicitação dos dados para calculo de rendimento caso 
							  //sejam digitados valores inválidos como 0 e valores negativos
		{
				Console.WriteLine("Digite o valor a ser aplicado (R$):\n ");
				decimal.TryParse(Console.ReadLine(), out valor_aplicado);
				Console.WriteLine();
				Console.WriteLine("Digite o rendimento mensal desejado, modalidade Poupança (%):\n ");
				decimal.TryParse(Console.ReadLine(), out rendimento);
				Console.WriteLine("Digite a quantidade de meses que o dinheiro ficará aplicado:\n ");
				Console.WriteLine();
				int.TryParse(Console.ReadLine(), out quant_meses);
				Console.WriteLine();
				Console.WriteLine("Digite o redimento (%) desejado para renda fixa:\n ");
				decimal.TryParse(Console.ReadLine(), out renda_fixa);
			
				if (valor_aplicado > 0 && rendimento>0 && renda_fixa>0 && quant_meses>0)
				{

				calculo.calcula(quant_meses, valor_aplicado, rendimento, renda_fixa);// chama o método que calcula o rendimento

				Console.WriteLine("{0} Reais aplicado na Poupança a um rendimento mensal de {1}%, durante " +
					"{2} meses, rende um total de {3} Reais\n", valor_aplicado, rendimento, quant_meses, calculo.total_investimento);

				if (quant_meses <= 12)
				{
					Console.WriteLine(" {0} Reais aplicado a uma renda fixa com investimento de {1} %, durante " +
					"{2} meses, imposto de renda de 25%, rende um total de {3} Reais \n",valor_aplicado, renda_fixa, quant_meses, calculo.impostorenda);
				}
				else if (quant_meses > 12 && quant_meses < 25)
				{
					Console.WriteLine("{0} Reais aplicado a uma renda fixa com investimento de {1} %, durante " +
					"{2} meses, imposto de renda de 15%, rende um total de {3} Reais \n", valor_aplicado, renda_fixa, quant_meses, calculo.impostorenda);

				}
				else if (quant_meses > 24 && quant_meses < 37)
				{
					Console.WriteLine("{0} Reais aplicado a uma renda fixa com investimento de {1} %, durante " +
					"{2} meses, imposto de renda de 5%, rende um total de {3} Reais \n", valor_aplicado, renda_fixa, quant_meses, calculo.impostorenda);
				}
				else if (quant_meses > 36)
				{
					Console.WriteLine("{0} Reais aplicado a uma renda fixa com investimento de {1} %, durante" +
					"{2} meses, imposto de renda de 1%, rende um total de {3}", valor_aplicado, renda_fixa, quant_meses, calculo.impostorenda);
				}

				if (calculo.total_investimento == calculo.impostorenda)
				{
					Console.WriteLine("As duas modalidades de aplicação geram o mesmo retorno de investimento!");
				}
				else if (calculo.total_investimento > calculo.impostorenda)
				{
					Console.WriteLine("A modalidade de aplicação Poupança é mais vantajosa, pois o rendimento de {0}" +
					" é maior que {1}", calculo.total_investimento, calculo.impostorenda);
				}
				else
				{
					Console.WriteLine("A modalidade de aplicação renda fixa é mais vantajosa, pois o rendimento de R$ {0}" +
					" é maior que R$ {1}", calculo.impostorenda, calculo.total_investimento);
					
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
