using System;

namespace SistemaEscola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Another bites the dust...

            Aluno[] alunos = new Aluno[5];
            Turma[] turmas = new Turma[5];
            Professor[] professores = new Professor[5];
            int alunoIdx = 0, turmaIdx = 0, professorIdx = 0;
            bool emUso = true;
            while (emUso)
            {
                Console.WriteLine("");
                Console.WriteLine("Bem vindo ao sistema escolar!");
                Console.WriteLine("");
                Console.WriteLine("Escolha uma das opções do menu:");
                Console.WriteLine("");
                Console.WriteLine("1) Adicionar aluno");
                Console.WriteLine("2) Adicionar professor");
                Console.WriteLine("3) Adicionar turma");
                Console.WriteLine("4) Listar alunos");
                Console.WriteLine("5) Listar professores");
                Console.WriteLine("6) Listar turmas");
                Console.WriteLine("");
                Console.Write("Digite uma opção: ");
                string opcao = Console.ReadLine();

                if (int.Parse(opcao) == 1)
                {
                    if (alunoIdx < 5)
                    {
                        int id;
                        string nome, nascimento;
                        Console.Write("Digite um ID: ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("Digite o nome do Aluno: ");
                        nome = Console.ReadLine();
                        Console.Write("Digite a data de nascimento do Aluno: [DD/MM/AAAA] ");
                        nascimento = Console.ReadLine();
                        alunos[alunoIdx] = new Aluno(id, nome, nascimento);
                        alunoIdx++;
                    }
                    else
                    {
                        Console.WriteLine("Vetor cheio");
                    }
                }
                else if (int.Parse(opcao) == 2)
                {
                    // Adiciona professor
                    if (professorIdx < 5)
                    {
                        int id;
                        string nome, nascimento, formacao, formacaoPos, dataFormacao, DataFormacaoPos;
                        Console.Write("Digite um ID: ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("Digite o nome do Professor: ");
                        nome = Console.ReadLine();
                        Console.Write("Digite a data de nascimento do Professor: [DD/MM/AAAA] ");
                        nascimento = Console.ReadLine();
                        Console.Write("Digite a formação do professor: ");
                        formacao = Console.ReadLine();
                        Console.Write("Digite a data da formação do professor: [DD/MM/AAAA] ");
                        dataFormacao = Console.ReadLine();
                        Console.Write("Digite a Pós Graduação do professor: ");
                        formacaoPos = Console.ReadLine();
                        Console.Write("Digite a data da formação do professor: [DD/MM/AAAA] ");
                        DataFormacaoPos = Console.ReadLine();
                        professores[professorIdx] = new Professor(id, nome, nascimento, formacao, dataFormacao,
                        formacaoPos, DataFormacaoPos);
                        professorIdx++;
                    }
                    else
                    {
                        Console.WriteLine("Vetor cheio");
                    }

                }
                else if (int.Parse(opcao) == 3)
                {
                    if (turmaIdx < 5)
                    {
                        int id;
                        string nome, sala;
                        Console.Write("Digite um ID: ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("Digite o nome do Turma: ");
                        nome = Console.ReadLine();
                        Console.Write("Digite a sala do Turma: ");
                        sala = Console.ReadLine();
                        turmas[turmaIdx] = new Turma(id, nome, sala);
                        turmaIdx++;
                    }
                    else
                    {
                        Console.WriteLine("Vetor cheio");
                    }
                }
                else if (int.Parse(opcao) == 4)
                {
                    Console.WriteLine("ID\t|Nome do aluno\t|Nascimento");
                    for (int i = 0; i < alunos.Length; i++)
                    {
                        if (alunos[i] != null)
                        {
                            Console.WriteLine("{0}\t|{1}\t|{2}",
                                alunos[i].obterId(),
                                alunos[i].ObterNome(),
                                alunos[i].obterNascimento()
                            );
                        }
                    }
                }
                else if (int.Parse(opcao) == 5)
                {
                    // Listar professores
                    Console.WriteLine("ID\t|Nome do Professor\t|Nascimento\tFormação\tData Formação\tFormação Pos\tData Formação Pos");
                    for (int i = 0; i < professores.Length; i++)
                    {
                        if (professores[i] != null)
                        {
                            Console.WriteLine("{0}\t|{1}\t|{2}\t|{3}\t|{4}\t|{5}\t|{6}",
                                professores[i].obterId(),
                                professores[i].ObterNome(),
                                professores[i].ObterNascimento(),
                                professores[i].ObterFormacao(),
                                professores[i].ObterDataFormacao(),
                                professores[i].ObterFormacaoPos(),
                                professores[i].ObterDataFormacaoPos()
                            );
                        }
                    }
                }
                else if (int.Parse(opcao) == 6)
                {
                    Console.WriteLine("ID\t|Nome da sala\t|Sala");
                    for (int i = 0; i < turmas.Length; i++)
                    {
                        if (turmas[i] != null)
                        {
                            Console.WriteLine("{0}\t|{1}\t|{2}",
                                turmas[i].ObterId(),
                                turmas[i].ObterNome(),
                                turmas[i].ObterSala()
                            );
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }

                Console.Write("Continuar? (S/N) ");
                string escolha = Console.ReadLine();
                if (escolha.ToLower() == "n")
                {
                    emUso = false;
                }
                else if (escolha.ToLower() != "s")
                {
                    Console.WriteLine("Digite (s)im ou (n)ão.");
                }
            }
        }
    }
}
