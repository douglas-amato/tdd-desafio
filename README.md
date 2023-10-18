## Sobre o sistema

O sistema é simples, possui dois projetos, um do **tipo console** e outro do **tipo teste** com xUnit, e tem como objetivo aplicar a técnica de TDD vista no curso da www.dio.me.

## Os projetos

O **projeto console** contém, em Services, uma classe com dois métodos que foram implementados após a execução e conclusão dos testes. A tabela abaixo apresenta a classe com seus métodos e o objetivo de cada método. 

| Classe | Método | Objetivo | 
|--------|--------|----------|
| Matematica | CalcularFatorial | Receber um número inteiro e retornar o fatorial desse número |
| Matematica | VerificarExistenciaTriangulo | Receber as medidas de três segmentos de reta (números inteiros positivos) e verificar se é possível montar um triângulo com elas |

O **projeto de teste** contém uma classe de teste com dois métodos que recebem, cada um, um conjunto de dados para realização dos testes. A tabela abaixo apresenta a classe de teste com seus métodos e o objetivo de cada método. 

| Classe | Método | Objetivo | 
|--------|--------|----------|
| MatematicaTests | DeveInformarUmNumeroInteiroNaoNegativoERetornarSeuFatorial | Receber um conjunto de pares de números inteiros, onde o segundo número é o fatorial do primeiro |
| MatematicaTests | DeveInformarTresMedidasInteirasPositivasERetornarSeEhPossivelFormarTrianguloComElas | Receber um conjunto de medidas de segmentos de reta (números inteiros positivos) e retornar se é possível formar triângulo com elas |
