namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>(4); // Cria uma lista com capacidade de 4 veículos

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        // Metodo para adicionar um veículo no estacionamento, caso não esteja lotado
        public void AdicionarVeiculo()
        {
            // Verifica se o estacionamento está lotado
            if (veiculos.Count == 4)
            {
                Console.WriteLine("Estacionamento lotado!");
                return;
            }
            else
            {
                // Pedi para que o usuário digite a placa do veículo, e adiciona na lista "veiculos"
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                veiculos.Add(Console.ReadLine());

                Console.WriteLine("Veículo adicionado com sucesso!");
            }

        }

        // Metodo para remover um veículo estacionado
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedi para o usuário inserir a placa e armazena na variável placa
            string placa = Console.ReadLine();

            // Verifica se o veículo realmente está estacionado
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
                // Pede para o usuário inserir a quantidade de horas que o veículo permanceu estacionado
                Console.WriteLine("Por quantas horas o veículo ficou estacionado?");
                horas = Convert.ToInt32(Console.ReadLine());

                // Realiza o cálculo do valor total a ser pago, e armazena na variável valorTotal              
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                // Remove o veículo com a placa digitada da lista de veículos
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        // Metodo para listar todos os veículos estacionados atualmente
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Laço de repetição usando FOREACH para exibir cada placa dos veículos estacionados
                foreach (string placa in veiculos)
                {
                    Console.WriteLine(placa);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
