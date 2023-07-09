using AutoMapper;
using IntegracaoAPI.DTOS;
using IntegracaoAPI.Model;

namespace IntegracaoAPI.Mappings
{

    public class EnderecoMapping : Profile
    {

        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EnderecoResponse, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoResponse>();
        }

    }
}