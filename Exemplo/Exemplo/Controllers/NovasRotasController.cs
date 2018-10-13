using System;
using System.Web;
using System.Web.Mvc;

namespace Example.Controllers
{
    //3 - Atribuir o routeprefix
    //[RoutePrefix("novasrotas")]
    //4 - Renomear prefixo
    [RoutePrefix("geral")]
    public class NovasRotasController : Controller
    {
        // GET: NovasRotas
        //1 - http://localhost:49947/novasrotas?nascimento=11-22-2013
        //2 - declarar os parâmetros
        //http://localhost:49947/novasrotas/index/09-11-2018
        // [Route("novasrotas/index/{nascimento:datetime}")]

        //3 - Rota com prefixo
        [Route("index/{nascimento:datetime}")]
        public string Index(DateTime nascimento)
        {
            return string.Format("Data de Nascimento {0:dd/MM/yyyy}", nascimento);
        }

        //1 - http://localhost:49947/novasrotas/getdados?nome=sabrine&sobrenome=piovesana
        //2 - declarar os parâmetros
        //http://localhost:49947/novasrotas/getdados/sabrine/piovesana
        //[Route("novasrotas/getdados/{nome}/{idade}")]

        //3 - Rota com prefixo
        //[Route("getdados/{nome}/{idade}")]

        //5 - Renomear o método
        [Route("info/{nome}/{idade}")]
        public string GetDados(string nome, string sobrenome)
        {
            return HttpUtility.HtmlEncode($"Bem vinda {nome} {sobrenome}");
        }

        //1 - http://localhost:49947/novasrotas/getpreco?preco=10
        //2 - declarar os parâmetros
        //http://localhost:49947/novasrotas/getpreco/10
        //[Route("novasrotas/getpreco/{preco}")]

        //3 - Rota com prefixo
       // [Route("getpreco/{preco}")]

        //5 - Renomear o método e atribuir um valor mínimo
        [Route("cotacao/{preco:int:min(20)}")]
        public string GetPreco(int preco)
        {
            return $"Preço do produto: {preco}";
        }

        //1 - http://localhost:49947/novasrotas/getcliente?id=125
        //2 - declarar os parâmetros
        //http://localhost:49947/novasrotas/getcliente/125
        // [Route("novasrotas/getcliente/{id}")]

        //3 - Rota com prefixo
        //[Route("getcliente/{id}")]

        //5 - Renomear o método e atribuir um valor mínimo e máximo
        [Route("cliente/{id:int:min(5):max(99)}")]
        public string GetCliente(int id)
        {
            return $"Código do cliente: {id}";
        }
    }
}