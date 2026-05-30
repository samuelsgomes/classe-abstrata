namespace classe_usando_abstract
{
    public class Aluno : Pessoa
    {
        public override void Apresentar(string nome, int idade)
    {
     Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos ")
    }
}
