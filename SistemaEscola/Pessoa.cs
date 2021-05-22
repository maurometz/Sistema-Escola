using System;

namespace SistemaEscola
{
    public class Pessoa
    {
        protected int Id;
        protected string Nome;
        protected DateTime Nascimento;
        public int ObterId()
        {
            return this.Id;
        }
        public string ObterNome()
        {
            return this.Nome;
        }
        public string ObterNascimento()
        {
            return this.Nascimento.ToShortDateString();
        }
    }
}