namespace JogoDeAdivinhação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                
                Console.WriteLine("Bem-vindo ao jogo de adivinhação!");

                // Definindo o número aleatório
                Random random = new Random();
                int numeroAleatorio = random.Next(1, 21);

                Console.WriteLine("Escolha o nível de dificuldade:");
                Console.WriteLine("1 - Fácil (15 chances)");
                Console.WriteLine("2 - Médio (10 chances)");
                Console.WriteLine("3 - Difícil (5 chances)");
                int nivel = int.Parse(Console.ReadLine());

                int tentativas;
                switch (nivel)
                {
                    case 1:
                        tentativas = 15;
                        break;
                    case 2:
                        tentativas = 10;
                        break;
                    case 3:
                        tentativas = 5;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Nível médio definido por padrão.");
                        tentativas = 10;
                        break;
                }

                int pontuacao = 1000;

                while (tentativas > 0)
                {
                    Console.WriteLine($"Você tem {tentativas} tentativas. Digite um número entre 1 e 20:");
                    int chute = int.Parse(Console.ReadLine());

                    if (chute < 1 || chute > 20)
                    {
                        Console.WriteLine("Número inválido. Por favor, escolha um número entre 1 e 20.");
                        continue;
                    }

                    if (chute == numeroAleatorio)
                    {
                        Console.WriteLine("Parabéns! Você acertou o número!");
                        break;
                    }
                    else
                    {
                        int diferenca = Math.Abs(numeroAleatorio - chute);
                        pontuacao -= diferenca / 2;
                        tentativas--;

                        if (numeroAleatorio > chute)
                        {
                            Console.WriteLine("O número pensado é maior.");
                        }
                        else
                        {
                            Console.WriteLine("O número pensado é menor.");
                        }
                    }
                }
                Console.ReadLine();

                
            }
        }
    }
    
}
