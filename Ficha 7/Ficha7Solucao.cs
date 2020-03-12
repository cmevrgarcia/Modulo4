using System;

namespace Ficha_7
{
    public class Ficha7Solucao
    {
        #region Ex1.1

        public static void Exercicio1_1()
        {
            Console.WriteLine("Qual é o valor da nota?");
            var nota = double.Parse(Console.ReadLine());
            Exam(nota);
        }

        public static void Exam(double nota)
        {
            if (nota > 9.44)
            {

                Console.ForegroundColor
            = ConsoleColor.Green;
                Console.WriteLine("Passou");
                Console.ForegroundColor
                = ConsoleColor.White;
            }

            else
            {
                Console.ForegroundColor
            = ConsoleColor.Red;
                Console.WriteLine("Chumbou");
                Console.ForegroundColor
                = ConsoleColor.White;
            }

            /*
             * switch(nota)
             * {
             *  case (nota > 9.44): 
             *      Console.WriteLine("Passou"); 
             *  break;
             *  default 
             *      Console.WriteLine("Chumbou");
             *  break;
             */

            /*
             * return 
             *  Console.WriteLine("Passou"), nota > 9.44;
             *      Console.WriteLine("Chumbou"), nota < 9.44;
             */
        }

        #endregion

        #region Ex1.2

        public static void Exercicio1_2()
        {
            Console.WriteLine("Qual é a altura?");
            var altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o peso?");
            var peso = double.Parse(Console.ReadLine());
            BMICalc(altura, peso);
        }

        public static void BMICalc(double altura, double peso)
        {
            var bmi = peso / (altura * altura);
            if (bmi < 18.5)
                Console.WriteLine("Abaixo do peso");
            else if (bmi >= 18.5 && bmi <= 24.9)
                Console.WriteLine("Normal");
            else if (bmi >= 25 && bmi <= 29.9)
                Console.WriteLine("Acima do peso");
            else
                Console.WriteLine("Obeso");
        }

        #endregion

        #region Ex1.3

        public static void Exercicio1_3()
        {
            Console.WriteLine("Qual é o número?");
            var n = int.Parse(Console.ReadLine());
            Multressete(n);
        }

        public static void Multressete(int n)
        {
            if (((n % 3) == 0) && ((n % 7) == 0))
                Console.WriteLine("Múltiplo de 3 e 7");
            else if ((n % 3) == 0)
                Console.WriteLine("Múltiplo de 3");
            else if ((n % 7) == 0)
                Console.WriteLine("Múltiplo de 7");
            else
                Console.WriteLine("Não é múltiplo de 3 nem 7");
        }

        #endregion

        #region Ex1.4

        public static void Exercicio1_4()
        {
            Console.WriteLine("Qual é o número?");
            var n = int.Parse(Console.ReadLine());
            CheckIn(n);
        }

        public static void CheckIn(int n)
        {
            if ((n >= 30) && (n < 50))
                Console.WriteLine("Encontra-se entre 30 e 50, inclusive");
            else
                Console.WriteLine("Não se encontra entre 30 e 50, inclusive");
        }

        #endregion

        #region Ex1.5

        public static void Exercicio1_5()
        {
            Console.WriteLine("Qual é o número?");
            var n = int.Parse(Console.ReadLine());
            CheckEx(n);
        }

        public static void CheckEx(int n)
        {
            if ((n > 10) && (n < 20))
                Console.WriteLine("Encontra-se entre 10 e 20, exclusivo");
            else
                Console.WriteLine("Não se encontra entre 10 e 20, exclusivo");
        }

        #endregion

        #region Ex1.6

        public static void Exercicio1_6()
        {
            Console.WriteLine("Qual é o andar desejado?");
            var a = int.Parse(Console.ReadLine());
            Elevator(a);
        }

        public static void Elevator(int a)
        {
            if ((a > -2) && (a < 6) && (a == 3) && (a == 5))
                Console.WriteLine("Piso indisponivel");
            else
                Console.WriteLine("Piso" + a);
        }

        #endregion

        #region Ex1.7
        //do... while / while / for
        public static void Exercicio1_7a()
        {
            var i = 0;
            var c = 0;
            do
            {
                Console.WriteLine("Qual o número?");
                var n = int.Parse(Console.ReadLine());
                c = c + n;
                i++;
            }while (i < 10);
            Console.WriteLine("Soma = " + c);
        }

        public static void Exercicio1_7b()
        {
            var i = 0;
            var c = 0;
            while (i < 10)
            {
                Console.WriteLine("Qual o número?");
                var n = int.Parse(Console.ReadLine());
                c = c + n;
                i++;
            }
            Console.WriteLine("Soma = " + c);
        }

        public static void Exercicio1_7c()
        {
            var c = 0;
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("Qual o número?");
                var n = int.Parse(Console.ReadLine());
                c = c + n;
            }
            Console.WriteLine("Soma = " + c);
        }



        #endregion

        #region Ex1.8

        public static void Exercicio1_8()
        {
            double tt = 0;
            string t = "";
            for (var i = 1; i < 6; i++)
            {
                Console.WriteLine("Qual é o nome do "+ i + "º artigo?");
                var n = Console.ReadLine();
                Console.WriteLine("Qual é o valor de " + n + "?");
                var p = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantas unidades de " + n + "?");
                var q = double.Parse(Console.ReadLine());
                tt = tt + (p * q);
                t+= n + " - " + Convert.ToString(p * q) + '\n';
            }
            Console.WriteLine(t);
            Console.WriteLine("------------" + '\n' +
                              "Total - " + tt);
        }



        #endregion

        #region Ex1.9

        public static void Exercicio1_9()
        {
            var i = 0;
            double c = 0;
            double n = 0;
            do
            {
                Console.WriteLine("Qual o número?");
                n = double.Parse(Console.ReadLine());
                c = c + n;
                i++;
            }
            while (n != 0);
            Console.WriteLine("Média = " + (c / i));
        }    



        #endregion

        #region Ex1.10

        public static void Exercicio1_10()
        {
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
        }



        #endregion

        #region Ex1.11

        public static void Exercicio1_11()
        {
            Console.WriteLine("Qual é o caracter?");
            var c = Console.ReadLine();
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Console.Write(c);
                    Console.Write(" ");
                }
                Console.Write('\n');
            }
        }



        #endregion

        #region Ex1.12

        public static void Exercicio1_12()
        {
            Console.WriteLine("Qual é o caracter?");
            var c = Console.ReadLine();
            Console.WriteLine("Qual é o número?");
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    Console.Write(c);
                    Console.Write(" ");
                }
                Console.Write('\n');
            }
        }



        #endregion

        #region Ex1.13

        public static void Exercicio1_13()
        {
            Console.WriteLine("Qual é o caracter?");
            var c = Console.ReadLine();
            Console.WriteLine("Qual é o número de colunas?");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o número de linhas?");
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    Console.Write(c);
                    Console.Write(" ");
                }
                Console.Write('\n');
            }
        }



        #endregion


        #region Ex2.1

        public static void Exercicio2_1()
        {
            Console.WriteLine("Introduz a temperatura");
            double temp = double.Parse(Console.ReadLine());
            var escala = "";
            while ((escala != "C") && (escala != "K") && (escala != "F"))
            {
                Console.WriteLine("Em que escala ? (C, K ou F)");
                escala = Console.ReadLine();
            }
            if (escala == "C")
            {
                Console.WriteLine(temp + "ºC é equivalente a " + Math.Round((temp + 273.15), 2) + "K e " + Math.Round((temp * 9 / 5 + 32), 2) + "ºF");
            }
            else if (escala == "K")
            {
                Console.WriteLine(temp + "K é equivalente a " + Math.Round((temp - 273.15), 2) + "ºC e " + Math.Round((temp * 9 / 5 - 459.67), 2) + "ºF");
            }
            else if (escala == "F")
            {
                Console.WriteLine(temp + "ºF é equivalente a " + Math.Round(((temp- 32) * 5 / 9), 2) + "ºC e " + Math.Round(((temp + 459.67) * 5 / 9), 2) + "K");
            }
        }



        #endregion

        #region Ex2.2

        public static void Exercicio2_2()
        {
            Console.WriteLine("Qual é o número limite?");
            var num = int.Parse(Console.ReadLine());
            for (var cont = 0; cont != num; cont++)
            {
                if (cont % 2 == 1)
                {
                    Console.WriteLine(cont);
                }
            }
        }



        #endregion

        #region Ex2.3

        public static void Exercicio2_3()
        {
            var caracteres = "";
            var caracter = "";
            do
            {
                Console.WriteLine("Introduz um número, ou enter para terminar");
                caracter = Console.ReadLine();
                caracteres = caracter + caracteres;
            }
            while (caracter != "");
            Console.WriteLine(caracteres);
        }



        #endregion


        #region Ex3.1

        public static void Exercicio3_1()
        {
            Console.WriteLine("Introduz um número");
            var n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine(n * 3);
            }
            else
                Console.WriteLine(n * 2);
        }



        #endregion

        #region Ex3.2

        public static void Exercicio3_2()
        {
            Console.WriteLine("Qual é a dimensão do triangulo?");
            var n = int.Parse(Console.ReadLine());
            var i = 1;
            while (n > 0)
            {
                n--;
                var a = 0;
                while (a != n)
                {
                    Console.Write(" ");
                    a++;
                }
                var b = 0;
                while (b != i)
                {
                    Console.Write("*");
                    b++;
                }
                i += 2;
                Console.WriteLine(" ");
            }
        }



        #endregion
    }
}
