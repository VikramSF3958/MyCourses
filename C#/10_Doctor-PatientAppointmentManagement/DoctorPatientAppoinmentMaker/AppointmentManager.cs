
namespace DoctorPatientAppoinmentMaker
{   
    
    public static partial class AppointmentManager
    {
        public static List<Doctor> DoctorsList = new List<Doctor>();

        public static List<Patient> PatientsList = new List<Patient>();

        public static List<Appointment> AppointmentsList = new List<Appointment>();

        public static void MainMenu()
        {
            string condition = "yes";

            while(condition == "yes")
            {
                Console.Clear();
                
                System.Console.WriteLine("Doctor - Patient Appointment Manager");
                System.Console.WriteLine();
                System.Console.WriteLine("1.Login\n2.Register\n3.Exit");
                System.Console.Write("Enter your option: ");
                int option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {   
                        //Login
                        Login();
                        break;
                    }

                    case 2:
                    {   
                        //Register
                        Register();
                        Console.ReadKey();
                        break;
                    }

                    case 3:
                    {   
                        //Exit
                        condition = "no";
                        System.Console.WriteLine("Press again to Exit...");
                        Console.ReadKey();
                        break;
                    }

                    default:
                    {   
                        System.Console.WriteLine("Invalid Option Selected !!!!");
                        Console.ReadKey();
                        break;
                    }
                }
            }

        }
    
        public static void Register()
        {
            Console.Clear();
                
            System.Console.WriteLine("Doctor - Patient Appointment Manager");
            System.Console.WriteLine();

            System.Console.WriteLine("Register Page:");
            System.Console.WriteLine();

            System.Console.Write("Enter your Patient Name: ");
            string patientName = Console.ReadLine();
            
            System.Console.Write("Enter your Password for the account: ");
            string password = Console.ReadLine();
            
            System.Console.Write("Enter your Age: ");
            // int age = int.Parse(Console.ReadLine());
            int age = 0;

            bool age_result = int.TryParse(Console.ReadLine(), out age);
            //Validating Age
            while(!age_result)
            {
                System.Console.Write("Enter your Age in 'numbers': ");
                age_result = int.TryParse(Console.ReadLine(), out age);
            }


            System.Console.Write("Enter your Gender (Male/Female): ");
            // e_Gender gender = Enum.Parse<e_Gender>(Console.ReadLine(), true);
            e_Gender gender;
            bool result = Enum.TryParse<e_Gender>(Console.ReadLine(),true, out gender);

            //Validating Gender
            while(!result)
            {
                System.Console.Write("Enter your Gender again (Male/Female): ");
                result = Enum.TryParse<e_Gender>(Console.ReadLine(),true, out gender);
            }

            //Creating an account
            Patient newPatient = new Patient(password, patientName, age, gender);
            AppointmentManager.PatientsList.Add(newPatient);

            System.Console.WriteLine();
            System.Console.WriteLine($"Your Patient ID is {newPatient.PatientID}");

        }
    
        public static void Login()
        {
            Console.Clear();
                
            System.Console.WriteLine("Doctor - Patient Appointment Manager");
            System.Console.WriteLine();

            System.Console.WriteLine("Login Page");
            System.Console.WriteLine();

            System.Console.Write("Enter your Patient ID: ");
            string patientid = Console.ReadLine();
            
            System.Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            bool flag = true;
            foreach(Patient patient in PatientsList)
            {
                if(patient.PatientID == patientid && patient.PatientPassword == password)
                {
                    flag = false;
                    //Calling Login method
                    currentuser = patient;
                    LoginMenu();
                    break;
                }
            }
            if(flag)
            {
                System.Console.WriteLine("Invalid UserName or Password");
            }

            Console.ReadKey();
        }
    
    }
}
