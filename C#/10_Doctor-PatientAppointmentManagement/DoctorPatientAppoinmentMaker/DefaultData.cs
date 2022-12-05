
namespace DoctorPatientAppoinmentMaker
{
    public static class DefaultData
    {
        public static void DefaultValues()
        {
            //Doctor Details
            Doctor doctor1 = new Doctor("Nancy", "Anaesthesiology");
            AppointmentManager.DoctorsList.Add(doctor1);

            Doctor doctor2 = new Doctor("Andrew", "Cardiology");
            AppointmentManager.DoctorsList.Add(doctor2);

            Doctor doctor3 = new Doctor("Janet", "Diabetology");
            AppointmentManager.DoctorsList.Add(doctor3);

            Doctor doctor4 = new Doctor("Margaret", "Neonatology");
            AppointmentManager.DoctorsList.Add(doctor4);

            Doctor doctor5 = new Doctor("Steven", "Nephrology");
            AppointmentManager.DoctorsList.Add(doctor5);


            //Patient Details
            Patient patient1 = new Patient("Welcome", "Robert", 40, e_Gender.Male);
            AppointmentManager.PatientsList.Add(patient1);

            Patient patient2 = new Patient("Welcome", "Laura", 36, e_Gender.Female);
            AppointmentManager.PatientsList.Add(patient2);

            Patient patient3 = new Patient("Welcome", "Anne", 42, e_Gender.Female);
            AppointmentManager.PatientsList.Add(patient3);


            //Appointment Details
            Appointment appointment1 = new Appointment("PID1", "DID2", new DateTime(2012, 08, 03), "Heart problem");
            AppointmentManager.AppointmentsList.Add(appointment1);

            Appointment appointment2 = new Appointment("PID1", "DID5", new DateTime(2012, 08, 03), "Spinal cord injury");
            AppointmentManager.AppointmentsList.Add(appointment2);

            Appointment appointment3 = new Appointment("PID2", "DID2", new DateTime(2012, 08, 03), "Heart attack");
            AppointmentManager.AppointmentsList.Add(appointment3);


        }
    }
}
