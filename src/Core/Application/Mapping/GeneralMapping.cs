using Application.Dtos.AppointmentDtos;
using Application.Dtos.ClinicDtos;
using Application.Dtos.DoctorDtos;
using Application.Dtos.PatientDtos;
using AutoMapper;
using Domain;

namespace Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            // Clinic Mappings
            CreateMap<Clinic, CreateClinicDto>().ReverseMap();
            CreateMap<Clinic, UpdateClinicDto>().ReverseMap();
            CreateMap<Clinic, ResultClinicDto>().ReverseMap();
            CreateMap<Clinic, DetailClinicDto>().ReverseMap();

            // Patient Mappings
            CreateMap<Patient, CreatePatientDto>().ReverseMap();
            CreateMap<Patient, UpdatePatientDto>().ReverseMap();
            CreateMap<Patient, ResultPatientDto>().ReverseMap();
            CreateMap<Patient, DetailPatientDto>().ReverseMap();

            // Doctor Mappings
            CreateMap<Doctor, CreateDoctorDto>().ReverseMap();
            CreateMap<Doctor, UpdateDoctorDto>().ReverseMap();
            CreateMap<Doctor, ResultDoctorDto>().ReverseMap();
            CreateMap<Doctor, DetailDoctorDto>().ReverseMap();

            // Appointment Mappings
            CreateMap<Appointment, CreateAppointmentDto>().ReverseMap();
            CreateMap<Appointment, UpdateAppointmentDto>().ReverseMap();

            // ⬇️ Özelleştirilmiş ResultAppointmentDto Mapping
            CreateMap<Appointment, ResultAppointmentDto>()
                .ForMember(dest => dest.PatientFirstName, opt => opt.MapFrom(src => src.Patient.FirstName))
                .ForMember(dest => dest.PatientLastName, opt => opt.MapFrom(src => src.Patient.LastName))
                .ForMember(dest => dest.DoctorFirstName, opt => opt.MapFrom(src => src.Doctor.FirstName))
                .ForMember(dest => dest.DoctorLastName, opt => opt.MapFrom(src => src.Doctor.LastName))
                .ForMember(dest => dest.DoctorSpecialty, opt => opt.MapFrom(src => src.Doctor.Specialty));

            CreateMap<Appointment, DetailAppointmentDto>().ReverseMap();
        }
    }
}
