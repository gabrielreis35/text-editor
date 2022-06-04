using System;

namespace textEditor {
    class Program {
        static void Main(string[] args){
            StreamReader reader = new StreamReader("br-dictionary.txt");
            string data = reader.ReadToEnd();
            string[] words = data.Split("\n");

            Console.WriteLine(words[]);
        }
    }
}