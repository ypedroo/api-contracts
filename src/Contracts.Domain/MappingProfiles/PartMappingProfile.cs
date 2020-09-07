using AutoMapper;
using Contracts.Domain.Models;
using Contracts.Shared.Dtos;

namespace Contracts.Domain.MappingProfiles
{
    public sealed class PartMappingProfile : Profile
    {
        public PartMappingProfile()
        {
            CreateMap<PartDto, Part>().ReverseMap();
        }
    }
}