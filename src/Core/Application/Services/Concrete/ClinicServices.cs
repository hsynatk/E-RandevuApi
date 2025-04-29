using Application.Dtos.ClinicDtos;
using Application.Interfaces;
using Application.Services.Abstract;
using AutoMapper;
using Domain;

namespace Application.Services.Concrete
{
    public class ClinicServices : IClinicServices
    {
        private readonly IGenericServices<Clinic> _clinicRepository;
        private readonly IMapper _mapper;
        public ClinicServices(IGenericServices<Clinic>clinicRepository,IMapper mapper)
        {
            _clinicRepository = clinicRepository;
            _mapper = mapper;
        }

        public async Task AddClinic(CreateClinicDto dto)
        {
          var clinic = _mapper.Map<Clinic>(dto);
            await _clinicRepository.AddAsync(clinic);
        }

        public async Task DeleteClinic(int id)
        {
            var clinic = await _clinicRepository.GetByIdAsync(id);
            await _clinicRepository.DeleteAsync(clinic);

        }

        public async Task<List<ResultClinicDto>> GetAllClinic()
        {
            var clinics = await _clinicRepository.GetAllAsync();
            var result = _mapper.Map<List<ResultClinicDto>>(clinics);
            return result;
        }

        public async Task<ResultClinicDto> GetByIdClinic(int id)
        {
            var clinic = await _clinicRepository.GetByIdAsync(id);
            var result = _mapper.Map<ResultClinicDto>(clinic);
            return result;
        }

        public async Task UpdateClinic(UpdateClinicDto dto)
        {
           var clinic = await _clinicRepository.GetByIdAsync(dto.Id);
            var newClinic = _mapper.Map(dto,clinic);
            await _clinicRepository.UpdateAsync(newClinic);
        }
    }
}
