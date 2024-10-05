﻿namespace Hospital.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string? PatientName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
        public ICollection<AppointmentDoctor> AppointmentDoctors { get; set; } = new List<AppointmentDoctor>();

    }
}