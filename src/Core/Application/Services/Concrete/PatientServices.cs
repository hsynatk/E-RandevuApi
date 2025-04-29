using Application.Dtos.PatientDtos;
using Application.Interfaces;
using Application.Services.Abstract;
using AutoMapper;
using Domain;

namespace Application.Services.Concrete
{
    public class PatientServices : IPatientServices
    {
        private readonly IGenericServices<Patient> _patientRepository;
        private readonly IMapper _mapper;

        public PatientServices(IGenericServices<Patient> patientRepository, IMapper mapper)
        {
            _patientRepository = patientRepository;
            _mapper = mapper;
        }

        public async Task AddPatient(CreatePatientDto dto)
        {
            var patient = _mapper.Map<Patient>(dto);
            await _patientRepository.AddAsync(patient);
        }

        public async Task DeletePatient(int id)
        {
            var patient = await _patientRepository.GetByIdAsync(id);
            await _patientRepository.DeleteAsync(patient);
        }

        public async Task<List<ResultPatientDto>> GetAllPatient()
        {
          var patients = await _patientRepository.GetAllAsync();
            var result = _mapper.Map<List<ResultPatientDto>>(patients);
            return result;
        }

        public async Task<ResultPatientDto> GetByIdPatient(int id)
        {
           var patient = await _patientRepository.GetByIdAsync(id);
            var result = _mapper.Map<ResultPatientDto>(patient);
            return result;
        }

        public async Task UpdatePatient(UpdatePatientDto dto)
        {
            var patient = await _patientRepository.GetByIdAsync(dto.Id);
            var newPatient = _mapper.Map(dto,patient);
            await _patientRepository.UpdateAsync(newPatient);
        }
    }
}
