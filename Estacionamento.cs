using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Estacionamento
{
    private decimal precoInicial { get; set; }
    private decimal precoPorHora { get; set; }
    private List<string> veiculos = new List<string>();

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo(string placa)
    {
        veiculos.Add(placa);
    }

    public void RemoverVeiculo(string placa)
    {
        if (veiculos != null)
        {
            foreach (var veiculo in veiculos)
            {
                if (veiculo == placa)
                {
                    Console.WriteLine("Qual foi a quantidade horas que você ficou no estacionamento? ");
                    decimal horas = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Valor para pagar: " + (precoPorHora * horas) + precoInicial);
                } else
                {
                    Console.WriteLine("Veículo não encontrado!");
                }
            }
        } else
        {
            Console.WriteLine("Nenhum veículo estacionado");
        }

    }

    public void ListarVeiculos()
    {
        if (veiculos.Count == 0)
        {
            Console.WriteLine("Nenhum veículo no estacionamento!");
        }
        else
        {
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }
    }


}


