# Validador de Cartão de Crédito

Este programa em C# valida números de cartões de crédito e identifica a bandeira do cartão com base no número fornecido.

## Requisitos

- .NET 8
- C# 12.0

## Como Usar

1. Clone o repositório ou copie o código para o seu ambiente de desenvolvimento.
2. Compile e execute o programa.
3. Digite o número do cartão de crédito quando solicitado.

## Explicação

### Validação do Algoritmo de Luhn

A função `IsValidCardNumber` implementa o algoritmo de Luhn para verificar se o número do cartão é válido. O algoritmo de Luhn é um método simples de verificação de soma que é usado para validar uma variedade de números de identificação, como números de cartões de crédito.

### Identificação da Bandeira

A função `GetCardBrand` usa expressões regulares para identificar a bandeira do cartão com base no número fornecido. As bandeiras suportadas incluem:

- Visa
- MasterCard
- American Express
- Diners Club
- Discover
- JCB
- EnRoute
- Voyager
- HiperCard
- Aura

### Fluxo do Programa

1. O programa solicita ao usuário que digite o número do cartão de crédito.
2. O número do cartão é validado usando o algoritmo de Luhn.
3. Se o número do cartão for válido, a bandeira do cartão é identificada e exibida.
4. Se o número do cartão for inválido, uma mensagem de erro é exibida.

## Licença

Este projeto está licenciado sob a licença MIT.
