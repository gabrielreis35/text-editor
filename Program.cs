using System;

namespace textEditor {
    class Program {
        static string ReadFile(){
            // Inicializando o dicionário com as palavras padrões;
            return("0");
        }
        string AddWord(string newWord){
            // Adicionando palavra ao dicionário;
            return ("0");
        }

        static void Main(string[] args){
            // Iniciando as variáveis globais;
            bool verify_todo = false;
            int todo = 0;
            string newWord;
            //string[] dictionary;

            StreamReader reader = new StreamReader("br-dictionary.txt");
            string data = reader.ReadToEnd();
            string[] words = data.Split("\n");
            // dictionary = ReadFile();

            // Iniciando o Programa;
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Adicionar nova palavra.");
            Console.WriteLine("2 - Verificar texto.");
            todo = Convert.ToInt32(Console.ReadLine());
            
            do{    
                if (todo == 1){
                    // Executar a função de adicionar nova palavra no dicionário;
                    verify_todo = true;
                    Console.WriteLine("Qual palavra deseja adicionar? ");
                    newWord = Console.ReadLine();
                    Console.WriteLine("Palavra adicionada - " + newWord);
                }
                else if (todo == 2){
                    // Executar a função de verificar o texto;
                    verify_todo = true;
                }
                else {
                    // Resposta não compreendida;
                    verify_todo = false;
                    Console.WriteLine("Resposta não válida, por favor informar novamente!");
                    Console.WriteLine("1 - Adicionar nova palavra.");
                    Console.WriteLine("2 - Verificar texto.");
                    todo = Convert.ToInt32(Console.ReadLine());
                }
            } while (verify_todo == false);
        }
    }
}


// use link -> ".contains" = "contem tal palavra?"
// rejecs

// fazer o texto da var e o split do dicionário (array) -> texto.contains(dicionário.split())