namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: usei o while para confirmar a operacao, o IF para parar o codigo caso a opção de sair fosse confirmada.
            // .add para adicionar a placa a lista de veiculos
            // dei o console + placa para mostrar a placa adicionada.
            while (true)
            {
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                string placa1 = Console.ReadLine();

                    if (placa1 == "4")
                    {
                        break;
                    }
                veiculos.Add(placa1);
                Console.WriteLine($"Placa adicionada: " + placa1);
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();
    

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Converti int horas em string para o usuaria adicionar a placa
                // assim agora a string horas pode receber input do usuario
                // TODO: Realizei o  cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas; 

                // TODO: usei o .Remove para Remover a placa digitada da lista de veículos
                
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
                // TODO: Realizei um laço de repetição, para percorrer a lista de veiculos, 
                // para exibir os veículos estacionados
                
                for(int i = 0; i < veiculos.Count; i++)
                {
                    Console.WriteLine(veiculos[i]);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
