using words;


Console.WriteLine("Seja bem vindo!");
Console.WriteLine("Estamos atualizando o banco de dados com as palavras já conhecidas. Aguarde um momento!");

Words.ReadFile();

Console.WriteLine("O que deseja fazer?");
Console.WriteLine("1 - Adicionar nova palavra.");
Console.WriteLine("2 - Verificar texto.");


//     // Iniciando o Programa;
//     todo = Convert.ToInt32(Console.ReadLine());
    
//     do{    
//         if (todo == 1){
//             // Executar a função de adicionar nova palavra no dicionário;
//             verify_todo = true;
//             Console.WriteLine("Qual palavra deseja adicionar? ");
//             newWord = Console.ReadLine();
//         }
//         else if (todo == 2){
//             // Executar a função de verificar o texto;
//             verify_todo = true;
//         }
//         else {
//             // Resposta não compreendida;
//             verify_todo = false;
//             Console.WriteLine("Resposta não válida, por favor informar novamente!");
//             Console.WriteLine("1 - Adicionar nova palavra.");
//             Console.WriteLine("2 - Verificar texto.");
//             todo = Convert.ToInt32(Console.ReadLine());
//         }
//     } while (verify_todo == false);
// }

// // use link -> ".contains" = "contem tal palavra?"
// // rejecs

// // fazer o texto da var e o split do dicionário (array) -> texto.contains(dicionário.split())