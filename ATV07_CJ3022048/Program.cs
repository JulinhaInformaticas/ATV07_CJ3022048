namespace ATV07_CJ3022048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("=========MENU=========");
                    Console.WriteLine("0 - SAIR");
                    Console.WriteLine("1 - ATV 1");
                    Console.WriteLine("2 - ATV 2");
                    Console.WriteLine("3 - ATV 3");
                    Console.WriteLine("4 - ATV 4");
                    Console.WriteLine("5 - ATV 5");
                    Console.WriteLine("6 - ATV 6");
                    Console.WriteLine("7 - ATV 7");

                    opcao = int.Parse(Console.ReadLine());

                } while (opcao < 0 || opcao > 7);

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado por usar o sistema!");
                        break;

                    case 1:
                        //ATV 1
                        Console.WriteLine("ATIVIDADE 1");

                        int n, m;
                        Console.Clear();
                        Console.WriteLine("digite um número inteiro aleatório: ");
                        m = int.Parse(Console.ReadLine());
                        n = 1;
                        do
                        {
                            Console.WriteLine("{0}", n);
                            n++;
                        } while (n <= m);
                        Thread.Sleep(2000);
                        Console.Clear();
                        
                        break;

                    case 2:
                        //ATV 2
                        Console.WriteLine("ATIVIDADE 2");

                        Console.Clear();
                        int a2, n1 = 2;
                        Console.WriteLine("digite um número aleatório: ");
                        a2 = int.Parse(Console.ReadLine());

                        do
                        {
                            Console.WriteLine("{0}", n1);
                            n1 = n1 + 2;
                        } while (n1 <= a2);
                        Thread.Sleep(2000);
                        Console.Clear();

                        break;

                    case 3:
                        //ATV 3
                        Console.WriteLine("ATIVIDADE 3");

                        Console.Clear();
                        int mil, div = 1000;
                        Console.WriteLine("Insira um número menor que 1000");
                        mil = int.Parse(Console.ReadLine());

                        do
                        {
                            Console.WriteLine("{0}", div);
                            div = div - 2;
                        } while (div >= mil);
                        Thread.Sleep(2000);
                        Console.Clear();

                        break;

                    case 4:
                        //ATV 4
                        Console.WriteLine("ATIVIDADE 4");

                        Console.Clear();
                        int n2, somapositivos = 0;
                        while (somapositivos < 200)
                            do
                            {
                                Console.WriteLine("digite um número inteiro: ");
                                n2 = int.Parse(Console.ReadLine());
                                somapositivos = somapositivos + n2;
                            } while (somapositivos < 200);
                            Thread.Sleep(2000);
                            Console.Clear();

                        break;

                    case 5:
                        //ATV 5
                        Console.WriteLine("ATIVIDADE 5");

                        Console.Clear();
                        int n3, cont = 1;
                        Console.WriteLine("Digite o número que deseja descobrir os divisores");
                        n3 = int.Parse(Console.ReadLine());
                        do
                        {
                            if (n3 % cont == 0)
                                Console.WriteLine("{0}", cont);
                            cont++;
                        } while (cont < n3);
                        Thread.Sleep(2000);
                        Console.Clear();

                        break;

                    case 6:
                        //ATV 6
                        Console.WriteLine("ATIVIDADE 6");
                        break;

                    case 7:
                        //ATV 7
                        Console.WriteLine("ATIVIDADE 7");

                        int n5 = 0, pares = 0, impares = 0;
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("Digite um valor, somaremos os ímpares e os pares, se digitar '0' o programa é encerrado");
                            n5 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (n5 == 0)
                            {
                                Console.WriteLine("A soma dos números pares é:{0}}\nA soma dos números ímpares é: {1}", pares, impares);
                                Thread.Sleep(2000);
                                break;
                            }
                            if (n5 % 2 == 0)
                                pares = pares + n5;
                            else
                                impares = impares + n5;
                        } while (true);
                        Thread.Sleep(2000);
                        Console.Clear();

                        break;
                }
            } while (opcao != 0);

        }
    }
}  
