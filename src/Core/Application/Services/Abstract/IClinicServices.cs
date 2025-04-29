using Application.Dtos.ClinicDtos;

namespace Application.Services.Abstract
{
    public interface IClinicServices
    {
        Task<List<ResultClinicDto>> GetAllClinic();
        Task<ResultClinicDto> GetByIdClinic(int id);
        Task AddClinic(CreateClinicDto dto);
        Task UpdateClinic(UpdateClinicDto dto);
        Task DeleteClinic(int id);
    }
}
