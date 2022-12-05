

namespace DoctorPatientAppoinmentMaker
{
    public static partial class AppointmentManager
    {   
        public static Patient currentuser = null;
        public static void LoginMenu()
        {
            string condition1 = "yes";

            while(condition1 == "yes")
            {
                Console.Clear();
                System.Console.WriteLine("Doctor - Patient Appointment Manager");
                System.Console.WriteLine();
                System.Console.WriteLine($"Welcome, {currentuser.PatientName}");
                System.Console.WriteLine();

                System.Console.WriteLine("1.Book Appointment\n2.View Appointment Details\n3.Edit My Profile\n4.Exit");
                System.Console.Write("Enter your Option: ");
                int option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {   
                        //Book Appointment
                        BookAppointment();
                        Console.ReadKey();
                        break;
                    }

                    case 2:
                    {   
                        //View Appointment 
                        ViewAppointmentDetails();
                        Console.ReadKey();
                        break;
                    }
                    
                    case 3:
                    {   
                        //Edit My Profile
                        EditMyProfile();
                        Console.ReadKey();
                        break;
                    }

                    case 4:
                    {   
                        //Exit
                        condition1 = "no";
                        System.Console.WriteLine("Press any key to logout and return to MainMenu...");
                        Console.ReadKey();
                        break;
                    }

                    default:
                    {   
                        System.Console.WriteLine("Invalid option selected");
                        break;
                    }
                }
            }
        }
    
        public static void BookAppointment()
        {
            Console.Clear();
                
            System.Console.WriteLine("Doctor - Patient Appointment Manager");
            System.Console.WriteLine();

            System.Console.WriteLine("Book Your Appointment");
            System.Console.WriteLine();

            //Display the Departments
            System.Console.WriteLine("1.Anaesthesiology\n2.Cardiology\n3.Diabetology\n4.Neonatology\n5.Nephrology");
            System.Console.Write("Enter your option: ");
            int option = int.Parse(Console.ReadLine());

            string value = "";

            switch(option)
            {
                case 1:
                {   
                    value = "Anaesthesiology";
                    break;
                }

                case 2:
                {
                    value = "Cardiology";
                    break;
                }

                case 3:
                {   
                    value = "Diabetology";
                    break;
                }

                case 4:
                {   
                    value = "Neonatology";
                    break;
                }

                case 5:
                {
                    value = "Nephrology";
                    break;
                }

                default:
                {
                    System.Console.WriteLine("Invalid Option ");
                    break;
                }
            }

            //Getting Doctor of the Department
            Doctor temporaryDoctor = null;
            foreach(Doctor doctor in DoctorsList)
            {
                if(doctor.DoctorDepartment == value)
                {
                    temporaryDoctor = doctor;
                    break;
                }
            }

            System.Console.WriteLine();
            System.Console.Write("Enter your Appointment Date in (MM/dd/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null);

            int DoctorCount = 0;
            foreach(Appointment appointment in AppointmentsList)
            {   
                if( appointment.DoctorID == temporaryDoctor.DoctorID && appointment.AppointmentDate == date )
                {   
                    DoctorCount++;
                }
            }

            if((DoctorCount == 0) || (DoctorCount == 1))
                {
                    System.Console.Write("State Your Problem: ");
                    string problem = Console.ReadLine();
                    
                    //Creating an appointment
                    System.Console.WriteLine("To Book press Y, to cancel N");
                    string choice = Console.ReadLine().ToUpper();
                    
                    if(choice == "Y")
                    {
                        Appointment newAppointment = new Appointment(currentuser.PatientID, temporaryDoctor.DoctorID, date, problem);
                        AppointmentsList.Add(newAppointment);

                        System.Console.WriteLine($"Appointment is confirmed  for the Date - {newAppointment.AppointmentDate.ToShortDateString()}");
                    }else if(choice == "N")
                    {
                        System.Console.WriteLine("Booking Cancelled");
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid Choice");
                    }
                }
                else
                {
                    System.Console.WriteLine("Sorry No More appointments for this doctor on this day");
                    
                }
        }
        
    
        public static void EditMyProfile()
        {
            Console.Clear();
                
            System.Console.WriteLine("Doctor - Patient Appointment Manager");
            System.Console.WriteLine();

            System.Console.Write("Edit Your Name: ");
            currentuser.PatientName = Console.ReadLine();
            
            System.Console.Write("Edit your Password: ");
            currentuser.PatientPassword = Console.ReadLine();
            
            System.Console.Write("Edit your Age: ");
           
            //Validating Age
            int age = 0;
            bool age_result = int.TryParse(Console.ReadLine(), out age);
            //Validating Age
            while(!age_result)
            {
                System.Console.Write("Enter your Age in 'numbers': ");
                age_result = int.TryParse(Console.ReadLine(), out age);
            }
            currentuser.PatientAge = age;

            System.Console.Write("Edit your Gender (Male/Female): ");
           // currentuser.Gender = Enum.Parse<e_Gender>(Console.ReadLine(), true);

            e_Gender gender;
            bool result = Enum.TryParse<e_Gender>(Console.ReadLine(),true, out gender);
            //Validating Gender
            while(!result)
            {
                System.Console.Write("Enter your Gender again (Male/Female): ");
                result = Enum.TryParse<e_Gender>(Console.ReadLine(),true, out gender);
            }
            currentuser.Gender = gender;



            System.Console.WriteLine();
            System.Console.WriteLine("Profile Updated");
        }
    
        public static void ViewAppointmentDetails()
        {
            Console.Clear();
                
            System.Console.WriteLine("Doctor - Patient Appointment Manager");
            System.Console.WriteLine();

            System.Console.WriteLine("Appointment Details");
            System.Console.WriteLine();

            System.Console.WriteLine("AppointmentID\tPatientID\tDoctorID\tAppointmentDate\t\tProblem");
            foreach(Appointment appointment in  AppointmentsList)
            {
                if(appointment.PatientID == currentuser.PatientID)
                {
                    System.Console.WriteLine($"{appointment.AppointmentID}\t\t{appointment.PatientID}\t\t{appointment.DoctorID}\t\t{appointment.AppointmentDate.ToString("MM/dd/yyyy")}\t\t{appointment.Problem}");
                
                }
            }
        }
    }
}