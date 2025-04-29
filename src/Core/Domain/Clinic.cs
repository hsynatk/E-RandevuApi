namespace Domain
{
    public class Clinic
    {
        public int Id { get; set; }
        public string ClinicName { get; set; } 
        public string ClinicType { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }

        public ICollection<Doctor> Doctors { get; set; }
    }
}
