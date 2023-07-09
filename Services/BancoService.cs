using AutoMapper;
using IntegracaoAPI.DTOS;
using IntegracaoAPI.Views;

namespace IntegracaoAPI.Services
{
    public class BancoService : IBancoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilAPI _brasilAPI;

        public BancoService(IMapper mapper, IBrasilAPI brasilAPI)
        {
            _mapper = mapper;
            _brasilAPI = brasilAPI;
        }

        public async Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco)
        {
            var banco = await _brasilAPI.BuscarBanco(codigoBanco);
            return _mapper.Map<ResponseGenerico<BancoResponse>>(banco);
        }

        public async Task<ResponseGenerico<List<BancoResponse>>> BuscarTodos()
        {
            var bancos = await _brasilAPI.BuscarTodos();
            return _mapper.Map<ResponseGenerico<List<BancoResponse>>>(bancos);
        }
    }
}