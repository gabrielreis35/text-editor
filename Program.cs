using System;

namespace textEditor {
    class Program {
        static void Main(string[] args){
            int todo = 0;
        
            StreamReader reader = new StreamReader("br-dictionary.txt");
            string data = reader.ReadToEnd();
            string[] words = data.Split("\n");

            Console.WriteLine(words[]);

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Adicionar nova palavra.");
            Console.WriteLine("2 - Verificar texto.");
            Console.ReadLine(todo);

            if (todo == 1){
                // Executar a função de adicionar nova palavra no dicionário;
            }
            else if (todo == 2){
                // Executar a função de verificar o texto;
            }
        }
    }
}