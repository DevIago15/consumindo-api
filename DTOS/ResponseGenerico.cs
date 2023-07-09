using System.Dynamic;
using System.Net;

namespace IntegracaoAPI.DTOS
{
    public class ResponseGenerico<T> where T : class
    {
        public HttpStatusCode CodigoHttp { get; set; }
        public T? DadosRetornos { get; set; }
        public ExpandoObject? ErroRetorno { get; set; }
    }
}