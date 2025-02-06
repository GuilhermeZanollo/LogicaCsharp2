using System;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace testes_ec 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 5;

            Console.WriteLine("Bom dia");

            if (x > 0)
            {
                Console.WriteLine("Boa tarde");
            }

            Console.WriteLine("Boa noite");
            */

            /*
            Console.WriteLine("Que horas são?");
            int horas = int.Parse(Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else
            {
                Console.WriteLine("Boa tarde");
            }
            */

            /*
            Console.WriteLine("Que horas são?");
            int horas = int.Parse(Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else
            {
                if (horas < 18)
                {
                    Console.WriteLine("Boa tarde!");
                }
                else {
                    Console.WriteLine("Boa noite!");
                }
            } 
            */

            /*
            //Outra forma de fazer:
            Console.WriteLine("Que horas são?");
            int horas = int.Parse(Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (horas < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
            */

            /*
            // Exercício 1
            Fazer um programa para ler as duas notas que um aluno obteve no primeiro e segundo semestres de uma disciplina anual. Em seguida
            mostrar a nota final que o aluno obteve no ano juntamente com um texto explicativo. Caso a nota final do aluno seja inferior a
            60.00, mostrar a mensagem "REPROVADO", conforme exemplos. Todos os valores devem ter uma casa decimal.

            Console.WriteLine("Informe a primeira nota do aluno: ");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe a segunda nota do aluno: ");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaFinal = nota1 + nota2;

            if (notaFinal >= 60)
            {
                Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1", CultureInfo.InvariantCulture) + "\nREPROVADO");
            }
            */

            /* URI 1036 Fórmula de Bhaskara
            // Exercício 2 

            Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for possível calcular as raízes, 
            mostre a mensagem correspondente “Impossivel calcular”, caso haja uma divisão por 0 ou raiz de numero negativo.

            Entrada
            Leia três valores de ponto flutuante (double) A, B e C.

            Saída
            Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular". Caso contrário, imprima o 
            resultado das raízes com 5 dígitos após o ponto, com uma mensagem correspondente conforme exemplo abaixo. Imprima sempre o 
            final de linha após cada mensagem.
            */

            /*
            string[] vet = Console.ReadLine().Split(' ');
            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);
            
            double delta = Math.Pow(B, 2.0) - 4 * A * C;

            double r1, r2;

            if (A == 0 || delta < 0.0) {
                Console.WriteLine("Impossível calcular");
            }
            else
            {
                r1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
                r2 = (-B - Math.Sqrt(delta)) / (2.0 * A);
                Console.WriteLine("R1 = " +  r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " +  r2.ToString("F5", CultureInfo.InvariantCulture));
            }
            */

            /*
            // Exercício 3
            Fazer um programa para ler três números inteiros. Em seguida, mostrar qual o menor dentre os três números lidos. Em caso
            de empate, mostrar apenas uma vez.

            string[] vet = Console.ReadLine().Split(' ');
            int number1 = int.Parse(vet[0], CultureInfo.InvariantCulture);
            int number2 = int.Parse(vet[1], CultureInfo.InvariantCulture);
            int number3 = int.Parse(vet[2], CultureInfo.InvariantCulture);

            if (number1 < number2 && number1 < number3)
            {
                Console.WriteLine("MENOR = " + number1);
            }
            else if (number2 < number1 && number2 < number3) //-> CÓDIGO REDUNDANTE, PODERIA SER APENNAS else if (number2 < number3) pOIS JÁ FOI VISTO QUE O PRIMEIRO NUMERO NAO É MENOR DE TODOS.
            {
                Console.WriteLine("MENOR = " + number2);
            }
            else
            {
                Console.WriteLine("MENOR = " + number3);
            }
            */

            /*
            // Exercicio OPERADORES DE ATRIBUIÇÃO CUMULATIVA
            Uma operadora de telefonia cobra r$ 50.00 por um plano básico que dá direito a 100 minutos de telefone. Cada minuto que 
            exceder a franquia de 100 minutos custa R$ 2.00. Fazer um programa para ler a quantidade de minutos que uma pessoa consumiu, dai 
            mostrar o valor a ser pago.

            int minutos = int.Parse(Console.ReadLine());
            double conta = 50.00;

            if (minutos > 100)
            {
                conta = conta + (minutos - 100) * 2.0; // DESCUBRO O EXCEDENTE ATRAVES DA DIFERENÇA, PEGO A DIFERENCA E MULTIPLICO POR 2
            }                                          // PODE SER ESCRITO: conta += (minutos - 100) * 2.0;

            Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*
            //Exercicio estrutura switch-case
            Fazer um programa para ler um valor inteiro de 1 a 7 representando um dia da semana (sendo 1 = domingo, 2 = segunda, e assim por diante);
            Escrever na tela o dia da semana correspondente, conforme exemplos.

            int x = int.Parse(Console.ReadLine());
            string dia;

            if (x == 1)
            {
                dia = "Domingo";
            }
            else if (x == 2)
            {
                dia = "Segunda";
            }
            else if(x == 3)
            {
                dia = "Terça-feira";
            }
            else if(x == 4)
            {
                dia = "Quarta-feira";
            }
            else if(x == 5)
            {
                dia = "Quinta-feira";
            }
            else if(x == 6)
            {
                dia = "Sexta-feira";
            }
            else if(x == 7)
            {
                dia = "Sábado";
            }
            else
            {
                dia = "valor inválido";
            }

            Console.WriteLine("Dia da semana: " + dia);

            OUTRA FORMA UTILIZANDO O SWITCH CASE:

            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x) {
                case 1:
                    dia = "domingo";
                    break;
                case 2:
                    dia = "segunda";
                    break;
                case 3:
                    dia = "terça";
                    break;
                case 4:
                    dia = "quarta";
                    break;
                case 5:
                    dia = "quinta";
                    break;
                case 6:
                    dia = "sexta";
                    break;
                case 7:
                    dia = "sabado";
                    break;
                default:
                    dia = "valor inválido";
                    break;

            Console.WriteLine("Dia da semana: " + dia);
            */

            /*
            Estudo mínimo recomendado:

             - Primeiro grupo (mais básicos): 1035, 1038, 1044, 1046, 1048

             - Segundo grupo: 1037, 1040 (use float), 1041, 1045, 1047, 1049, 1051

              Exercícios suplementares:

             - 1042, 1043, 1050, 1052, 1060, 1064, 1065, 1066, 1070

            */





            Console.ReadLine();
        }
    }
}


