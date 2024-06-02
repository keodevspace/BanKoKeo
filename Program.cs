class Program
{
    static void Main(string[] args)
    {
        decimal valorAposOperacao = 0;
        decimal valorAtual = valorAposOperacao;
        Console.Clear();
        Login();
        Menu();

        static void Login()
        {
            static void Menu()
            {

                Console.Write(".");
                Thread.Sleep(2000);
                Console.Write(".");
                Thread.Sleep(2000);
                Console.Write(".");
                Thread.Sleep(2000);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("$$$  BOAS-VINDAS AO BANKOKEO  $$$");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("--------------Menu---------------");
                Console.WriteLine("|----                           |");
                Console.WriteLine("| 1 |  Saldo                    |");
                Console.WriteLine("| 2 |  Depósito                 |");
                Console.WriteLine("| 3 |  Transferência            |");
                Console.WriteLine("| 4 |  Saque                    |");
                Console.WriteLine("| 5 |  Sair do caixa eletrônico |");
                Console.WriteLine("|----                           |");
                Console.WriteLine("|------Digite a operação--------|");
                Console.WriteLine("|                               |");
                Console.WriteLine("---------------------------------");
                decimal operacao = decimal.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------");
                Console.WriteLine("");
                Console.Write("||          Operação: " + operacao + "         ||");
                Console.WriteLine("");
                Console.WriteLine("");

                if (operacao == 5)
                {
                    Console.Clear();
                    Console.Write("Saindo");
                    Console.Write(".");
                    Thread.Sleep(2000);
                    Console.Write(".");
                    Thread.Sleep(2000);
                    Console.Write(".");
                    Thread.Sleep(2000);
                    Console.WriteLine("");
                    Console.Write("Obrigado por usar o BanKoKeo!");
                    Thread.Sleep(2000);
                    Environment.Exit(0);

                }

                decimal valorAtual = 100;

                Console.WriteLine("||     Aguarde um momento       ||");
                Console.Write(".");
                Thread.Sleep(2000);
                Console.Write(".");
                Thread.Sleep(2000);
                Console.Write(".");
                Thread.Sleep(2000);
                Console.WriteLine("");


                switch (operacao)
                {
                    case 1: Console.WriteLine(""); Saldo(valorAtual); break;
                    case 2: Console.WriteLine(""); Deposito(valorAtual); break;
                    case 3: Console.WriteLine(""); Transferencia(valorAtual); break;
                    case 4: Console.WriteLine(""); Saque(valorAtual); break;
                    default: Console.WriteLine(""); Console.WriteLine("Operação inválida."); Menu(); break;
                }

                static void Saldo(decimal valorAtual)
                {

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($"Seu saldo atual é de {valorAtual}.");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("");
                    Menu();

                };


                static void Deposito(decimal valorAtual)
                {

                    Console.Write("Digite o valor do depósito: ");
                    decimal valorDepositado = decimal.Parse(Console.ReadLine());
                    valorAtual += valorDepositado;
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($"Seu saldo atual é de {valorAtual}.");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("");
                    Menu();
                };


                static void Transferencia(decimal valorAtual)
                {

                    Console.Write("Digite o valor da transferência: ");
                    decimal valorTransferencia = decimal.Parse(Console.ReadLine());

                    if (valorTransferencia > valorAtual)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("| Não há saldo para a operação. |");
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("");
                    }
                    else
                    {
                        valorAtual -= valorTransferencia;
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("|    Transferência realizada!   |");
                        Console.WriteLine($"| Seu saldo atual é de {valorAtual}. |");
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("");
                    }
                    Menu();

                };


                static void Saque(decimal valorAtual)
                {


                    Console.Write("Digite o valor do saque: ");
                    decimal valorSacado = decimal.Parse(Console.ReadLine());

                    if (valorSacado > valorAtual)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("| Não há saldo para a operação. |");
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("");

                    }
                    else
                    {
                        decimal valorAposOperacao = valorAtual - valorSacado;
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("|    Saque realizado!     |");
                        Console.WriteLine($"| Seu saldo atual é de {valorAtual}. |");
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("");
                    }
                    Menu();
                }

            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("$$$  BOAS-VINDAS AO BANKOKEO  $$$");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("----------Digite seu login-------");
            Console.WriteLine("---------------------------------");
            string login = Console.ReadLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("----------Digite sua senha-------");
            Console.WriteLine("---------------------------------");
            string senha = Console.ReadLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("||     Aguarde um momento       ||");
            Console.Write(".");
            Thread.Sleep(2000);
            Console.Write(".");
            Thread.Sleep(2000);
            Console.Write(".");
            Thread.Sleep(2000);
            Console.WriteLine("");

            if (login == "admin" && senha == "admin")
            {
                Menu();
            }
            else
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("|   Login ou senha inválidos.   |");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("");
                Login();


            }


        }

    }

    private static void Menu()
    {
        throw new NotImplementedException();
    }
}
