using AutoMapper;
using clientes_api.Data.Dtos;
using clientes_api.Models;

namespace clientes_api.Profiles
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<CreateClientDto, Client>();
            CreateMap<Client, ReadClientDto>();
        }
    }
}
