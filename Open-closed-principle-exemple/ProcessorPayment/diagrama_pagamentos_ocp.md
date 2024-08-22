
# Diagrama de Classes para Processamento de Pagamentos utilizando OCP

## Descrição

Este diagrama de classes demonstra uma solução para o processamento de pagamentos que segue o Princípio Aberto-Fechado (OCP). A solução é composta por uma interface para métodos de pagamento e classes específicas para cada tipo de pagamento. A classe `PaymentProcessor` utiliza a interface para processar os pagamentos, permitindo que novos métodos de pagamento sejam adicionados sem modificar o código existente.

## Diagrama de Classes

```plaintext
+--------------------+        +-------------------------+
|  PaymentProcessor  |        |       IPaymentMethod     |
|--------------------|        |-------------------------|
| - paymentMethod    |<-------| + Validate() : void      |
|                    |        | + ProcessPayment() : void|
|--------------------|        +-------------------------+
| + ProcessPayment() |                  ^
|                    |                  |
+--------------------+                  |
                                         |
                                         |
                 +----------------------+----------------------+
                 |                      |                      |
                 |                      |                      |
+-------------------------+  +-------------------------+  +-------------------------+
|  DebitCardPayment        |  |  CreditCardPayment      |  |  BoletoPayment          |
|--------------------------|  |------------------------|  |------------------------|
|                          |  |                        |  |                        |
|--------------------------|  |------------------------|  |------------------------|
| + Validate() : void       |  | + Validate() : void    |  | + Validate() : void    |
| + ProcessPayment() : void |  | + ProcessPayment() : void|  | + ProcessPayment() : void|
+--------------------------+  +------------------------+  +------------------------+

+-------------------------+
|  LoyaltyPointsPayment    |
|--------------------------|
|                          |
|--------------------------|
| + Validate() : void      |
| + ProcessPayment() : void|
+--------------------------+
```

## Explicação

- **IPaymentMethod:** Uma interface que define os métodos `Validate()` e `ProcessPayment()` que todas as classes de pagamento devem implementar.

- **PaymentProcessor:** A classe principal que processa o pagamento. Ela depende da abstração `IPaymentMethod`, permitindo que novos métodos de pagamento sejam adicionados sem modificar essa classe.

- **DebitCardPayment, CreditCardPayment, BoletoPayment, LoyaltyPointsPayment:** Classes concretas que implementam a interface `IPaymentMethod`, cada uma representando um método de pagamento específico. Elas contêm a lógica de validação e processamento para cada tipo de pagamento.

Este design permite a extensão do sistema para incluir novos tipos de pagamento sem a necessidade de alterar o `PaymentProcessor`, aderindo ao Princípio Aberto-Fechado.
```

