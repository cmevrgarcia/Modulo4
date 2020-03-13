using System;

namespace Ficha13
{
    public class Ficha13Solucao
    {
        #region Ex1
        /// <summary>
        /// Calculadora
        /// </summary>
        public static void Exercicio1()
        {


            /*
            Console.WriteLine("| Calculadora |" + '\n' +
                              "\\_____________/");
            
            Console.WriteLine("Número");
            bool isFstNumANum = double.TryParse(Console.ReadLine(), out double fstNum);
            if (isFstNumANum)
            {
                var op = "to be filled";
                while (op != "")
                {
                    Console.WriteLine("Operação (+, -, *, /, %)");
                    op = Console.ReadLine();
                    Console.WriteLine("Número");
                    bool isSndNumANum = double.TryParse(Console.ReadLine(), out double sndNum);
                    if (isSndNumANum)
                    {


                        if (op == "+")
                        {
                            Console.Clear();
                            Console.WriteLine("| Calculadora |" + '\n' +
                              "\\_____________/");
                            Console.WriteLine(fstNum + " + " + sndNum + " = " + (fstNum + sndNum));
                            fstNum = fstNum + sndNum;
                        }
                        else if (op == "-")
                        {
                            Console.Clear();
                            Console.WriteLine("| Calculadora |" + '\n' +
                              "\\_____________/");
                            Console.WriteLine(fstNum + " - " + sndNum + " = " + (fstNum - sndNum));
                            fstNum = fstNum - sndNum;
                        }
                        else if ((op == "*") || (op == "x") || (op == "X"))
                        {

                            Console.Clear();
                            Console.WriteLine("| Calculadora |" + '\n' +
                              "\\_____________/");
                            Console.WriteLine(fstNum + " * " + sndNum + " = " + (fstNum * sndNum));
                            fstNum = fstNum * sndNum;
                        }
                        else if (op == "/")
                        {
                            Console.Clear();
                            Console.WriteLine("| Calculadora |" + '\n' +
                              "\\_____________/");
                            if (sndNum == 0)
                            {
                                Console.WriteLine("Impossivel dividir por 0");
                            }
                            else
                            {
                                Console.WriteLine(fstNum + " / " + sndNum + " = " + (fstNum / sndNum));
                                fstNum = fstNum / sndNum;
                            }
                        }
                        else if (op == "%")
                        {
                            Console.Clear();
                            Console.WriteLine("| Calculadora |" + '\n' +
                              "\\_____________/");
                            Console.WriteLine(fstNum + " % " + sndNum + " = " + (fstNum % sndNum));
                            fstNum = fstNum % sndNum;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("| Calculadora |" + '\n' +
                              "\\_____________/");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(op + " não é uma operação válida");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        sndNum = double.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("| Calculadora |" + '\n' +
                          "\\_____________/");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Não é um número válido");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine("Número");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("| Calculadora |" + '\n' +
                  "\\_____________/");
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Não é um número válido");
                Console.ForegroundColor = ConsoleColor.White;
            }
            */
        }





        #endregion

        #region Ex2
        /// <summary>
        /// Jogo do galo
        /// </summary>
        public static void Exercicio2()
        {
            var a1 = " ";
            var a2 = " ";
            var a3 = " ";
            var b1 = " ";
            var b2 = " ";
            var b3 = " ";
            var c1 = " ";
            var c2 = " ";
            var c3 = " ";
            Console.WriteLine("Jogo do galo" + '\n' +
                              "/-----------\\" + '\n' +
                              "|   |   |   |" + '\n' +
                              "| " + a1 + " | " + a2 + " | " + a3 + " |" + '\n' +
                              "|   |   |   |" + '\n' +
                              "|-----------\\" + '\n' +
                              "|   |   |   |" + '\n' +
                              "| " + b1 + " | " + b2 + " | " + b3 + " |" + '\n' +
                              "|   |   |   |" + '\n' +
                              "|-----------\\" + '\n' +
                              "|   |   |   |" + '\n' +
                              "| " + c1 + " | " + c2 + " | " + c3 + " |" + '\n' +
                              "|   |   |   |" + '\n' +
                              "\\-----------/");

        }



        #endregion

        #region Ex3
        /// <summary>
        /// Jogo da forca
        /// </summary>
        public static void Exercicio3()
        {

        }



        #endregion

    }
}
