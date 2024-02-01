using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[20];
            int[] idades = new int[20];
            char[] sexo = new char[20];


            int opcao;
            char pergunta;

            while (true)
            {


                Console.WriteLine(" =======BEM VINDO AO SISTEMA ESCOLAR========");
                Console.WriteLine("============================================");
                Console.WriteLine("          (1) Adicionar Aluno");
                Console.WriteLine("============================================");
                Console.WriteLine("          (2) Acessar a lista dos alunos");
                Console.WriteLine("============================================");
                Console.WriteLine("          (3) Sair");
                Console.WriteLine("============================================");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)

                    for (int index = 0; index < nomes.Length; index++)
                    {
                        Console.WriteLine("Digite o nome do aluno: ");
                        nomes[index] = Console.ReadLine();

                        Console.WriteLine("Digite a idade do aluno {0}: ", index + 1);
                        idades[index] = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o sexo do aluno (M/F) {0}: ", index + 1);
                        sexo[index] = char.Parse(Console.ReadLine());

                        Console.WriteLine("=====Aluno Cadastrado com Sucesso=====");
                        Thread.Sleep(2000);
                        Console.Clear();

                        Console.WriteLine("Você quer adicionar mais algum Aluno? S/N");
                        pergunta = char.Parse(Console.ReadLine());

                        
                        if (pergunta == 'n' || pergunta == 'N')
                        {
                            break;
                        }

                    }
                if (opcao == 2)
                {
                    Console.WriteLine($"LISTA DE ALUNOS");
                    for (int index = 0; index < nomes.Length; index++)
                    {
                        Console.WriteLine($"{index + 1} - {nomes[index]} - Idade {idades[index]} - Sexo {sexo[index]}");
                       // Console.WriteLine("Qual o numero de aluno você deseja ver");
                       // int.Parse(Console.ReadLine());

                        

                    }




                }
            }
        }


    }
}
