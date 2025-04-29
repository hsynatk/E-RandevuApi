using Application.Dtos.DoctorDtos;
using Application.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorServices _doctorRepository;

        public DoctorsController(IDoctorServices doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDoctors()
        {
            var doctors = await _doctorRepository.GetAllDoctor();
            return Ok(doctors);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDoctorById(int id)
        {
            var doctor = await _doctorRepository.GetByIdDoctor(id);
            return Ok(doctor);
        }

        [HttpPost]
        public async Task<IActionResult> AddDoctor(CreateDoctorDto dto)
        {
            await _doctorRepository.AddDoctor(dto);
            return Ok("Doktor bilgisi başarılı şekilde oluşturuldu.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDoctor(UpdateDoctorDto dto)
        {
            await _doctorRepository.UpdateDoctor(dto);
            return Ok("Doktor bilgisi başarılı şekilde güncellendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            await _doctorRepository.DeleteDoctor(id);
            return Ok("Doktor bilgisi başarılı şekilde silindi.");
        }

    }
}
