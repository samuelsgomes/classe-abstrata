namespace classe_usando_abstract
{
    public class Iphone: Smartphone
    {
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando {nome} no Iphone");
        }
    }
}