using System;

namespace SistemaEscola
{
    public class Professor : Pessoa
    {
        private string Formacao;
        private DateTime DataFormacao;
        private string FormacaoPos;
        private DateTime DataFormacaoPos;
        public Professor(int id, string nome, string nascimento, 
        string formacao, string dataFormacao, string formacaoPos, string dataFormacaoPos)
        {
            int dia, mes, ano,
                fDia, fMes, fAno,
                fpDia, fpMes, fpAno;

            dia = int.Parse(nascimento.Substring(0, 2));
            mes = int.Parse(nascimento.Substring(3, 2));
            ano = int.Parse(nascimento.Substring(6, 4));

            fDia = int.Parse(dataFormacao.Substring(0, 2));
            fMes = int.Parse(dataFormacao.Substring(3, 2));
            fAno = int.Parse(dataFormacao.Substring(6, 4));

            fpDia = int.Parse(dataFormacaoPos.Substring(0, 2));
            fpMes = int.Parse(dataFormacaoPos.Substring(3, 2));
            fpAno = int.Parse(dataFormacaoPos.Substring(6, 4));

            this.Id = id;
            this.Nome = nome;
            this.Nascimento = new DateTime(ano, mes, dia);
            this.Formacao = formacao;
            this.DataFormacao = new DateTime(fAno, fMes, fDia);
            this.FormacaoPos = formacaoPos;
            this.DataFormacaoPos = new DateTime(fpAno, fpMes, fpDia);

        }
        public string ObterFormacao()
        {
            return this.Formacao;
        }
        public string ObterDataFormacao()
        {
            return this.DataFormacao.ToShortDateString();
        }
        public string ObterFormacaoPos()
        {
            return this.Formacao;
        }
        public string ObterDataFormacaoPos()
        {
            return this.DataFormacaoPos.ToShortDateString();
        }
        public string obterId()
        {
            return string.Format("P{0}", this.Id);
        }
    }
}