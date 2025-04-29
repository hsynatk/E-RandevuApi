using Application.Dtos.AppointmentDtos;

namespace Application.Services.Abstract
{
    public interface IAppointmentServices
    {
        Task<List<ResultAppointmentDto>> GetAllAppointment();
        Task<ResultAppointmentDto> GetByIdAppointment(int id);
        Task AddAppointment(CreateAppointmentDto dto);
        Task UpdateAppointment(UpdateAppointmentDto dto);
        Task DeleteAppointment(int id);
    }
}
