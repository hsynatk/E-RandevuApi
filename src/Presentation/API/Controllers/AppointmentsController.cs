using Application.Dtos.AppointmentDtos;
using Application.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentServices _appointmentRepository;
        public AppointmentsController(IAppointmentServices appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAppointments()
        {
            var appointments = await _appointmentRepository.GetAllAppointment();
            return Ok(appointments);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAppointmentById(int id)
        {
            var appointment = await _appointmentRepository.GetByIdAppointment(id);
            return Ok(appointment);
        }

        [HttpPost]
        public async Task<IActionResult> AddAppointment(CreateAppointmentDto dto)
        {
            await _appointmentRepository.AddAppointment(dto);
            return Ok("Randevu bilgisi başarılı şekilde oluşturuldu.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAppointment(UpdateAppointmentDto dto)
        {
            await _appointmentRepository.UpdateAppointment(dto);
            return Ok("Randevu bilgisi başarılı şekilde güncellendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppointment(int id)
        {
            await _appointmentRepository.DeleteAppointment(id);
            return Ok("Randevu bilgisi başarılı şekilde silindi.");
        }
    }
}
