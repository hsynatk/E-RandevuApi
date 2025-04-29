using Application.Dtos.DoctorDtos;

namespace Application.Services.Abstract
{
    public interface IDoctorServices
    {
        Task<List<ResultDoctorDto>> GetAllDoctor();
        Task<ResultDoctorDto> GetByIdDoctor(int id);
        Task AddDoctor(CreateDoctorDto dto);
        Task UpdateDoctor(UpdateDoctorDto dto);
        Task DeleteDoctor(int id);
    }
}
