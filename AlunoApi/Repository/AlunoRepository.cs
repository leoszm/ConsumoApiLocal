using AlunoApi.Entities;
using System.Runtime.CompilerServices;

namespace AlunoApi.Repository
{
    public class AlunoRepository
    {
        public static List<Aluno> BancoDeDados { get; set; } = new List<Aluno>();
        public void Carga()
        {
            Aluno aluno1 = new Aluno(1, "Raphael", "Matriculado", 12352);
            Aluno aluno2 = new Aluno(2, "Vitor", "Matriculado", 4451);
            Aluno aluno3 = new Aluno(3, "Stephany", "Trancado", 3213);
            Aluno aluno4 = new Aluno(4, "Luíza", "Cancelado", 43241);
            Aluno aluno5 = new Aluno(5, "Maíra", "Transferência", 321415);

            BancoDeDados.Add(aluno1);
            BancoDeDados.Add(aluno2);
            BancoDeDados.Add(aluno3);
            BancoDeDados.Add(aluno4);
            BancoDeDados.Add(aluno5);
        }
    }
}
