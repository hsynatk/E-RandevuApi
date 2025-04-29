using Application.Dtos.ClinicDtos;
using Application.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicsController : ControllerBase
    {
        private readonly IClinicServices _clinicRepository;

        public ClinicsController(IClinicServices clinicRepository)
        {
            _clinicRepository = clinicRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClinics()
        {
            var clinics = await _clinicRepository.GetAllClinic();
            return Ok(clinics);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClinicById(int id)
        {
            var clinic = await _clinicRepository.GetByIdClinic(id);
            return Ok(clinic);  
           
        }

        [HttpPost]
        public async Task<IActionResult> AddClinic(CreateClinicDto dto)
        {

            await _clinicRepository.AddClinic(dto);
            return Ok("Klinik bilgisi başarılı şekilde oluşturuldu.");

        }

        [HttpPut]
        public async Task<IActionResult> UpdateClinic(UpdateClinicDto dto)
        {
            await _clinicRepository.UpdateClinic(dto);
            return Ok("Klinik bilgisi başarılı şekilde güncellendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClinic(int id)
        {
            await _clinicRepository.DeleteClinic(id);
            return Ok("Klinik bilgisi başarılı şekilde silindi.");
        }
    }
}
