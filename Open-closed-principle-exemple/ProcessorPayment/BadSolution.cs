using System;

public class PaymentProcessor
{
    public void ProcessPayment(string paymentType)
    {
        if (paymentType == "debitCard")
        {
            ValidateDebitCard();
            ProcessDebitCardPayment();
        }
        else if (paymentType == "creditCard")
        {
            ValidateCreditCard();
            ProcessCreditCardPayment();
        }
        else if (paymentType == "boleto")
        {
            ValidateBoleto();
            ProcessBoletoPayment();
        }
        else if (paymentType == "loyaltyPoints")
        {
            ValidateLoyaltyPoints();
            ProcessLoyaltyPointsPayment();
        }
        else
        {
            throw new ArgumentException("Tipo de pagamento não suportado");
        }
    }

    private void ValidateDebitCard()
    {
        Console.WriteLine("Validando cartão de débito...");
    }

    private void ProcessDebitCardPayment()
    {
        Console.WriteLine("Processando pagamento com cartão de débito...");
    }

    private void ValidateCreditCard()
    {
        Console.WriteLine("Validando cartão de crédito...");
    }

    private void ProcessCreditCardPayment()
    {
        Console.WriteLine("Processando pagamento com cartão de crédito...");
    }

    private void ValidateBoleto()
    {
        Console.WriteLine("Validando boleto...");
    }

    private void ProcessBoletoPayment()
    {
        Console.WriteLine("Processando pagamento com boleto...");
    }

    private void ValidateLoyaltyPoints()
    {
        Console.WriteLine("Validando pontos de fidelidade...");
    }

    private void ProcessLoyaltyPointsPayment()
    {
        Console.WriteLine("Processando pagamento com pontos de fidelidade...");
    }
}
