using Application.Dtos.DoctorDtos;
using Application.Interfaces;
using Application.Services.Abstract;
using AutoMapper;
using Domain;

namespace Application.Services.Concrete
{
    public class DoctorServices : IDoctorServices
    {
        private readonly IGenericServices<Doctor> _doctorRepository;
        private readonly IMapper _mapper;

        public DoctorServices(IGenericServices<Doctor> doctorRepository, IMapper mapper)
        {
            _doctorRepository = doctorRepository;
            _mapper = mapper;
        }

        public async Task AddDoctor(CreateDoctorDto dto)
        {
            var doctor = _mapper.Map<Doctor>(dto);
            await _doctorRepository.AddAsync(doctor);

        }

        public async Task DeleteDoctor(int id)
        {

            var doctor = await _doctorRepository.GetByIdAsync(id);
            await _doctorRepository.DeleteAsync(doctor);

        }

        public async Task<List<ResultDoctorDto>> GetAllDoctor()
        {
            var doctors = await _doctorRepository.GetAllAsync();
            var result = _mapper.Map<List<ResultDoctorDto>>(doctors);
            return result;

        }

        public async Task<ResultDoctorDto> GetByIdDoctor(int id)
        {
            var doctor = await _doctorRepository.GetByIdAsync(id);
            var result = _mapper.Map<ResultDoctorDto>(doctor);
            return result;

        }

        public async Task UpdateDoctor(UpdateDoctorDto dto)
        {
            var doctor = await _doctorRepository.GetByIdAsync(dto.Id);
            var newDoctor = _mapper.Map(dto, doctor);
            await _doctorRepository.UpdateAsync(newDoctor);

        }
    }
}
