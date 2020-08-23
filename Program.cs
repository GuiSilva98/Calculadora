using System;
using System.Globalization;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ******************************** ");
            Console.WriteLine(" * Calculadora Inteligente v1.0 * ");
            Console.WriteLine(" ******************************** ");

            System.Console.WriteLine("");
            System.Console.WriteLine(" Digite qual a opção desejada: ");
            System.Console.WriteLine(" 1 - Somar números");
            System.Console.WriteLine(" 2 - Subtrair números");
            System.Console.WriteLine(" 3 - Multiplicar números");
            System.Console.WriteLine(" 4 - Dividir números");
            System.Console.WriteLine(" 5 - Resolver expressões");
            System.Console.WriteLine(" 6 - Obter média");
            System.Console.WriteLine(" 7 - Sair");

            int opcao = int.Parse(Console.ReadLine());

            if (opcao < 1 || opcao > 7) {
                Console.Clear();
                System.Console.WriteLine(" ******************************* ");
                System.Console.WriteLine(" ******* Opção Inválida ******** ");
                System.Console.WriteLine(" ******************************* ");
                return;
            }

            else if (opcao == 1){
                Console.Clear();
                System.Console.WriteLine(" Digite os números que queira somar, dividindo-os por + : ");
                string[] somaNumeros; // Cria um Array com tamanho variável
                somaNumeros = Console.ReadLine().Split('+'); // Salva os números em um Array
                double resultadoSoma = 0; // Definida a variável responsável por salvar o resultado da operação

                for (int i = 0; i < somaNumeros.Length; i++){ // Percorre o array separando os numeros e somando-o com o resultado anterior
                    double numeroSeparado = double.Parse(somaNumeros[i]); // Converte o número de String para Double e salva na variável
                    resultadoSoma = resultadoSoma + numeroSeparado;
                }
                System.Console.WriteLine(" O resultado da sua soma é: " + resultadoSoma);
            }
            else if(opcao == 2){
                Console.Clear();
                System.Console.WriteLine(" Digite os números que queira subtarir, dividindo-os por - : ");

                string[] subtraiNumeros; // Cria um array com tamanho variável
                subtraiNumeros = Console.ReadLine().Split('-'); // Salva os números em um Array
                double resultadoSubtracao = 0; // Definida a variável responsável por salvar o resultado da operação

                for(int i = 0; i < subtraiNumeros.Length; i++){ // Função que percorre a matriz e separa os números
                    double numeroSeparado = double.Parse(subtraiNumeros[i]); // Converte o número de String para Double e salva na variável
                    
                    if (resultadoSubtracao == 0){ // Verifica se já foi iniciada a subtração
                        resultadoSubtracao = numeroSeparado;
                    }

                    else{
                    resultadoSubtracao = resultadoSubtracao - numeroSeparado;
                    }
                }
                System.Console.WriteLine(" O resultado de sua subtração é: " + resultadoSubtracao);
            }
            else if(opcao == 3){
                Console.Clear();
                System.Console.WriteLine(" Digite os números que queira multiplicar, dividindo-os por * : ");
                string[] multiplicaNumeros;
                multiplicaNumeros = Console.ReadLine().Split('*');
                double resultadoMultip = 0;

                for(int i = 0; i < multiplicaNumeros.Length; i++){ 
                    double numeroSeparado = double.Parse(multiplicaNumeros[i]);
                    
                    if (resultadoMultip == 0){
                        resultadoMultip = numeroSeparado;
                    }

                    else{
                    resultadoMultip = resultadoMultip * numeroSeparado;
                    }
                }
                System.Console.WriteLine(" O resultado de sua multiplicação é: " + resultadoMultip);
            }
            else if(opcao == 4){
                Console.Clear();
                System.Console.WriteLine(" Digite os números que queira dividir, dividindo-os por / : ");
                string[] divideNumeros;
                divideNumeros = Console.ReadLine().Split('/');
                double resultadoDivisao = 0;

                for(int i = 0; i < divideNumeros.Length; i++){ 
                    double numeroSeparado = double.Parse(divideNumeros[i]);
                    
                    if (resultadoDivisao == 0){
                        resultadoDivisao = numeroSeparado;
                    }

                    else{
                    resultadoDivisao = resultadoDivisao / numeroSeparado;
                    }
                }
                System.Console.WriteLine(" O resultado de sua multiplicação é: " + resultadoDivisao);
            }
            else if(opcao == 5){
                Console.Clear();
                char[] operadores = {'+', '-', '*', '/', '(', ')'};               
                System.Console.WriteLine("Digite a expressão que você deseja resolver: ");
                double expressao = Convert.ToDouble(Console.ReadLine());

                System.Console.WriteLine(expressao);
                System.Console.WriteLine(operadores);
            }
            else if (opcao == 6){
                Console.Clear();
                System.Console.WriteLine("Digite os números para realizar a média: ");
                System.Console.WriteLine("DICA: Separe-os com espaço entre eles ;)");
                string[] mediaNumeros;
                mediaNumeros = Console.ReadLine().Split(' ');
                double somaMedia = 0; // Soma os números informados pelo user
                double resultadoMedia = 0;
                
                for(int i=0; i < mediaNumeros.Length; i++){
                    double numeroSeparado = double.Parse(mediaNumeros[i]);
                    somaMedia = somaMedia + numeroSeparado;
                }
                resultadoMedia = somaMedia / mediaNumeros.Length;
                System.Console.WriteLine("A média dos números é de: "  + resultadoMedia);
            }
            
            System.Console.WriteLine("Pressione qualquer tecla para finalizar...");
            Console.ReadKey();
            System.Console.WriteLine();
        }
    }
}
