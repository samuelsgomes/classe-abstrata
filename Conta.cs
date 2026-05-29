namespace Documents.classe_usando_abstract
{
    public abstract class Conta
{
    public double Saldo { get; set; }
    public abstract void Creditar(double valor);

    public virtual void ExibirSaldo()
    {
        Console.WriteLine("Exibir saldo");
    }
}
}