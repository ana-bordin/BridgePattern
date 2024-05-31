namespace Veiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite qual veiculo quer ligar: 1 - carro | 2 - moto");
            int opcao = int.Parse(Console.ReadLine());
            GerenciadorVeiculo gerenciador;
            GerenciadorAvancado gerenciadorAvancado;
            IVeiculo carro = null;
            IVeiculo moto = null;
            bool sair = false;

            string veiculo;

            if (opcao == 1)
            {
                carro = new Carro();
                veiculo = "carro";
                gerenciador = new GerenciadorVeiculo(carro);
                gerenciadorAvancado = new GerenciadorAvancado(carro);
            }
            else
            {
                moto = new Moto();
                veiculo = "moto";
                gerenciador = new GerenciadorVeiculo(moto);
                gerenciadorAvancado = new GerenciadorAvancado(moto);
            }
            Console.Clear();

            do
            {
                Console.WriteLine("digite a opção:");
                Console.WriteLine("1 - ligar\n" +
                    "2 - desligar\n" +
                    "3 - acelerar\n" +
                    "4 - ligar turbo\n" +
                    "5 - freiar\n" +
                    "0 - sair;");
                string resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "1":
                        gerenciador.Ligar();
                        bool statusLigar;
                        if (veiculo == "moto")
                        {
                            statusLigar = moto.EstaLigado();
                            if (!statusLigar)
                                Console.WriteLine("Ligou!");
                            else
                                Console.WriteLine("A moto ja está ligada!");
                        }

                        if (veiculo == "carro")
                        {
                            statusLigar = carro.EstaLigado();
                            if (!statusLigar)
                                Console.WriteLine("Ligou!");
                            else
                                Console.WriteLine("O carro ja está ligada!");
                        }
                        break;

                    case "2":
                        bool statusDesligado;
                        gerenciador.Desligar();

                        if (veiculo == "moto")
                        {
                            statusDesligado = moto.EstaLigado();
                            if (!statusDesligado)
                                Console.WriteLine("Desligou!");
                            else
                                Console.WriteLine("Não foi possível desligar, pois o veículo está em movimento");
                        }

                        if (veiculo == "carro")
                        {
                            statusDesligado = carro.EstaLigado();
                            if (!statusDesligado)
                                Console.WriteLine("Desligou!");
                            else
                                Console.WriteLine("Não foi possível desligar, pois o veículo está em movimento");
                        }
                        break;

                    case "3":
                        gerenciador.Acelerar();
                        if (veiculo == "moto")
                            Console.WriteLine($"Você está a {moto.PegarVelocidade()} km por hora");
                        else

                            Console.WriteLine($"Você está a {carro.PegarVelocidade()} km por hora");
                        break;

                    case "4":
                        gerenciadorAvancado.AtivarTurbo();
                        if (veiculo == "moto")
                            Console.WriteLine($"Você está a {moto.PegarVelocidade()} km por hora");
                        else
                            Console.WriteLine($"Você está a {carro.PegarVelocidade()} km por hora");
                        break;

                    case "5":
                        gerenciador.Frear();
                        if (veiculo == "moto")
                            Console.WriteLine($"Você está a {moto.PegarVelocidade()} km por hora");
                        else
                            Console.WriteLine($"Você está a {carro.PegarVelocidade()} km por hora");
                        break;

                    case "0":
                        Console.WriteLine("Saindo...");
                        sair = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (sair != true);
        }
    }
}
