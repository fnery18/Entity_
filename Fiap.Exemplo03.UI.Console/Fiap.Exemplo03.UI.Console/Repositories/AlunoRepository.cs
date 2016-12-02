using Fiap.Exemplo03.UI.Console.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo03.UI.Console.Repositories
{
    public interface AlunoRepository
    {
        public Uri Cadastrar()
        {
            using (var aluno = new HttpClient())
            {
                aluno.BaseAddress = new Uri("http://localhost:58692/");

                var alu = new AlunoDTO()
                { Nome = "Felipe",
                  GrupoId = 1
                };

                HttpResponseMessage response = aluno.PostAsJsonAsync("api/aluno", alu).Result;
                if (response.IsSuccessStatusCode)
                {
                    Uri uri = response.Headers.Location;
                    return uri;
                }
             
            }
        }

        public IEnumerable<AlunoDTO> Listar()
        {
            using (var aluno = new HttpClient())
            {
                aluno.BaseAddress = new Uri("http://localhost:22345/");
                aluno.DefaultRequestHeaders.Accept.Clear();
                aluno.DefaultRequestHeaders.Accept.Add(new
                MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/aluno").Result;
                if (response.IsSuccessStatusCode)
                {
                    IEnumerable<AlunoDTO> aluno =
                    response.Content.ReadAsAsync<IEnumerable<AlunoDTO>>().Result;
                }
            }
        }

    }
}
