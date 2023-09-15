# Teste de Performance 3
## Exercício #2
Implemente um programa que realize o cadastro de veículo com base em três opções: 1 - carro, 2 - ônibus ou 3 - caminhão. Ao fim do programa, exiba todos os dados do veículo escolhido.

### Requisitos:

1. Para o cadastro, obtenha as informações de assento, placa, ano, marca e modelo do veículo;
2. Para o número de assentos, considere o mínimo e máximo de 2 e 5 para o carro, 10 e 44 para o ônibus, e 2 e 5 para o caminhão;
3. Para o caminhão, considere a informação do número de eixos no seu cadastro, desde que o número mínimo e máximo de eixos seja entre 2 e 10;
4. Exiba todos os dados do veículo cadastrado.

### Requisitos técnicos:

1. Defina uma classe base como abstrata para representar o veículo. Defina um construtor parametrizado;
2. Crie classes usando o recurso de herança para representar os três tipos de veículos herdando da classe base (item anterior);
3. Instancie no programa principal a criação de um carro, de um ônibus e de um caminhão (informe dados fictícios);
4. Sobrescreva o método ToString da classe Object para exibir os dados do veículo;
5. Utilize a classe Console apenas no programa principal;