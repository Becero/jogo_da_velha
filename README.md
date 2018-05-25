# Jogo da velha em C# - Agente reativo simples

## Trabalho da Disciplina de Inteligência Artificial
## Ciência da Computação - UniBH - 2018

## Percepções Jogo da Velha

Ao todo são **25 percepções** básicas no jogo, das quais **24** são decisões do computador **APENAS** para defesa.

As **24 percepções são de defesa**, ou seja, todas as possibilidades de vitória do humano. Toda vez que o humano conseguir deixar 2 casas selecionadas (na mesma linha, na mesma coluna ou na mesma diagonal) o computador precisa defender a terceira casa impedindo que o humano vença a partida.

A **25ª percepção** é quando a posição central do tabuleiro estiver livre e for a vez do computador jogar, ele seleciona essa posição central.

-------------

### Diagonais (6 percepções)

-------------

Na classe **GameLogic**, dentro da função **EnemyMovement** no primeiro bloco de **IFs**.

Estes **ifs** sao responsáveis por verificar **TODAS** as possibilidades de vitória do humano nas duas diagonais.

Por exemplo, cada diagonal tem 3 casas, e dentre essas 3 casas existem 3 combinações possíveis do humano marcar 2 casas e estar prestes a vencer.
Exemplo da diagonal 1, a outra é a mesma coisa porém invertida

	 x |   |  
	___|___|___
	   | x |   
	___|___|___
	   |   | 
	   |   |

	 x |   |  
	___|___|___
	   |   |   
	___|___|___
	   |   | x
	   |   |

 	   |   |  
	___|___|___
	   | x |   
	___|___|___
	   |   | x
	   |   |

Dessa forma, quando o humano **estiver em um desses 3 estágios** o computador irá **PERCEBER** essa situação e **TOMARÁ** uma atitude, que é defender o jogo selecionando a casa que estiver vazia bloqueando assim a vitória do humano.

Com isso, analisando as duas diagonais, temos **6 percepções** (3 percepções da diagonal 1 e 3 percepções da diagonal 2)


-------------

### Linhas (9 percepções)

-------------

Na classe **GameLogic**, dentro da função **EnemyMovement** logo após a verificação de diagonais.

Verifica todas as linhas do tabuleiro (3 linhas) para saber se o humano está para vencer (**2 casas** na mesma linha com o símbolo do humano).

Assim como nas diagonais, cada linha possui **3 possibilidades** de vitória, como são **3 linhas com 3 possibilidades** em cada, temos **9 PERCEPÇÕES** do agente para as linhas do tabuleiro (3 em cada).

Exemplo das combinações para as linhas, o mesmo padrão se repete para as outras 2 linhas.

	 x | x |  
	___|___|___
	   |   |   
	___|___|___
	   |   | 
	   |   |

	 x |   | x
	___|___|___
	   |   |   
	___|___|___
	   |   | 
	   |   |

	   | x | x
	___|___|___
	   |   |   
	___|___|___
	   |   | 
	   |   |

O bloco **FOR** é responsável por percorrer cada uma das linhas e verificar se tem 2 posições marcadas pelo humano na linha analisada;
Dentro do **IF** é verificado se a posição atual esta vazia, **se estiver** armazena esta posição caso precise ser utilizada posteriormente;
Caso a posição **esteja ocupada**, após é verificado se esta posição **está ocupada pelo humano ou pelo computador**, se estiver ocupada **pelo humano** será incrementado um contador que serve para verificar se o humano possui **2 jogadas na mesma linha**;

Ao sair do **FOR interno** (terminou de ler uma linha), no **IF** seguinte são verificadas **3 situações**, 1 - Se a contagem de jogadas do humano **é maior que 2** (selecionou **2 casas na mesma linha**), && 2 - Se a posição livre adicionada anteriormente está **realmente livre** (se é possível o **computador defender**), && 3 - Se a variável que armazena a posição livre tem **algum valor** (se tiver algum valor nessa variável de posição livre, então **é possível o computador jogar nessa posição**).

Caso seja **tudo verdadeiro**, o computador efetua sua jogada.

Se for **falso**, as variáveis de controle serão **reinicializadas**, e o **FOR** continua a execução para analisar as próximas linhas do tebuleiro;


-------------

### Colunas (9 percepções)

-------------

Na classe **GameLogic**, dentro da função **EnemyMovement** logo após a verificação de linhas.

Verifica **todas as colunas** do tabuleiro (3 colunas) para saber se o humano está para vencer (2 casas na mesma colunas com o simbolo do humano).

Assim como nas linhas, cada coluna possui **3 possibilidades de vitória**, como são **3 colunas** com **3 possibilidades** em cada, temos **9 PERCEPÇÕES** do agente para as colunas do tabuleiro (3 em cada).

Exemplo das combinações para as colunas, o mesmo padrão se repete para as outras 2 colunas.

	 x |   |  
	___|___|___
	 x |   |   
	___|___|___
	   |   | 
	   |   |

	 x |   |  
	___|___|___
	   |   |   
	___|___|___
	 x |   | 
	   |   |

	   |   |  
	___|___|___
	 x |   |   
	___|___|___
	 x |   | 
	   |   |

O funcionamento do **FOR** e dos **IFs** internos são exatamente iguais aos de análise de linha, porém dessa vez serão analisadas todas as **COLUNAS**.

-------------

### Posição central (1 percepção)

-------------

Após passar por toda estrutura de código acima é verificado se a posição **central está vazia** (após percorrer o tabuleiro inteiro procurando alguma posição para defender, **se não precisou jogar em nenhum lugar** para defender, significa que o **humano ainda não está prestes a vencer**, quando acontece alguma jogada é também acionado o **return**, dessa forma sai da função de **EnemyMovement** e não chega nessa parte), com a posição central estando vazia, o computador **marca essa posição**.

	   |   |  
	___|___|___
	   | x |   
	___|___|___
	   |   | 
	   |   |

Caso essa posição central **já esteja selecionada**, o computador joga **aleatoriamente**.

-------------

## Resultado das percepções

-------------

06 - Diagonais
09 - Linhas
09 - Colunas
01 - Posição central

**25 - Total**
