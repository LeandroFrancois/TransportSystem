using System;
using Register;

namespace Menu;

public class PrincipalMenu
{
    public async Task ShowPrincipalMenu()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Gerenciador de Tarefas");
            Console.WriteLine("1. Adicionar Cliente");
            Console.WriteLine("2. Adicionar Motorista");
            Console.WriteLine("3. Adicionar Passageiro");
            Console.WriteLine("4. Adicionar Viagem");
            Console.WriteLine("5. Adicionar Veículo");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    var clienteMenu = new RegisterCliente();
                    clienteMenu.NewCliente();
                    break;
                case "2":
                    var motoristaMenu = new RegisterMotorista();
                    motoristaMenu.NewMotorista();
                    break;
                case "3":
                    var passageiroMenu = new RegisterPassageiro();
                    passageiroMenu.NewPassageiro();
                    break;
                case "4":
                    var viagemMenu = new RegisterViagem();
                    viagemMenu.NewViagem();
                    break;
                case "5":
                    var veiculoMenu = new RegisterVeiculo();
                    veiculoMenu.NewVeiculo();
                    break;
                case "6":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            if (continuar)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
