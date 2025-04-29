using Application.Dtos.ClinicDtos;
using AutoMapper;
using Domain;

namespace Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
           
            CreateMap<Clinic,CreateClinicDto>().ReverseMap();
            CreateMap<Clinic, UpdateClinicDto>().ReverseMap();
            CreateMap<Clinic, ResultClinicDto>().ReverseMap();
            CreateMap<Clinic, DetailClinicDto>().ReverseMap();
        }
    }
}
