public interface IPaymentMethod{
    void Validate();
    void ProcessPayment();
}

public class DebitCardPayment : IPaymentMethod
{
    public void Validate(){
        Console.WritLine("validanting debit card...");
    }

    public void ProcessPayment(){
        Console.Write("processing debit card payment")
    }
}

public class CreditCardPayment : IPaymentMethod
{
    public void Validate(){
        Console.WritLine("validanting debit card...");
    }

    public void ProcessPayment(){
        Console.Write("processing debit card payment")
    }

}

public class DebitCardPayment : IPaymentMethod
{
        public void Validate(){
        Console.WritLine("validanting debit card...");
    }

    public void ProcessPayment(){
        Console.Write("processing debit card payment")
    }

}

public class BoletoPayment  : IPaymentMethod
{
        public void Validate(){
        Console.WritLine("validanting debit card...");
    }

    public void ProcessPayment(){
        Console.Write("processing debit card payment")
    }

}

public class LoyaltyPointsPayment : IPaymentMethod
{
    public void Validate()
    {
        Console.WriteLine("Validating loyalty points...");
    }

    public void ProcessPayment()
    {
        Console.WriteLine("Processing layalty points payment...");
    }
}

public class PaymentProcessor
{
    public void ProcessPayment(IPaymentMethod paymentMethod)
    {
        paymentMethod.Validate();
        paymentMethod.ProcessPayment();
    }
}