using System;

namespace Ficha6
{
    
    public class Ficha6Solucao
    {
        
        #region Exercicio1

        public static void Exercicio1()
        {
            Console.WriteLine("Qual é o nome?");
            var nome = Console.ReadLine();
            OlaNome(nome);
        }

        /// <summary>
        /// Escreve Olá
        /// </summary>
        /// <param name="nome">O nome a apresentar</param>
        private static void OlaNome(string nome)
        {
            Console.WriteLine("Olá " + nome);
        }

        #endregion

        #region Ex2

        public static void Exercicio2()
        {
            Console.WriteLine("Qual é o primeiro número?");
            var num1 = (Console.ReadLine());
            Console.WriteLine("Qual é o segundo número?");
            var num2 = (Console.ReadLine());
            var num1Conv = ConvertStringParaNumero(num1);
            var num2Conv = ConvertStringParaNumero(num2);
            Soma2(num1Conv, num2Conv);
        }

        /// <summary>
        /// Converte strigs para números
        /// </summary>
        /// <param name="num"> String a ser convertida </param>
        /// <returns></returns>
        public static int ConvertStringParaNumero(string num)
        {
            var parseOk = int.TryParse(num, out int parsedNum);
            return parsedNum;

        }

        /// <summary>
        /// Soma dois números
        /// </summary>
        /// <param name="num1Conv"> Primeiro número </param>
        /// <param name="num2Conv"> Segundo número </param>
        public static void Soma2(int num1Conv, int num2Conv)
        {
            Console.WriteLine("A soma de " + num1Conv + " com " + num2Conv + " é " + (num1Conv + num2Conv));
        }

        #endregion

        #region Ex3 

        public static void Exercicio3()
        {
            ///*
            Console.WriteLine("Qual é o primeiro número?");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o segundo número?");
            var num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o terceiro número?");
            var num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o quarto número?");
            var num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o quinto número?");
            var num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o sexto número?");
            var num6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o sétimo número?");
            var num7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o oitavo número?");
            var num8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o nono número?");
            var num9 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o décimo número?");
            var num10 = int.Parse(Console.ReadLine());
            Soma10(num1, num2, num3, num4, num5, num6, num7, num8, num9, num10);
            //*/


            //ou
            //var total = LerNumEConverter();
            //total += LerNumEConverter();
            //total += LerNumEConverter();
            //total += LerNumEConverter();
            //total += LerNumEConverter();
            //total += LerNumEConverter();
            //total += LerNumEConverter();
            //total += LerNumEConverter();
            //total += LerNumEConverter();
            //total += LerNumEConverter();
            //Console.WriteLine(total);
        }

        public static int LerNumEConverter()
        {
            Console.WriteLine("Número");
            var num = Console.ReadLine();
            var numParsed = ConvertStringParaNumero(num);
            return numParsed;
        }


        /// <summary>
        /// Soma dez números
        /// </summary>
        /// <param name="num1"> Primeiro número </param>
        /// <param name="num2"> Segundo número </param>
        public static void Soma10(int num1, int num2, int num3, int num4, int num5, int num6, int num7, int num8, int num9, int num10)
        {
            Console.WriteLine("A soma dos números " + num1 + ", " + num2 + ", " + num3 + ", " + num4 + ", " + num5 + ", " + num6 + ", " + num7 + ", " + num8 + ", " + num9 + " e " + num10 + " é " + (num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9+ num10));
        }


        #endregion

        #region Ex4 

        public static void Exercicio4()
        {
            Console.WriteLine("Qual é o valor de a?");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o valor de b?");
            var b = int.Parse(Console.ReadLine());
            var c = 0;
            Swap(a, b, c);
            
        }

        public static void Swap(int a, int b, int c)
        {
            c = a;
            a = b;
            b = c;
            Console.WriteLine("A = " + a + " e B = " + b);
        }

        #endregion

        #region Ex5 

        public static void Exercicio5a()
        {
            Console.WriteLine("Para a + (b * c) > Qual é o valor de a?");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Para a + (b * c) > Qual é o valor de b?");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Para a + (b * c) > Qual é o valor de c?");
            var c = int.Parse(Console.ReadLine());
            Op1(a, b, c);

        }

        public static void Op1(int a, int b, int c)
        {
            Console.WriteLine("Resultado = " + (a + (b * c)) + '\n');
        }


        public static void Exercicio5b()
        {
            Console.WriteLine("Para - a + (b * c) > Qual é o valor de a?");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Para - a + (b * c) > Qual é o valor de b?");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Para - a + (b * c) > Qual é o valor de c?");
            var c = int.Parse(Console.ReadLine());
            Op2(a, b, c);

        }

        public static void Op2(int a, int b, int c)
        {
            Console.WriteLine("Resultado = " + (- a + (b * c)) + '\n');
        }


        public static void Exercicio5c()
        {
            Console.WriteLine("Para (a + b) % c > Qual é o valor de a?");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Para (a + b) % c > Qual é o valor de b?");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Para (a + b) % c > Qual é o valor de c?");
            var c = int.Parse(Console.ReadLine());
            Op3(a, b, c);

        }

        public static void Op3(int a, int b, int c)
        {
            Console.WriteLine("Resultado = " + ((a + b) % c) + '\n');
        }


        public static void Exercicio5d()
        {
            Console.WriteLine("Para a + ((b * c) / d) > Qual é o valor de a?");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Para a + ((b * c) / d) > Qual é o valor de b?");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Para a + ((b * c) / d) > Qual é o valor de c?");
            var c = int.Parse(Console.ReadLine());
            Console.WriteLine("Para a + ((b * c) / d) > Qual é o valor de d?");
            var d = int.Parse(Console.ReadLine());
            Op4(a, b, c, d);

        }

        public static void Op4(int a, int b, int c, int d)
        {
            Console.WriteLine("Resultado = " + (a + ((b * c) / d)) + '\n');
        }


        public static void Exercicio5e()
        {
            Console.WriteLine("Para a + ((b / c) * d) - (e % f) > Qual é o valor de a?");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Para a + ((b / c) * d) - (e % f) > Qual é o valor de b?");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Para a + ((b / c) * d) - (e % f) > Qual é o valor de c?");
            var c = int.Parse(Console.ReadLine());
            Console.WriteLine("Para a + ((b / c) * d) - (e % f) > Qual é o valor de d?");
            var d = int.Parse(Console.ReadLine());
            Console.WriteLine("Para a + ((b / c) * d) - (e % f) > Qual é o valor de e?");
            var e = int.Parse(Console.ReadLine());
            Console.WriteLine("Para a + ((b / c) * d) - (e % f) > Qual é o valor de f?");
            var f = int.Parse(Console.ReadLine());
            Op5(a, b, c, d, e, f);

        }

        public static void Op5(int a, int b, int c, int d, int e, int f)
        {
            Console.WriteLine("Resultado = " + (a + ((b / c) * d) - (e % f)));
        }


        #endregion

        #region Ex6

        public static void Exercicio6()
        {
            Console.WriteLine("Qual é o número?");
            var n = int.Parse(Console.ReadLine());
            MulTab(n);
        }

        public static void MulTab(int n)
        {
            Console.WriteLine(n + " * 0 = " + (n * 0) + '\n' +
                              n + " * 1 = " + (n * 1) + '\n' +
                              n + " * 2 = " + (n * 2) + '\n' +
                              n + " * 3 = " + (n * 3) + '\n' +
                              n + " * 4 = " + (n * 4) + '\n' +
                              n + " * 5 = " + (n * 5) + '\n' +
                              n + " * 6 = " + (n * 6) + '\n' +
                              n + " * 7 = " + (n * 7) + '\n' +
                              n + " * 8 = " + (n * 8) + '\n' +
                              n + " * 9 = " + (n * 9) + '\n' +
                              n + " * 10 = " + (n * 10) + '\n');
        }

        #endregion

        #region Ex7 

        public static void Exercicio7()
        {
            Console.WriteLine("Qual é o primeiro número?");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o segundo número?");
            var b = int.Parse(Console.ReadLine());
            Avg2(a, b);
        }

        public static void Avg2(int a, int b)
        {
            Console.WriteLine("A média dos dois números é " + ((a + b) / 2));
        }

        #endregion

        #region Ex8 

        public static void Exercicio8()
        {
            Console.WriteLine("Qual é o primeiro número?");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o segundo número?");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o terceiro número?");
            var c = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o quarto número?");
            var d = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o quinto número?");
            var e = int.Parse(Console.ReadLine());
            Avg5(a, b, c, d, e);
        }

        public static void Avg5(int a, int b, int c, int d, int e)
        {
            Console.WriteLine("A média dos cinco números é " + ((a + b + c + d + e) / 5));
        }

        #endregion

        #region Ex9 

        public static void Exercicio9()
        {
            Console.WriteLine("Qual é o primeiro número?");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o segundo número?");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o terceiro número?");
            var c = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o quarto número?");
            var d = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o quinto número?");
            var e = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o sexto número?");
            var f = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o sétimo número?");
            var g = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o oitavo número?");
            var h = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o nono número?");
            var i = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o décimo número?");
            var j = int.Parse(Console.ReadLine());
            Avg10(a, b, c, d, e, f, g, h, i, j);
        }

        public static void Avg10(int a, int b, int c, int d, int e,int f, int g, int h,int i, int j)
        {
            Console.WriteLine("A média dos dez números é " + ((a + b + c + d + e + f + g + h + i + j) / 10));
        }

        #endregion

        #region Ex10 

        public static void Exercicio10()
        {
            Console.WriteLine("Qual é o caracter?");
            var c = Console.ReadLine();
            Tab(c);
        }

        public static void Tab(string c)
        {
            Console.WriteLine(c + " " + c + " " + c + '\n' +
                              c + " " + c + " " + c + '\n' +
                              c + " " + c + " " + c);
        }

        #endregion

        #region Ex11 

        public static void Exercicio11()
        {
            Console.WriteLine("Qual é o nome do primeiro artigo?");
            var n1 = Console.ReadLine();
            Console.WriteLine("Qual é o valor do primeiro artigo?");
            var p1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantas unidades do primeiro artigo?");
            var q1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o nome do segundo artigo?");
            var n2 = Console.ReadLine();
            Console.WriteLine("Qual é o valor do segundo artigo?");
            var p2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantas unidades do segundo artigo?");
            var q2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o nome do terceiro artigo?");
            var n3 = Console.ReadLine();
            Console.WriteLine("Qual é o valor do terceiro artigo?");
            var p3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantas unidades do terceiro artigo?");
            var q3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o nome do quarto artigo?");
            var n4 = Console.ReadLine();
            Console.WriteLine("Qual é o valor do quarto artigo?");
            var p4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantas unidades do quarto artigo?");
            var q4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o nome do quinto artigo?");
            var n5 = Console.ReadLine();
            Console.WriteLine("Qual é o valor do quinto artigo?");
            var p5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantas unidades do quinto artigo?");
            var q5 = int.Parse(Console.ReadLine());
            Recipt(n1, p1, q1, n2, p2, q2, n3, p3, q3, n4, p4, q4, n5, p5, q5);
        }

        public static void Recipt(string n1, double p1, int q1, string n2, double p2, int q2, string n3, double p3, int q3, string n4, double p4, int q4, string n5, double p5, int q5)
        {
            var t1 = p1 * q1;
            var t2 = p2 * q2;
            var t3 = p3 * q3;
            var t4 = p4 * q4;
            var t5 = p5 * q5;
            var tt = t1 + t2 + t3 + t4 + t5;
            Console.WriteLine(n1 + " - " + t1 + '\n' +
                              n2 + " - " + t2 + '\n' +
                              n3 + " - " + t3 + '\n' +
                              n4 + " - " + t4 + '\n' +
                              n5 + " - " + t5 + '\n' +
                              "-------------" + '\n' +
                              "Total - " + tt);
        }

        #endregion


        #region Ex 6.2.1

        public static void Exercicio2_1()
        {
            Console.WriteLine("Diz-me algo que eu não saiba");
            var x = Console.ReadLine();
            Ja(x);
        }

        public static void Ja(string x)
        {
            Console.WriteLine("Eu já sabia que " + x);
        }

        #endregion

        #region Ex 6.2.2

        public static void Exercicio2_2()
        {
            Console.WriteLine("Introduz dois números");
            var fstNum = int.Parse(Console.ReadLine());
            var sndNum = int.Parse(Console.ReadLine());
            Present(fstNum, sndNum);
        }

        public static void Present(int fstNum, int sndNum)
        {
            Console.WriteLine("O primeiro número é " + fstNum + " e o segundo número é " + sndNum);
        }

        #endregion

        #region Ex 6.2.3

        public static void Exercicio2_3()
        {
            Console.WriteLine("Introduz a temperatura");
            var temp = double.Parse(Console.ReadLine());
            Convert(temp);
        }

        public static void Convert(double temp)
        {
            var tempF = temp * 9 / 5 + 32;
            var tempK = temp + 275.15;
            Console.WriteLine("A temperatura " + temp + "ºC é " + tempF + "ºF e " + tempK + "ºK");
        }

        #endregion


        #region Ex 6.3.1

        public static void Exercicio3_1()
        {
            Console.WriteLine("Quantas horas?");
            var horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos minutos?");
            var minutos = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos segundos?");
            var segundos = int.Parse(Console.ReadLine());
            TotalS(horas, minutos, segundos);
        }

        public static void TotalS(int horas, int minutos, int segundos)
        {
            var Total = horas * 3600 + minutos * 60 + segundos;
            Console.WriteLine(horas + " : " + minutos + " : " + segundos + " é equivalente a " + Total + " segundos");
        }

        #endregion

        #region Ex 6.3.2

        public static void Exercicio3_2()
        {
            Console.WriteLine("Qual é o raio?");
            var raio = int.Parse(Console.ReadLine());
            ArPr(raio);
            //var perimetro = CalcPerimetro(raio);
            //var area = CalcArea(raio);
        }

        public static void ArPr(int raio)
        {
            var perimetro = 2 * 3.14 * raio;
            var area = 3.14 * raio * raio;
            Console.WriteLine("A área do circulo é " + area + " e o perímetro é " + perimetro);
        }

        public static double CalcPerimetro(int raio)
        {
            double perimetro = 2 * 3.14 * raio;
            return perimetro;
        }

        public static double CalcArea(int raio)
        {
            double area = 3.14 * raio * raio;
            return area;
        }
        //Separar a segunda função em calcular perimetro e calcular area.
        #endregion

    }
}


    
