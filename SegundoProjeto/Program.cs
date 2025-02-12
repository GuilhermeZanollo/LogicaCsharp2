using System;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
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

            /*
            //1035 URI
            Leia 4 valores inteiros A, B, C e D. A seguir, se B for maior do que C e se D for maior do que A, e a soma de C com D for 
            maior que a soma de A e B e se C e D, ambos, forem positivos e se a variável A for par escrever a mensagem "Valores aceitos", 
            senão escrever "Valores nao aceitos".

            Entrada
            Quatro números inteiros A, B, C e D.

            Saída
            Mostre a respectiva mensagem após a validação dos valores.  
           

            string[] valores = Console.ReadLine().Split(' ');

            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);
            int C = int.Parse(valores[2]);
            int D = int.Parse(valores[3]);

            if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            } 
            else {
                Console.WriteLine("Valores não aceitos");
            }
            */

            /*
            // 1038 URI
            Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, 
            calcule e mostre o valor da conta a pagar.

            
            string[] values = Console.ReadLine().Split(' ');

            int codeProduct = int.Parse(values[0]);
            int quantity = int.Parse(values[1]);

            double total;

            if (codeProduct == 1)
            {
                total = quantity * 4.00;
            }
            else if (codeProduct == 2)
            {
                total = quantity * 4.50;
            }
            else if (codeProduct == 3) 
            {
                total = quantity * 5.00;
            }
            else if (codeProduct == 4)
            {
                total = quantity * 2.00;
            }
            else
            {
                total = quantity * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*
            // 1044 URI 
            Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.

            Entrada
            A entrada contém valores inteiros.

            Saída
            A saída deve conter uma das mensagens conforme descrito acima.

            string[] values = Console.ReadLine().Split(' ');

            int A = int.Parse(values[0]);
            int B = int.Parse(values[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("São múltiplos");
            }
            else
            {
                Console.WriteLine("Não são múltiplos");
            }

            */

            /*
            // 1046 URI
            Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia 
            e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

            Entrada
            A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.

            Saída
            Apresente a duração do jogo conforme exemplo abaixo.

            string[] values = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(values[0]);
            int horaFinal = int.Parse(values[1]);

            int duracao;

            if (horaInicial < horaFinal) // SE O JOGO COMEÇOU COM HORA INICIAL MENOR DO QUE O FINAL, COMEÇOU NO MESMO DIA,
            {                            // ENTÃO, É SÓ DESCOBRIR A DIFERENÇA ENTRE O INICIO E FINAL
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24  - horaInicial + horaFinal;
            }

            Console.WriteLine("O jogo durou " + duracao + "hora(s)");
            */

            /*
            //1048
            //Aumento de salário

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double percentual;
            if (salario <= 400.0)
            {
                percentual = 15.0;
            }
            else if (salario <= 800.0)
            {
                percentual = 12.0;
            }
            else if (salario <= 1200.0)
            {
                percentual = 10.0;
            }
            else if (salario <= 2000.0)
            {
                percentual = 7.0;
            }
            else
            {
                percentual = 4.0;
            }

            double reajuste = salario * percentual / 100.0;
            double novoSalario = salario + reajuste;

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual.ToString("F0", CultureInfo.InvariantCulture) + " %");
            */

            /*
            // 1037 URI
            Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

            O símbolo ( representa "maior que". Por exemplo:
            [0,25]  indica valores entre 0 e 25.0000, inclusive eles.
            (25,50] indica valores maiores que 25 Ex: 25.00001 até o valor 50.0000000

            Entrada
            O arquivo de entrada contém um número com ponto flutuante qualquer.

            Saída
            A saída deve ser uma mensagem conforme exemplo abaixo.
            

            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero < 0.0 || numero > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (numero <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }

            */

            /*
            // 1040 URI FLOAT
            float mediaFinal, notaExame;

            string[] values = Console.ReadLine().Split(' ');
            float N1 = float.Parse(values[0], CultureInfo.InvariantCulture);
            float N2 = float.Parse(values[1], CultureInfo.InvariantCulture);
            float N3 = float.Parse(values[2], CultureInfo.InvariantCulture);
            float N4 = float.Parse(values[3], CultureInfo.InvariantCulture);

            float media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10; // MEDIA PONDERADA

            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine("Média: " + media);

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                mediaFinal = (media + notaExame) / 2;
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            */

            /*
            // 1045 URI
            Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados. A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:

            se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
            se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
            se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
            se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
            se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
            se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES
            Entrada
            A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C (0 < C).

            Saída
            Imprima todas as classificações do triângulo especificado na entrada.

            string[] valores = Console.ReadLine().Split(' ');
            double n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double A, B, C;
            if (n1 > n2 && n1 > n3)
            {
                A = n1;
                if (n2 > n3)
                {
                    B = n2;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n2;
                }
            }
            else if (n2 > n3)
            {
                A = n2;
                if (n1 > n3)
                {
                    B = n1;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n1;
                }
            }
            else
            {
                A = n3;
                if (n1 > n2)
                {
                    B = n1;
                    C = n2;
                }
                else
                {
                    B = n2;
                    C = n1;
                }
            }

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                // primeiro vamos testas as tres possibilidades em relacao a angulos
                if (A * A == B * B + C * C)
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (A * A > B * B + C * C)
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                // agora vamos testar se pode ser equilatero ou isosceles
                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
            */
            // 1047 URI

            // 1049 URI

            // 1051 URI

            // suplementares:  - 1042, 1043, 1050, 1052, 1060, 1064, 1065, 1066, 1070

            Console.ReadLine();
        }
    }
}



