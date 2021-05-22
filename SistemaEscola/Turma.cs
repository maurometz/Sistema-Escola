namespace SistemaEscola
{
    public class Turma
    {
        private int Id;
        private string Nome;
        private string Sala;

        public Turma(int id, string nome, string sala)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sala = sala;
        }
        public int ObterId()
        {
            return this.Id;
        }
        public string ObterNome()
        {
            return this.Nome;
        }
        public string ObterSala()
        {
            return this.Sala;
        }
    }
}
