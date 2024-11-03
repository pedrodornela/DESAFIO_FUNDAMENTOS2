# DIO - Trilha .NET - Fundamentos 
## Desafio de Projeto: Sistema de Hospedagem de um Hotel
### Contexto
- Eu foi contratado para construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel. Foi realizada a criação da classes **Pessoa**, que representa o **hóspede**, a classe **Suíte**, e a classe **Reserva**, que fará um relacionamento entre ambos.
- O meu programa cálcula corretamente os valores dos métodos da classe **Reserva**, que traz a **quantidade** de **hóspedes** e o **valor da diária**, concedendo um desconto de **10%** para caso a reserva seja para um período maior ou igual a 10 dias.

### Regras e validações
- 1 - Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.
- 2 - O método *ObterQuantidadeHospedes* da classe **Reserva** deverá retornar a *quantidade total* de hóspedes, enquanto que o método *CalcularValorDiaria* deverá retornar o valor da diária (*Dias reservados x valor da diária*).
- 3 - Caso seja feita uma reserva *igual ou maior* que *10 dias*, deverá ser concedido um desconto de *10% no valor da diária*.


### Solução
- Classes "Pessoa", "Suite" e "Reserva" contruídas de acordo com o diagrama abaixo:
  
![image](https://github.com/user-attachments/assets/3983adc1-20bf-46ea-a4bb-789e41c59f28)

#### Pré-requisitos:
- Lógica de Programação e POO;
- Conhecimentos Básico(C#, .NET, Git, GitHub);
