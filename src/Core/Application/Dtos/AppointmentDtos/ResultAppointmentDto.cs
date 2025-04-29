namespace Application.Dtos.AppointmentDtos
{
    public class ResultAppointmentDto
    {
        public int Id { get; set; }

        // Hasta bilgileri
        public int PatientId { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }

        // Doktor bilgileri
        public int DoctorId { get; set; }
        public string DoctorFirstName { get; set; }
        public string DoctorLastName { get; set; }
        public string DoctorSpecialty { get; set; } // İsteğe bağlı

        // Randevu bilgileri
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; }
    }
}
