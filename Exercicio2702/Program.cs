using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombustivelPorKm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entrada das informações 
            Console.WriteLine("Valor do combustivel: ");
            double combustivel = double.Parse(Console.ReadLine());

            Console.WriteLine("Consumo de combustivel do veiculo por litro: ");
            double consumo = double.Parse(Console.ReadLine());

            Console.WriteLine("Distancia percorrida: ");
            int km = int.Parse(Console.ReadLine());

            //Processamento
            double distancia = km / consumo;

            double gasto = distancia * combustivel;

            //Saida
            Console.WriteLine("O gasto total será de: " + gasto);
            Console.ReadKey();


        }
    }
}
