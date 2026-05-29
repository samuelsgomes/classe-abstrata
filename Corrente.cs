namespace Documents.classe_usando_abstract
{
    public class Corrente : Conta
    {
        private double Tarifa { get; set; }

        public override void Creditar(double valor)
        {
            Saldo += valor;
        }
    }
}