namespace Documents.classe_usando_abstract
{
    public abstract class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public abstract void Apresentar(string nome , int idade);
   
    }
}