class Conta{
    public Conta(int ContaId){
        this->Id = ContaId
    }

    public virtual int Id {get; set;}

    public virtual void Saque(nt id ContaId, int valor){
        Console.WriteLine("Saque na classe Base Conta")
    }

}
class ContaPoupanca : Conta {
    public ContaPoupanca(int contaPoupancaId) : base(contaPoupancaId){}

    public override void Saque(int contaId, int valor){
        Console.WriteLine("Saque na classe derivada Conta poupança");
    }
}