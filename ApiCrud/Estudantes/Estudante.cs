namespace ApiCrud.Estudantes
{
    public class Estudante
    {

        public Guid Id { get; init; }
        public string Nome { get; private set;
        }
        public bool ativo { get; private set; }

        public Estudante(String nome) 
        {

            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.ativo = true;

        }

    }
}
