
namespace DoctorPatientAppoinmentMaker
{
    public class Appointment
    {
        private static int _appointmentid = 0;

        public string AppointmentID { get;  }

        public string PatientID { get; set; }

        public string DoctorID { get; set; }

        public DateTime AppointmentDate { get; set; }

        public string Problem { get; set; }

    
        public Appointment()
        {

        }

        public Appointment(string patientId, string doctorId, DateTime appointmentDate, string problem)
        {   
            _appointmentid++;
            AppointmentID = "AID" + _appointmentid;
            PatientID = patientId;
            DoctorID = doctorId;
            AppointmentDate = appointmentDate;
            Problem = problem;
        }


    }
}