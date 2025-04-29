namespace Domain
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }

        // Klinik ile ilişki
        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }

}
