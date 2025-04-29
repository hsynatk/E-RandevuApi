namespace Application.Dtos.DoctorDtos
{
    public class DetailDoctorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }

        // Klinik bilgileri
        public int ClinicId { get; set; }
        public string ClinicName { get; set; } // Eğer Clinic entity'de varsa
    }
}
