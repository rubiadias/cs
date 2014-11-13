using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Exercícios
{
    class Program
    {

        //Constantes em C#.
        public const string JANEIRO = "Janeiro";
        public const string FEVEREIRO = "Fevereiro";
        public const string MARCO = "Março";
        public const string ABRIL = "Abril";
        public const string MAIO = "Maio";
        public const string JUNHO = "Junho";
        public const string JULHO = "Julho";
        public const string AGOSTO = "Agosto";
        public const string SETEMBRO = "Setembro";
        public const string OUTUBRO = "Outubro";
        public const string NOVEMBRO = "Novembro";
        public const string DEZEMBRO = "Dezembro";
        public const string ADICAO = "+";
        public const string SUBTRACAO = "-";
        public const string MULTIPLICACAO = "*";
        public const string DIVISAO = "/";

        static void Main(string[] args)
        {
            /* Exercícios de algoritmos estruturados */

            //ExecutarExercicio1();
            //ExecutarExercicio2();
            //ExecutarExercicio3();
            //ExecutarExercicio4();
            //ExecutarExercicio5();
            //ExecutarExercicio6();
            //ExecutarExercicio7();
            //ExecutarExercicio8();
            //ExecutarExercicio9();
            //ExecutarExercicio10();
            //ExecutarExercicio11();
            //ExecutarExercicio12();
            //ExecutarExercicio13();
            ExecutarExercicio14();


            Console.ReadLine(); //faz uma pausa.
        }

        /**
         * 14. Dados três valores A, B e C, em 
         * que A e B são números reais e C é um 
         * caractere, pede-se para imprimir o resultado 
         * da operação de A por B se C for um símbolo 
         * de operador aritmético; caso contrário deve 
         * ser impresso uma mensagem de operador não 
         * definido. Tratar erro de divisão por zero 
         * usando: try{} catch(DivideByZeroException){}.
         **/
        private static void ExecutarExercicio14()
        {
            Console.WriteLine("Informe o valor A:");
            string a = Console.ReadLine();
            Console.WriteLine("Informe o valor B:");
            string b = Console.ReadLine();
            Console.WriteLine("Informe o operador:");
            string operadorDigitado = Console.ReadLine();

                int numeroA = int.Parse(a);
                int numeroB = int.Parse(b);

                if (ADICAO.Equals(operadorDigitado))
                {
                    Console.WriteLine("A adição dos números {0} e {1} é: {2}", numeroA, numeroB, (numeroA + numeroB));
                }
                else if (SUBTRACAO.Equals(operadorDigitado))
                {
                    Console.WriteLine("A subtração dos números {0} e {1} é: {2}", numeroA, numeroB, (numeroA - numeroB));
                }
                else if (MULTIPLICACAO.Equals(operadorDigitado))
                {
                    Console.WriteLine("A multiplicação dos números {0} e {1} é: {2}", numeroA, numeroB, (numeroA * numeroB));
                }
                else if (DIVISAO.Equals(operadorDigitado))
                {
                    try
                    {
                        Console.WriteLine("A divisão dos números {0} e {1} é: {2}", numeroA, numeroB, (numeroA / numeroB));
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Não é permitido a divisão por zero.");
                    }
                }
                else
                {
                    Console.WriteLine("Operador não definido!");
                }
        }

        /**
         * 13. Faça um algoritmo que leia o número 
         * do mês e mostre o mês correspondente. 
         * Valide mês inválido. (usar switch/case). 
         **/
        private static void ExecutarExercicio13()
        {
            Console.WriteLine("Informe número do mês:");
            string s = Console.ReadLine();

            try
            {
                int mes = int.Parse(s);

                if (mes < 1 || mes > 12)
                {
                    throw new Exception("O valor informado é inválido!");
                }

                switch (mes)
                {
                    case 1 :
                        Console.WriteLine(JANEIRO);
                        break;
                    case 2:
                        Console.WriteLine(FEVEREIRO);
                        break;
                    case 3:
                        Console.WriteLine(MARCO);
                        break;
                    case 4:
                        Console.WriteLine(ABRIL);
                        break;
                    case 5:
                        Console.WriteLine(MAIO);
                        break;
                    case 6:
                        Console.WriteLine(JUNHO);
                        break;
                    case 7:
                        Console.WriteLine(JULHO);
                        break;
                    case 8:
                        Console.WriteLine(AGOSTO);
                        break;
                    case 9:
                        Console.WriteLine(SETEMBRO);
                        break;
                    case 10:
                        Console.WriteLine(OUTUBRO);
                        break;
                    case 11:
                        Console.WriteLine(NOVEMBRO);
                        break;
                    case 12:
                        Console.WriteLine(DEZEMBRO);
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /**
         * 12. Escrever um algoritmo que leia três valores 
         * inteiros distintos e os escreva em ordem crescente. 
         * (ver http://pt.wikipedia.org/wiki/Bubble_sort)
         **/
        private static void ExecutarExercicio12()
        {
            Console.WriteLine("Informe o primeiro valor:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Informe o segundo valor:");
            string s2 = Console.ReadLine();
            Console.WriteLine("Informe o terceiro valor:");
            string s3 = Console.ReadLine();

            Console.WriteLine("\n****** LISTA ORDENADA ******");

            int[] vetorDesordenado = new int[3];
            vetorDesordenado[0] = int.Parse(s1);
            vetorDesordenado[1] = int.Parse(s2);
            vetorDesordenado[2] = int.Parse(s3);

            int[] vetorOrdenado = OrdenarPeloMetodoBolha(vetorDesordenado);

            for (int i = 0; i < vetorOrdenado.Length; ++i)
            {
                Console.WriteLine(vetorOrdenado[i]);
            }
           
        }

        private static int[] OrdenarPeloMetodoBolha(int[] vetor) 
        {
            int variavelTemporaria;

            for (int i = vetor.Length - 1; i >= 1; i--)
            {  
                for( int j=0; j < i ; j++) {
                    if (vetor[j] > vetor[j + 1])
                    {
                        variavelTemporaria = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = variavelTemporaria;
                    }
                }
            }
            return vetor;
        }

        /**
         * Faça um algoritmo que leia dois números e 
         * identifique se eles são iguais ou diferentes. 
         * Caso sejam iguais imprima uma mensagem dizendo 
         * que eles são iguais. Caso sejam diferentes, 
         * informe qual número é o maior, e uma 
         * mensagem de que eles são diferentes.
         **/
        private static void ExecutarExercicio11()
        {
            Console.WriteLine("Informe o primeiro número:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Informe o segundo número:");
            string s2 = Console.ReadLine();

            int numero1 = int.Parse(s1);
            int numero2 = int.Parse(s2);

            if (numero1 == numero2)
            {
                Console.WriteLine("Os números são iguais.");
            }
            else
            {
                int maior = numero1 > numero2 ? numero1 : numero2;
                int menor = numero1 < numero2 ? numero1 : numero2;
                Console.WriteLine("Os números são diferentes e o número {0} é maior do que {1}.",maior, menor);
            }
        }


        /**
         * 10. Faça um algoritmo que leia um 
         * número de 1 a 5 e escreva-o por extenso. 
         * Caso o usuário digite um número 
         * que não esteja neste intervalo, 
         * exibir mensagem: número inválido.
         **/
        private static void ExecutarExercicio10()
        {
            Console.WriteLine("Informe um número:");
            string s = Console.ReadLine();

            int numeroDigitado = int.Parse(s);
            string[] nomes = { "um", "dois", "três", "quatro", "cinco" };

            //int[] numeros = new int[5];
            int[] numeros = {1,2,3,4,5};

            bool isNumeroValido = false;
            
            for (int i = 0; i < numeros.Length; i++)
            {
                int valorDaPosicao = numeros[i];

                string nome = nomes[i];
               

                if (numeroDigitado == valorDaPosicao)
                {
                    Console.WriteLine("O número digitado é {0}", nome);
                    isNumeroValido = true;
                }                
            }

            if (!isNumeroValido)
            {
                Console.WriteLine("O número é inválido!");
            }

        }

        /**
         * 9. Faça um algoritmo que leia 
         * "N" números e mostre positivo, negativo 
         * ou zero para cada número.
         **/
        private static void ExecutarExercicio9()
        {
            bool deveContinuarLeitura = true;

            while (deveContinuarLeitura)
            {
                Console.WriteLine("Digite um número ou 'N' para sair:");
                string s = Console.ReadLine();

                if (s == "N")
                {
                    deveContinuarLeitura = false;
                }
                else
                {
                    int numero = int.Parse(s);

                    if (numero > 0)
                    {
                        Console.WriteLine("O número é positivo.");
                    }
                    else if (numero < 0)
                    {
                        Console.WriteLine("O número é negativo.");
                    }
                    else
                    {
                        Console.WriteLine("O número é zero.");
                    }
                }

            }
        }


        /**
         * 8. Faça um algoritmo que leia um número 
         * e mostre uma mensagem caso este número 
         * seja maior que 50, menor que 10 ou igual a 20.
         **/
        static void ExecutarExercicio8()
        {
            Console.WriteLine("Informe um número");
            string s = Console.ReadLine();

            int numero = int.Parse(s);

            if (numero > 50)
            {
                Console.WriteLine("O número {0} é maior do que 50.", numero);
            }
            else if (numero < 10)
            {
                Console.WriteLine("O número {0} é menor do que 10.", numero);
            }
            else if (numero == 20)
            {
                Console.WriteLine("O número {0} é igual a 20.", numero);
            }
            else
            {
                Console.WriteLine("O número não está na faixa desejada.");
            }


        }



        /**
         * 7. Faça um algoritmo que leia um 
         * número e diga se este número está no 
         * intervalo entre 100 e 200.
         **/
        private static void ExecutarExercicio7()
        {
            Console.WriteLine("Informe o número:");
            string s1 = Console.ReadLine();

            int numero = int.Parse(s1);

            if (numero >= 100 && numero <= 200)
            {
                Console.WriteLine("O numero {0} está no intervalo de 100 a 200.", numero);
            }
            else
            {
                Console.WriteLine("O numero {0} está fora do intervalo de 100 a 200.", numero);
            }
        }

        /**
         * 6. Leia uma temperatura em graus Celsius e 
         * apresente-a convertida em graus Fahrenheit. 
         * A fórmula de conversão é:
         * F=(9*C+160) / 5, 
         * sendo F a temperatura em Fahrenheit e 
         * C a temperatura em Celsius.
         **/
        private static void ExecutarExercicio6()
        {
            Console.WriteLine("Informe a temperatura em graus Celsius:");
            string sTemp = Console.ReadLine();
            double grausCelsius = double.Parse(sTemp);
            double grausFahrenheit = (9 * grausCelsius + 160) / 5;
            Console.WriteLine("A temperatura em Fahrenheit é {0}.", grausFahrenheit);
        }

        /**
         * 5. Leia os valores para as variáveis A e B 
         * e efetue as trocas dos valores de forma que 
         * a variável A passe a possuir o valor da variável B 
         * e a variável B passe a possuir o valor da 
         * variável A. Apresentar os valores trocados.
         **/
        private static void ExecutarExercicio5()
        {
            Console.WriteLine("Informe o valor da primeira variável:");
            string a = Console.ReadLine();
            Console.WriteLine("Informe o valor da segunda variável:");
            string b = Console.ReadLine();

            string temp = a;
            a = b;
            b = temp;

            Console.WriteLine("A variável A valia {0} e agora vale {1}.", b, a);
            Console.WriteLine("A variável B valia {0} e agora vale {1}.", a, b);
        }

        /**
         * 4. Faça um algoritmo que leia dois números 
         * e ao final mostre a soma, subtração, multiplicação 
         * e a divisão dos números lidos.
         * */
        private static void ExecutarExercicio4()
        {
            Console.WriteLine("Informe o primeiro número:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Informe o segundo número:");
            string s2 = Console.ReadLine();

            double valor1 = double.Parse(s1);
            double valor2 = double.Parse(s2);

            Console.Clear();

            var resultado = valor1 + valor2;
            Console.WriteLine("Soma: {0} + {1} = {2}", valor1, valor2, resultado);

            resultado = valor1 - valor2;
            Console.WriteLine("Subtração: {0} - {1} = {2}", valor1, valor2, resultado);

            resultado = valor1 * valor2;
            Console.WriteLine("Multiplicação: {0} * {1} = {2}", valor1, valor2, resultado);

            resultado = valor1 / valor2;
            Console.WriteLine("Divisão: {0} / {1} = {2}", valor1, valor2, resultado);
            
        }

        /**
         * 3. Escreva um algoritmo que leia
         * dois valores inteiros distintos e 
         * informe qual deles é o maior.
         **/
        private static void ExecutarExercicio3()
        {
            Console.WriteLine("Informe o primeiro número:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Informe o segundo número:");
            string s2 = Console.ReadLine();

            double valor1 = double.Parse(s1);
            double valor2 = double.Parse(s2);

            Console.Clear();

            if (valor1 > valor2)
            {
                Console.WriteLine("O primeiro valor {0} é maior do que {1}!", valor1, valor2);
            }
            else
            {
                Console.WriteLine("O segundo valor {0} é maior do que {1}!", valor2, valor1);
            }
        }

        /**
         * 2. Faça um algoritmo que  
         * declarado dois números, exiba 
         * o resultado da sua soma destes
         * dois números.
         **/
        private static void ExecutarExercicio2()
        {
            int numero1 = 10;
            int numero2 = 15;
            int resultado = numero1 + numero2;

            Console.WriteLine("A soma dos números é: {0}", resultado);
        }


        /**
         * 1. Faça um algoritmo que declarado 
         * um número, mostre uma mensagem caso 
         * este número seja maior que 10 e outra
         * case seja menor ou igual a 10.
         **/
        private static void ExecutarExercicio1()
        {
            int numero = 15;

            if (numero > 10)
            {
                Console.WriteLine("O número {0} é maior do que 10!", numero);
            }
            else
            {
                Console.WriteLine("O número {0} é menor ou igual a 10!", numero);
            }
        }
    }
}
