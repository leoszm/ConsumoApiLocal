using AlunoApi.Entities;
using AlunoApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AlunoApi.Endpoints
{
    public class AlunoGet
    {
        public string Template => "/products/{id:int}";
        public string[] Metodo => new string[] { HttpMethod.Get.ToString() };
        public Delegate Func => Acao;
            //delegate guarda o método de uma função, "ponteiro"

        public IResult Acao([FromRoute] int id)
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
}
