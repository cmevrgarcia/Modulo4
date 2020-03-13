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
            var primos = "";
            var isPrime = true;

            for (int i = 2; i < n; i++)
            {
                if (n == 2)
                {
                    primos += n.ToString() + "\n";
                }
                else
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                        }
                    }
                    if (isPrime == true)
                    {
                        primos += i.ToString() + "\n";
                    }
                }
                isPrime = true;
            }
            Console.WriteLine(primos);

            /*
            for (var i = 2; i< n; i++)
            {
                if ((i % 1 == 0) && (i % i == 0))
                {
                    for (var j = 2; j < i; j++)
                    {
                        if ((i % j != 0) && (i != 1))
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
            */
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

        #region Ex6

        public static void Exercicio6()
        {

        }



        #endregion

        #region Ex7





        #endregion

        #region Ex8





        #endregion

        #region Ex9





        #endregion

        #region Ex10





        #endregion

        #region Ex11





        #endregion

        #region Ex12





        #endregion

        #region Ex13





        #endregion

        #region Ex14





        #endregion

        #region Ex15





        #endregion

        #region Old Ex1.6

        public static void Exercicio1_6()
        {
            var min = 1;
            var max = 100;
            var half = 50;
            var final = false;
            Console.WriteLine("Pense num número entre " + min + " e " + max + ".");

            while (final == false)
            {
                half = (min + max) / 2;

                if (half == (max - 1))
                {
                    Console.WriteLine("É " + half + "?");
                    var ans = Console.ReadLine();
                    if (ans == "S")
                    {
                        final = true;
                    }
                    else if (ans == "N")
                    {
                        Console.WriteLine("É " + (half + 1) + "?");
                        ans = Console.ReadLine();
                        if (ans == "S")
                        {
                            final = true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("É maior que " + half + "?");
                    var ans = Console.ReadLine();
                    if (ans == "S")
                    {
                        min = half;
                    }
                    else if (ans == "N")
                    {
                        max = half;
                    }
                    else
                    {
                        Console.WriteLine("Responda S ou N");
                    }
                }
            }
        }



        #endregion
    }
}
