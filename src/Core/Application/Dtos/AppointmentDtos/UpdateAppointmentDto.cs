namespace Application.Dtos.AppointmentDtos
{
    public class UpdateAppointmentDto
    {
        public int Id { get; set; }                  // Güncellenecek randevunun Id'si
        public int PatientId { get; set; }           // İsteğe bağlı, hasta değiştirilecekse
        public int DoctorId { get; set; }            // Doktor değiştirilecekse
        public DateTime AppointmentDate { get; set; } // Yeni randevu tarihi
        public string Status { get; set; }           // Randevu durumu (örneğin: Approved, Canceled)
    }
}
