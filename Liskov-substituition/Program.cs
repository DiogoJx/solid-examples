class Program{
    static void Main(string[] args){
        Console.WriteLine("Realizando um sque na Conta");   
        Console.WriteLine("");

        Conta c1 = new Conta(1);

        c1.saque(1,100);

        Console.ReadKey();
        Console.WriteLine("");

        // -----------------------------
     Console.WriteLine("Realizando um saque na Conta Poupança");   
        Console.WriteLine("");

        Conta c2 = new ContaPoupanca(2);

        c2.saque(2,200);

        Console.ReadKey();
        Console.WriteLine("");

    }
}