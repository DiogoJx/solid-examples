Princípio Aberto-Fechado

O Princípio Aberto-Fechado diz que uma classe ou componente deve estar aberta para extensão, mas fechada para modificação. Isso significa que uma classe deve permitir a adição de novos comportamentos ou funcionalidades sem precisar alterar seu código existente.

Situação Problema:

Imagine que você tem uma classe para processar pagamentos com cartão de crédito. Esta classe realiza a validação dos dados do cartão, como número, código de segurança e data de validade, e processa o pagamento.

Agora, digamos que um novo requisito surge: o sistema precisa começar a aceitar pagamentos com boletos. Os boletos têm um formato e requisitos de validação completamente diferentes dos cartões de crédito. Se a classe de processamento de pagamentos precisa ser modificada para lidar com boletos, isso pode resultar em código complexo e difícil de manter. O código da classe pode se tornar cheio de condicionais (ifs) para tratar diferentes tipos de pagamento, o que pode tornar a manutenção e o teste mais difíceis.

Por exemplo, se a classe de processamento de pagamentos tiver que testar o tipo de pagamento e modificar seu comportamento interno, como adicionar novas verificações para boletos ou para pagamentos com pontos de fidelidade, você está violando o Princípio Aberto-Fechado. O código se torna frágil e propenso a erros, pois qualquer alteração no tipo de pagamento exigirá mudanças na classe existente.

Solução:

Para aderir ao Princípio Aberto-Fechado, a classe de processamento de pagamentos deve ser projetada para ser estendida sem a necessidade de modificações. Em vez de adicionar lógica condicional para cada novo tipo de pagamento, você deve usar abstrações, como interfaces ou classes base, e permitir que novas implementações adicionem comportamentos específicos sem alterar o código existente.

Por exemplo, criando uma interface para métodos de pagamento (IPaymentMethod) e implementando classes separadas para cada tipo de pagamento (CreditCardPayment, BoletoPayment, etc.), você pode adicionar novos tipos de pagamento sem modificar a classe de processamento de pagamentos. Essa abordagem mantém a classe de processamento de pagamentos "fechada" para alterações, mas "aberta" para a adição de novos tipos de pagamento.

