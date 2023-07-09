using AutoMapper;
using IntegracaoAPI.DTOS;
using IntegracaoAPI.Model;

namespace IntegracaoAPI.Mappings
{
    public class BancoMapping : Profile
    {
        public BancoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<BancoResponse, BancoModel>();
            CreateMap<BancoModel, BancoResponse>();

        }
    }




}