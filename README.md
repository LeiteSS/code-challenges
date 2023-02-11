# Desenvolvedor SP

Para rodar os codigos, use o comando:

`dotnet run`

## Desafio 1 

(1) Observe o trecho de código abaixo:

```
int INDICE = 13, SOMA = 0, K = 0;

enquanto K < INDICE faça
{
K = K + 1;
SOMA = SOMA + K;
}

imprimir(SOMA);
```

Ao final do processamento, qual será o valor da variável SOMA? **A variável SOMA irá valer 91 ao final
laço enquanto.**

### Teste de Mesa

```
PASSO UM: K (0) < INDICE (13) = true | K = 1 | Soma = 1 | 
PASSO DOIS: K (1) < INDICE (13) = true | K = 2 | Soma = 3 | 
PASSO TRÊS: K (2) < INDICE (13) = true | K = 3 | Soma = 6 | 
PASSO QUATRO: K (3) < INDICE (13) = true | K = 4 | Soma = 10 | 
PASSO CINCO: K (4) < INDICE (13) = true | K = 5 | Soma = 15 | 
PASSO SEIS: K (5) < INDICE (13) = true | K = 6 | Soma = 21 | 
PASSO SETE: K (6) < INDICE (13) = true | K = 7 | Soma = 28 | 
PASSO OITO: K (7) < INDICE = true | K = 8 | SOMA = 36 | 
PASSO NOVE: K (8) < INDICE = true | K = 9 | SOMA = 45 |
PASSO DEZ: K(9) < INDICE = true | K = 10 | SOMA = 55 | 
PASSO ONZE: K (10) < INDICE = true | K = 11 | SOMA = 66 | 
PASSO DOZE: K (11 < INDICE) = true | K = 12 | SOMA = 78 | 
PASSO TREZE: K (12) < INDICE = true | K = 13 | SOMA = 91 | 
PASSO CATORZE: K (13) < INDICE = false
```

## Desafio 2
(2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

IMPORTANTE:
Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

## Desafio 3
(3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
• O menor valor de faturamento ocorrido em um dia do mês;
• O maior valor de faturamento ocorrido em um dia do mês;
• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

IMPORTANTE:
a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;
