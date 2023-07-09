using AutoMapper;
using IntegracaoAPI.DTOS;
using IntegracaoAPI.Views;

namespace IntegracaoAPI.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilAPI _brasilAPI;

        public EnderecoService(IMapper mapper, IBrasilAPI brasilAPI)
        {
            _mapper = mapper;
            _brasilAPI = brasilAPI;
        }

        public async Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep)
        {
            var endereco = await _brasilAPI.BuscarEnderecoPorCEP(cep);
            return _mapper.Map<ResponseGenerico<EnderecoResponse>>(endereco);
        }
    }
}