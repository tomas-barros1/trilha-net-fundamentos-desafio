Estacionamento estacionamento = new Estacionamento(10, 2);

void Menu()
{
    int opcao;
    do
    {
        Console.WriteLine("1- Cadastrar veículo\n2- Remover veículo\n3- Listar veículos\n4- Encerrar");
        opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Digite a placa do veículo: ");
                string placa = Console.ReadLine();
                estacionamento.AdicionarVeiculo(placa);
                break;
            case 2:
                Console.WriteLine("Digite a placa do veículo: ");
                string placaRemover = Console.ReadLine();
                estacionamento.RemoverVeiculo(placaRemover);
                break;
            case 3:
                Console.WriteLine("Lista de carros: ");
                estacionamento.ListarVeiculos();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    } while (opcao != 4);
}

Menu();