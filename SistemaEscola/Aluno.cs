using System;

namespace SistemaEscola
{
    public class Aluno : Pessoa
    {
        public Aluno(int id, string nome, string nascimento)
        {
            int dia, mes, ano;
            

            dia = int.Parse(nascimento.Substring(0, 2));
            mes = int.Parse(nascimento.Substring(3, 2));
            ano = int.Parse(nascimento.Substring(6, 4));

            this.Id = id;
            this.Nome = nome;
            this.Nascimento = new DateTime(ano, mes, dia);
            

        }
        public string obterId()
        {
            return string.Format("A{0}", this.Id);
        }
        public string obterNascimento()
        {
            var hoje = DateTime.Now;
            var IdadePog = hoje.Year - Nascimento.Year;
            if (Nascimento > hoje.AddYears(-IdadePog)) IdadePog--;
            return string.Format("{0} ({1} Anos)", this.Nascimento, IdadePog);
        }
    }
}
