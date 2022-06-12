using System;

namespace textEditor {
    class Program {
        static void Main(string[] args){
            bool verify_todo = False;
            int todo = 0;
        
            StreamReader reader = new StreamReader("br-dictionary.txt");
            string data = reader.ReadToEnd();
            string[] words = data.Split("\n");

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Adicionar nova palavra.");
            Console.WriteLine("2 - Verificar texto.");
            Console.ReadLine(todo);
            
            do{    
                if (todo == 1){
                    // Executar a função de adicionar nova palavra no dicionário;
                    verify_todo = True;
                }
                else if (todo == 2){
                    // Executar a função de verificar o texto;
                    verify_todo = True;
                }
                else {
                    // Resposta não compreendida;
                    verify_todo = False;
                    Console.WriteLine("Resposta não válida, por favor informar novamente!");
                    Console.WriteLine("1 - Adicionar nova palavra.");
                    Console.WriteLine("2 - Verificar texto.");
                    Console.ReadLine(todo);
                }
            } while (verify_todo == False);
        }
    }
}


// use link -> ".contains" = "contem tal palavra?"
// rejecs

// fazer o texto da var e o split do dicionário (array) -> texto.contains(dicionário.split())