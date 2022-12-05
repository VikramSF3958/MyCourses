
namespace DoctorPatientAppoinmentMaker
{
    public class Doctor
    {
        private static int _doctorid = 0;

        public string DoctorID { get; }

        public string DoctorName { get; set; }

        public string DoctorDepartment { get; set; }

        public Doctor()
        {

        }

        public Doctor(string doctorName, string doctorDepartment)
        {
            _doctorid++;
            DoctorID = "DID" + _doctorid;
            DoctorName = doctorName;
            DoctorDepartment = doctorDepartment;
        }
    }
}