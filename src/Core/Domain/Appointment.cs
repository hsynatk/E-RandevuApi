using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Appointment
    {
        public int Id { get; set; }

        // Hasta ilişkisi
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        // Doktor ilişkisi
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; } // Pending, Approved, Canceled gibi
    }

}
