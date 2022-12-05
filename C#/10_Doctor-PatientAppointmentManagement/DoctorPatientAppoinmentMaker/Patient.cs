
namespace DoctorPatientAppoinmentMaker
{   
    public enum e_Gender { Default, Male, Female }
    public class Patient
    {
        private static int _patientid = 0;

        public string PatientID { get;  }

        public string PatientPassword { get; set; }

        public string PatientName { get; set; }

        public int PatientAge { get; set; }

        public e_Gender Gender { get; set; }

        public Patient()
        {

        }

        public Patient(string patientPassword, string patientName, int patientAge, e_Gender gender)
        {
            _patientid++;
            PatientID = "PID" + _patientid;
            PatientPassword = patientPassword;
            PatientName = patientName;
            PatientAge = patientAge;
            Gender = gender;
        }

    }
}