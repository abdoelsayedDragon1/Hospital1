namespace Hospital.Models
{
    public class AppointmentDoctor
    {
        public int Id { get; set; } 
        public int DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
        public int AppointmentId { get; set; }
        public Appointment? Appointment { get; set; }
    }
}
