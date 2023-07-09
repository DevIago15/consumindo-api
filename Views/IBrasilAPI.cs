using IntegracaoAPI.DTOS;
using IntegracaoAPI.Model;


namespace IntegracaoAPI.Views
{
    public interface IBrasilAPI
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodos();
        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);
    }
}