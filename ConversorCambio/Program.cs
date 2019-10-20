using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorCambio
{
    class Program
    {
        static void Main(string[] args)
        {
            int real = 1;
                    double dolar = 4.16;
                    double euro = 4.60;
                    double multi1;
                    double multi2;
                    int op;

                    do
                    {
                        Console.Clear();
                        Console.Write("O aumento da tensão comercial entre Estados Unidos e China influenciou até no valor do dólar para os brasileiros, um valor próximo ao do euro. Veja como estava a conversão no segundo semeste de 2019\n\n");
                        Console.WriteLine("1 - Dólar");
                        Console.WriteLine("2 - Euro");
                        Console.WriteLine("3 - Sair");

                        Console.WriteLine("Informa a opção desejada \n"); op = int.Parse(Console.ReadLine());


                        switch (op)
                        {
                            case 1: Console.Write("Digite um valor em real: "); real = int.Parse(Console.ReadLine());
                                multi1 = dolar * real;
                                Console.Write( multi1 + " dólares");
                                break;


                            case 2: Console.Write("Digite um valor em real: ");   real=int.Parse(Console.ReadLine());
                                multi2 = euro * real;
                                Console.Write( multi2 + " euros");
                                break;


                            case 3: Console.WriteLine("Fim da execução do programa!");
                                break;

                            default: Console.WriteLine("Opção inválida - Tente novamente");
                                break;

                        }
                        Console.WriteLine("\nTecle algo para continuar");
                        Console.ReadKey();

                    } while (op != 3);
                
        }
    }
}
