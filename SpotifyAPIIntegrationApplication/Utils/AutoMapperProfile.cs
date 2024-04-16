using AutoMapper;
using SpotifyAPIIntegrationApplication.Models;

namespace SpotifyAPIIntegrationApplication.Utils
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<string, Journal>();
        }
    }
}
