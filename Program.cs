using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Treinando1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine("Hello World!!!");

            Console.WriteLine("Hoje vou estar treinando um pouco aqui, aleatóriamente, então que comece os JOGOS!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Primeiro, quero fazer alguns exemplos para pegar algumas informações sobre você e exibir na tela.\n");
            Console.WriteLine("Qual o seu nome? ");
            String nome = Console.ReadLine();
            Console.WriteLine("Então o seu nome é {0}, muito prazer!", nome);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Quantos anos você tem {0}? ", nome);
            String input = Console.ReadLine();
            int idade = Int32.Parse(input);
            if (idade >= 18)
            {
                Console.WriteLine("Bom demais, você tem {0} anos de idade e é ja resposabiliza por seus atos!", idade);
            }
            else
            {
                Console.WriteLine("Bacana, então você tem {0} anos de idade e ainda não e responsável por seus atos!", idade);
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Você mora em qual cidade? ");
            String cidade = Console.ReadLine();
            Console.WriteLine("Muito bom, você mora em {0}.", cidade);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Pegando todas as informações que me passou.\nVocê se chama {0}, tem {1} anos de idade e mora na cidada de {2}.", nome, idade, cidade);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Certo, agora que fazer algumas operações matemáticas com você!\n");
            Console.WriteLine("Preciso que me fale um valor qualquer para darmos a variável A: ");
            String input2 = Console.ReadLine();
            int A = Int32.Parse(input2);
            Console.WriteLine("Preciso que me fale um valor qualquer para darmos a variável B: ");
            String input3 = Console.ReadLine();
            int B = Int32.Parse(input3);
            bool repetir = true;
            do
            {
                Console.WriteLine("Digite uma opção:");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtracao");
                Console.WriteLine("3 - Multiplicacao");
                Console.WriteLine("4 - Divisao");
                Console.WriteLine("0 - Sair");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        int soma = A + B;
                        Console.WriteLine("O valor de A é igual a {0} e o valor de B é igual a {1}. Então a soma deles é igual a {2}", A, B, soma);
                        break;
                    case 2:
                        int subtracao = A - B;
                        Console.WriteLine("O valor de A é igual a {0} e o valor de B é igual a {1}. Então a subtracao deles é igual a {2}", A, B, subtracao);
                        break;
                    case 3:
                        double multiplicação = A * B;
                        Console.WriteLine("O valor de A é igual a {0} e o valor de B é igual a {1}. Então a multiplicacao deles é igual a {2}", A, B, multiplicação);
                        break;
                    case 4:
                        if (B == 0)
                        {
                            Console.WriteLine("Não se pode dividir por 0.");
                            break;
                        }else
                        {
                            double divisao = A / B;
                            Console.WriteLine("O valor de A é igual a {0} e o valor de B é igual a {1}. Então a divisao deles é igual a {2}", A, B, divisao);
                            break;
                        }

                    case 0:
                        repetir = false;
                        Console.WriteLine("Agora vamos fazer uma média de algumas notas.\n");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (repetir);

            Console.Clear();
            Console.WriteLine("Digite o valor da primeira nota: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor da segunda nota: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor da terceira nota: ");
            int z = Convert.ToInt32(Console.ReadLine());

            double media = (x + y + z) / 3;

            Console.WriteLine("A media é {0}", media.ToString("N2"));
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Por enquanto é só!");
        }
    }
}