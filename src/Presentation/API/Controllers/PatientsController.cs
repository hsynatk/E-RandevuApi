using Application.Dtos.PatientDtos;
using Application.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientServices _patientRepository;

        public PatientsController(IPatientServices patientRepository)
        {
            _patientRepository = patientRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPatients()
        {
            var patients = await _patientRepository.GetAllPatient();
            return Ok(patients);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatientById(int id)
        {
            var patient = await _patientRepository.GetByIdPatient(id);
            return Ok(patient);
        }

        [HttpPost]
        public async Task<IActionResult> AddPatient(CreatePatientDto dto)
        {
            await _patientRepository.AddPatient(dto);
            return Ok("Hasta bilgisi başarılı şekilde oluşturuldu.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePatient(UpdatePatientDto dto)
        {
            await _patientRepository.UpdatePatient(dto);
            return Ok("Hasta bilgisi başarılı şekilde güncellendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatient(int id)
        {
            await _patientRepository.DeletePatient(id);
            return Ok("Hasta bilgisi başarılı şekilde silindi.");
        }
    }
}
