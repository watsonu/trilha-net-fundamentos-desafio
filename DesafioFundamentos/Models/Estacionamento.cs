using System.Runtime.Intrinsics.Arm;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private string placa = "";
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        // Adiciona um veículo a lista de veiculos.
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placa = Console.ReadLine();

            // Verifica se o veículo ja foi adicionado a lista.
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine($"O veículo de placa {placa}, ja está estacionado");
            }
            else
            {
                veiculos.Add(placa);
            }
        }
        // Remove um veículo a lista de veiculos.
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            placa = Console.ReadLine();
          
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            { 
                // Calcula o valor total que o usuario terá que pagar e remove ele da lista de veiculos.
                int horas = 0;
                decimal valorTotal = 0;  
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = (precoInicial + (precoPorHora * horas));
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Lista os veiculos estacionados.
                foreach (string estacionados in veiculos)
                {
                    Console.WriteLine(estacionados);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
