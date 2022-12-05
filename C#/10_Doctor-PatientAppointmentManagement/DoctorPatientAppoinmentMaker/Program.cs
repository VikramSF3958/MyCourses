namespace DoctorPatientAppoinmentMaker;

class Program 
{
    public static void Main(string[] args)
    {
        DefaultData.DefaultValues();
        AppointmentManager.MainMenu();
    }
}