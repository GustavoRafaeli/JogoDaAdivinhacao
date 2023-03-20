namespace JogoDaAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numeroChutado;
            double pontos = 1000;
            double calculo;

            Random rand = new Random();
            int randomNumero = rand.Next(1, 20);


            Console.WriteLine("**********************************");
            Console.WriteLine("*Bem vindo ao jogo da adivinhação*");
            Console.WriteLine("**********************************");
            Console.WriteLine();
            Console.WriteLine("Escolha o nível da dificuldade: ");
            Console.WriteLine("(1)Facil || (2)Médio || (3)Dificil");
            Console.WriteLine("Escolha: ");
            int escolha = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            switch (escolha)
            {
                case 1:

                    for(int i = 1; i <= 15; i++)
                    {
                        Console.WriteLine($"Tentativa {i} de 15");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Qual seu chute (de 1 a 20)? ");
                        numeroChutado = int.Parse(Console.ReadLine());

                        calculo = Math.Abs(numeroChutado - randomNumero);
                        pontos = Math.Abs(pontos - (calculo / 2));

                        if (numeroChutado == randomNumero)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Parabéns, você acertou!!");
                            Console.WriteLine();
                            Console.WriteLine($"Potuação Final: {pontos}!");
                        }
                        else if(numeroChutado < randomNumero)
                        {
                            Console.WriteLine("Seu chute foi menor que o número secreto!");
                            Console.WriteLine($"Você fez {pontos} pontos!");
                        }
                        else if (numeroChutado > randomNumero)
                        {
                            Console.WriteLine("Seu chute foi maior que o número secreto!");
                            Console.WriteLine($"Você fez {pontos} pontos!");
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                    break;

                case 2:

                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"Tentativa {i} de 10");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Qual seu chute (de 1 a 20)? ");
                        numeroChutado = int.Parse(Console.ReadLine());

                        calculo = Math.Abs(numeroChutado - randomNumero);
                        pontos = Math.Abs(pontos - (calculo / 2));

                        if (numeroChutado == randomNumero)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Parabéns, você acertou!!");
                            Console.WriteLine();
                            Console.WriteLine($"Potuação Final: {pontos}!");
                        }
                        else if (numeroChutado < randomNumero)
                        {
                            Console.WriteLine("Seu chute foi menor que o número secreto!");
                            Console.WriteLine($"Você fez {pontos} pontos!");
                        }
                        else if (numeroChutado > randomNumero)
                        {
                            Console.WriteLine("Seu chute foi maior que o número secreto!");
                            Console.WriteLine($"Você fez {pontos} pontos!");
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                    break;

                case 3:

                    for (int i = 1; i <= 15; i++)
                    {
                        Console.WriteLine($"Tentativa {i} de 5");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Qual seu chute (de 1 a 20)? ");
                        numeroChutado = int.Parse(Console.ReadLine());

                        calculo = Math.Abs(numeroChutado - randomNumero);
                        pontos = Math.Abs(pontos - (calculo / 2));

                        if (numeroChutado == randomNumero)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Parabéns, você acertou!!");
                            Console.WriteLine();
                            Console.WriteLine($"Potuação Final: {pontos}!");
                        }
                        else if (numeroChutado < randomNumero)
                        {
                            Console.WriteLine("Seu chute foi menor que o número secreto!");
                            Console.WriteLine($"Você fez {pontos} pontos!");
                        }
                        else if (numeroChutado > randomNumero)
                        {
                            Console.WriteLine("Seu chute foi maior que o número secreto!");
                            Console.WriteLine($"Você fez {pontos} pontos!");
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                    break;
            }
        }
    }
}