# text-editor

Funcionamento do programa:

    1 - O projeto começa com a leitura de um arquivo .txt com uma base de palavras já pré definidas, adicionando numa tabela Hash.

    2 - Assim que terminar de fazer a leitura, o programa vai perguntar se o usuário quer adicionar uma palavra nova ou verificar o texto.

    3 - O programa vai pegar um arquivo .txt onde tem o texto escrito, vai colocar em uma variável, quebrar o texto por palavras e verificar 1 por 1.

    4 - Assim que terminar de verificar ele vai entregar um novo txt com o texto original e com as palavras não existentes no "banco de dados", ou seja, na tabela Hash.

Estrutura:

    1 - Para salvar as palavras e fazer a verificação será salvo uma lista de tabelas Hash, contendo 27 tabelas, cada uma representando 1 letra do alfabeto. A palavra vai ser salva dentro da tabela conforme a tua primeira letra, assim podemos fazer uma divisão melhor para a verificação de cada palavra. O modo de tratamento de colisão foi feito por modo estruturado, ou seja, apontando caminhos dentro de cada chave, assim podendo ter mais de 1 variação dentro da mesma posição, e pensando nisso, o modo de divisão da tabela será por número de letras por palavra, deixando mais rápido de encontrar a palavra verificada.

    2 - O projeto foi divido em funções para a manipulação e a limpeza do código, para ficar de fácil entendimento.