using AlunoApi.Entities;
using AlunoApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AlunoApi.Endpoints
{
    public class AlunoGet
    {
        public static string Template => "/aluno/{id:int}";
        public static string[] Metodo => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Func => Acao;
            //delegate guarda o método de uma função, "ponteiro"

        public static IResult Acao([FromRoute] int id)
        {
            AlunoRepository alunoCarga = new AlunoRepository();
            alunoCarga.Carga();

            Aluno alunoEncontrado = AlunoRepository.BancoDeDados.FirstOrDefault(a => a.Id.Equals(id));

            if(alunoEncontrado != null)
            {
                return Results.Ok(alunoEncontrado);
            }
            else
            {
                return Results.NotFound();
            }
        }

    }
    public class AlunoPost
    {

    }
}
