namespace classe_usando_abstract
{
    public class Nokia: Smartphone
    {
         public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando {nome} no Nokia");
        }
    }
}