# LogicaCsharp2

RESOLUÇÃO DOS EXERCICIOS DO CURSO: https://github.com/acenelio/curso-logica-de-programacao-csharp

2. Estruturas Condicionais - Algumas anotações sobre o curso em lógica de programação em Csharp

- Expressões comparativas

5 > 10 resultado-> Falso

- Operadores comparativos

operadores:
> maior
< menor
>= maior ou igual
<= menor ou igual
== igual
!= diferente

Exemplos
Suponha x igual a 5
x > 0 VERDADEIRO
x == 3 FALSO
10 <= 30 VERDADEIRO
x != 2 VERDADEIRO

- Operadores lógicos

operadores:
&& E
|| OU
! NÃO

Exemplos operador &&
Suponha x igual a 5
x <= 20 && x == 10 RESULTADO FALSO -> Para o operador && para ser verdadeiro, todas as afirmações tem que ser verdadeiras se uma não for, é considerado FALSO.
x > 0 && x != 3 RESULTADO VERDADEIRO -> Pois as duas condições são verdadeiras

Exemplos operador ||
Suponha X igual a 5
x == 10 || x <= 20 RESULTADO VERDADEIRO, POIS NO MINIMO UMA DAS OPERAÇÕES PRECISA SER VERDADEIRO.3

Exemplos operador !
Suponha x igual a 5
!(X == 10) VERDADEIRO POIS X NÃO É IGUAL A 10
!(X >= 2) FALSO POIS X É MAIOR QUE 2

- Estrutura Condicional

Estrutura condicional simples:
IF (<CONDIÇÃO) {
	<COMANDO 1>
	<COMANDO 2>
}

REGRA: V: Executa o bloco de comando F: Pulo o bloco de comando

Estrutura condicional composta:

IF (<CONDIÇÃO) {
	<COMANDO 1>
	<COMANDO 2>
}
else {
	<COMANDO 3>
	<COMANDO 4>
}

Encadeamentoi de estrutura condicional: (ESSA ESTRUTURA É CONSIDERADA QUE TEM UM COMANDO APENAS)

IF (<CONDIÇÃO) {
	<COMANDO 1>
	<COMANDO 2>
}
else {
	if ( condição ) {
	<COMANDO 3>
	<COMANDO 4>
	}
	else {
	<COMANDO 5>
	<COMANDO 6>
}

OUTRA FORMA RESUMIDA QUE DA PRA FAZER SE FOR APENAS UMA ESTRUTURA COMO ESSA ANTERIOR:

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

SINTAXE OPCIONAL:
OPERADORES DE ATRIBUIÇÃO CUMULATIVA

a += b; -> a = a + b;
a -= b; -> a = a - b;
a *= b; -> a = a * b;
a /= b; -> a = a / b;
a %= b; -> a = a % b;

Estrutura SWITCH-CASE
