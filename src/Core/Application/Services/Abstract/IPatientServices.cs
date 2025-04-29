using Application.Dtos.PatientDtos;

namespace Application.Services.Abstract
{
    public interface IPatientServices
    {
        Task<List<ResultPatientDto>> GetAllPatient();
        Task<ResultPatientDto> GetByIdPatient(int id);
        Task AddPatient(CreatePatientDto dto);
        Task UpdatePatient(UpdatePatientDto dto);
        Task DeletePatient(int id);
    }
}
