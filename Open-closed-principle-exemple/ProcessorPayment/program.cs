class Program
{
    static void Main(string[] args)
    {
        PaymentProcessor processor = new PaymentProcessor();

        IPaymentMethod debitCardPayment = new DebitCardPayment();
        processor.ProcessPayment(debitCardPayment);

        IPaymentMethod creditCardPayment = new CreditCardPayment();
        processor.ProcessPayment(creditCardPayment);

        IPaymentMethod boletoPayment = new BoletoPayment();
        processor.ProcessPayment(boletoPayment);

        IPaymentMethod loyaltyPointsPayment = new LoyaltyPointsPayment();
        processor.ProcessPayment(loyaltyPointsPayment);
    }
}