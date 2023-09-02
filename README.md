# Cinema (IoC)

## Descrição
O Projeto Cinema tem como objetivo modelar e gerenciar filmes, salas e sessões de um cinema.

## Estrutura

### Classe Filme
- **Propriedades**:
  - `Titulo`: Nome do filme.
  - `Ano`: Ano de lançamento do filme.
  - `Duracao`: Duração total do filme.

### Classe Sala
- **Propriedades**:
  - `quantidadeCadeiras`: Total de cadeiras disponíveis na sala.

### Classe Sessão
- **Propriedades**:
  - `private Filme`: Referência ao filme que será exibido na sessão.
  - `private Sala`: Referência à sala onde o filme será exibido.
  - `private DataHora`: Data e hora em que a sessão ocorrerá.
  
- **Construtor**:
  - Recebe a data e a sala (Demonstrando injeção de dependência via construtor).

- **Métodos**:
  - Método para definir qual filme será exibido na sessão.

## Utilização

1. Crie instâncias para filmes e salas.
2. Crie uma sessão especificando a data, a sala e depois associe um filme a ela.
