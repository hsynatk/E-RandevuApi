namespace Application.Dtos.AppointmentDtos
{
    public class DetailAppointmentDto
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string PatientFullName { get; set; }
        public int DoctorId { get; set; }
        public string DoctorFullName { get; set; }
        public string DoctorSpecialty { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; }
    }
}
