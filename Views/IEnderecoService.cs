using IntegracaoAPI.DTOS;

namespace IntegracaoAPI.Views
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
    }
}