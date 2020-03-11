using System;

namespace Ficha9
{
    public class Ficha9Solucao
    {
        #region Ex1.1

        public static void Exercicio1_1()
        {
            var c = 1;
            for (var i = 0; i < 3; i++) {
                Console.WriteLine("Qual é o número?");
                var n = int.Parse(Console.ReadLine());
                c = n * c;
            }
            Console.WriteLine("O produto dos números é " + c);
        }



        #endregion

        #region Ex1.2

        public static void Exercicio1_2()
        {
            var x = 0;
            var y = 0;
            for (var i = 1; i < 3; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("Qual é o " + i + "º número?");
                    x = int.Parse(Console.ReadLine());
                }
                else 
                {
                    Console.WriteLine("Qual é o " + i + "º número?");
                    y = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine(x + " + " + y + " = " + (x + y) + '\n' +
                              x + " - " + y + " = " + (x - y) + '\n' +
                              x + " * " + y + " = " + (x * y) + '\n' +
                              x + " / " + y + " = " + (x / y) + '\n' +
                              x + " % " + y + " = " + (x % y));

            /*
            Console.WriteLine("Qual é o primeiro número?");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o segundo número?");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a operação?");
            var op = Console.ReadLine();
            if (op == "+")
            {
                Console.WriteLine(a + b);
            }
            else if (op == "-")
            {
                Console.WriteLine(a - b);
            }
            else if ((op == "*") || (op == "x") || (op == "X"))
            {
                Console.WriteLine(a * b);
            }
            else if (op == "/")
            {
                Console.WriteLine(a / b);
            }
            else if (op == "%")
            {
                Console.WriteLine(a % b);
            }
            else
            {
                Console.WriteLine(op + " não é operação");
            }
            */
        }



        #endregion

        #region Ex1.3

        public static void Exercicio1_3()
        {
            var x = 0;
            var y = 0;
            var z = 0;
            for (var i = 1; i < 4; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("Qual é o " + i + "º número?");
                    x = int.Parse(Console.ReadLine());
                } 
                else if ( i == 2)
                {
                    Console.WriteLine("Qual é o " + i + "º número?");
                    y = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Qual é o " + i + "º número?");
                    z = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("O resultado de (x+y).z é  " + ((x + y) * z)  + '\n' + 
                              "O resultado de x.y + y.z é " + (((x * y) + (y * z))));
        }



        #endregion

        #region Ex1.4

        public static void Exercicio1_4()
        {
            Console.WriteLine("Qual é o número?");
            var n = int.Parse(Console.ReadLine());
            for (var i = 1; i<= n; i++)
            {
                if ((i % 1 == 0) && (i % i == 0))
                {
                    for (var j = 1; j < n; j++)
                    {
                        if ((j % 1 != 0) && (j != 1))
                        {
                            Console.WriteLine(j);
                        }
                    }
                }
            }
        }



        #endregion

        #region Ex1.5

        public static void Exercicio1_5()
        {
            Console.WriteLine("Hello?");
            string s = Console.ReadLine();
            if (s == "Is it me you're looking for?")
            {
                Console.WriteLine("I can see it in your eyes");
            }
        }



        #endregion

        #region Ex1.6

        public static void Exercicio1_6()
        {
            Console.WriteLine("Escolha um número entre 1 e 100");
            var n = int.Parse(Console.ReadLine());

        }



        #endregion
    }
}
