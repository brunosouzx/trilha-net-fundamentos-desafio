namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        bool condiao =true;
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            //Implementado o adicionar veículo
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine()) ;
        }

        public void RemoverVeiculo()
        {
            //estou chamando o "ListarVeiculos" e pedindo para 
            //o usuario digitar o numero respectivo do veiculo
            //para evidar o erro de digitar errado 
            
            Console.WriteLine("Escolha a placa do veículo para remover:");
            Console.WriteLine("digite o numero respectivo da placa");
            ListarVeiculos();
            

            string placa ="";

            if(condiao)
            {
                int numeroVeiculo = Convert.ToInt32(Console.ReadLine());
                placa = veiculos[numeroVeiculo-1];
            }
            

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial+(precoPorHora*horas); 

                veiculos.Remove(placa);
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                Console.WriteLine("-----------------------------");
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
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Os veículos estacionados são:");
                
                for(int i = 0; i < veiculos.Count; i++ )
                {
                    Console.WriteLine($"{i+1} - {veiculos[i]}");
                }
                Console.WriteLine("-----------------------------");
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
                condiao=false;
            }
        }
    }
}
