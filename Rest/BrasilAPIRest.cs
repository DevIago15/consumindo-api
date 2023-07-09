using IntegracaoAPI.Views;
using IntegracaoAPI.DTOS;
using IntegracaoAPI.Model;
using System.Text.Json;
using System.Dynamic;

namespace IntegracaoAPI.Rest
{
    public class BrasilAPIRest : IBrasilAPI
    {
        public async Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");
            
            var response = new ResponseGenerico<EnderecoModel>();

            using(var client = new HttpClient())
            {
                var responseBrasilAPI = await client.SendAsync(request);
                var contentResp = await responseBrasilAPI.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<EnderecoModel>(contentResp);

                if(responseBrasilAPI.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilAPI.StatusCode;
                    response.DadosRetornos = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilAPI.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }

            return response;
        }

        public async Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://brasilapi.com.br/api/banks/v1");
            
            var response = new ResponseGenerico<List<BancoModel>>();

            using(var client = new HttpClient())
            {
                var responseBrasilAPI = await client.SendAsync(request);
                var contentResp = await responseBrasilAPI.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<List<BancoModel>>(contentResp);

                if(responseBrasilAPI.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilAPI.StatusCode;
                    response.DadosRetornos = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilAPI.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }

            return response;
        }

        public async Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1/{codigoBanco}");
            
            var response = new ResponseGenerico<BancoModel>();

            using(var client = new HttpClient())
            {
                var responseBrasilAPI = await client.SendAsync(request);
                var contentResp = await responseBrasilAPI.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<BancoModel>(contentResp);

                if(responseBrasilAPI.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilAPI.StatusCode;
                    response.DadosRetornos = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilAPI.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }

            return response;
        }

        public Task<ResponseGenerico<List<BancoModel>>> BuscasTodosBancos()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseGenerico<List<BancoModel>>> BuscarTodos()
        {
            throw new NotImplementedException();
        }
    }
}