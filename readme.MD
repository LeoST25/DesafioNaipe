# Desafio

Nesse desafio, você deverá criar um programa que permita ao usuário escolher o valor e o naipe de uma carta de baralho, e exibir a carta escolhida.

Para isso, será necessário criar uma classe chamada `Carta`, que possua dois atributos: `naipe` e `valor`. Os valores de `naipe` e `valor` devem ser definidos como enumerações, para facilitar a escolha do usuário.

## Enumerações

Os valores do enum `Valor` são:
- Ás = 1
- Valete = 2
- Dama = 3
- Rei = 4

Já os valores do enum `Naipe` são:
- Paus = 0
- Ouros = 1
- Copas = 2
- Espadas = 3

## Requisitos

- Utilizar a classe `Carta` que possui dois atributos: `naipe` e `valor`, ambos são enums.
- Utilizar `switch case` para tratar exceções ao escolher o naipe e o valor da carta.
- O programa deve permitir que o usuário escolha o naipe e o valor da carta.
- O programa deve exibir a carta escolhida pelo usuário.

## Entrada

A entrada deve receber duas informações, referentes ao valor e naipe, conforme exemplo abaixo:

- **valor**: Enum - representando o valor da carta
- **naipe**: Enum - representando o naipe da carta

### Exemplo de Entrada
- 3
- 2


## Saída

O código deverá retornar uma mensagem (string) informando qual o valor da carta e seu naipe, após receber como entrada os Enums valor e naipe. Veja as entradas recebidas abaixo:

### Exemplo de Saída
- Carta escolhida: Dama de Copas


## Exemplos

A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

| Entrada | Saída                       |
|---------|-----------------------------|
| 3       | Carta escolhida: Dama de Copas |
| 2       | Carta escolhida: Valete de Copas |