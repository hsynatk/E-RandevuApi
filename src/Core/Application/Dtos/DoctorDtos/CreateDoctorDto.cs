namespace Application.Dtos.DoctorDtos
{
    public class CreateDoctorDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }
        public int ClinicId { get; set; }
    }
}
