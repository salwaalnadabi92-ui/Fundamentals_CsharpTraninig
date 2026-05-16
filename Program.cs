using System.ComponentModel.Design;
using System.Xml.Linq;

namespace ClinicSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Capacity constants

            const int MAX_PATIENTS = 3;
            const int MAX_DOCTORS = 2;
            const int MAX_APPOINTMENTS = 3;


            // Patient slots

            string p1Name = ""; int p1Age = 0; string p1Phone = ""; bool p1Active = false;

            string p2Name = ""; int p2Age = 0; string p2Phone = ""; bool p2Active = false;

            string p3Name = ""; int p3Age = 0; string p3Phone = ""; bool p3Active = false;


            int patientCount = 0;



            // Doctor slots


            string d1Name = "", d1Spec = ""; double d1Fee = 0; bool d1Active = false;

            string d2Name = "", d2Spec = ""; double d2Fee = 0; bool d2Active = false;

            int doctorCount = 0;


            // Appointment slots

            string a1Patient = "";
            string a1Doctor = "";
            string a1Date = "";
            string a1Status = "";
            bool a1Active = false;


            string a2Patient = "";
            string a2Doctor = "";
            string a2Date = "";
            string a2Status = "";
            bool a2Active = false;


            string a3Patient = "";
            string a3Doctor = "";
            string a3Date = "";
            string a3Status = "";
            bool a3Active = false;
            int appointmentCount = 0;




            //main menu

            while (true) ;

            {
                Console.Clear();
                Console.WriteLine("CLINIC MANAGEMENT SYSTEM");
                Console.WriteLine("1)Patient Management");
                Console.WriteLine("2)Doctor Management");
                Console.WriteLine("3) Appointment Management");
                Console.WriteLine("0) Exit");

                Console.WriteLine("Enter Your Choice:  ");

                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {

                    //Patient Management Sub - Menu
                    case 1:
                        while (true)

                        {
                            Console.Clear();
                            Console.WriteLine("Patient Management");
                            Console.WriteLine("1)Add New Patient");
                            Console.WriteLine("2)Display All Patients");
                            Console.WriteLine("3)Update Patient Phone");
                            Console.WriteLine("4)Delete Patient");
                            Console.WriteLine("0)Back to Main Menu ");

                            Console.WriteLine("Enter Your  choice:  ");

                            int patient_choice = Convert.ToInt32(Console.ReadLine());

                            switch (patient_choice)

                            {

                                //ADD Patient

                                case 1:

                                    Console.WriteLine("1)Add New Patient");

             
                                    if (patientCount == MAX_PATIENTS)
                                    {
                                        Console.WriteLine(" clinic is full");
                                    }

                                    Console.WriteLine(" enter your name ");

                                    string Name = Console.ReadLine();
                                    if (Name == null)
                                    {
                                        Console.WriteLine(" invalid name ");
                                    }

                                    Console.WriteLine(" enter your age ");

                                    int age =Convert.ToInt32 (Console.ReadLine());
                                    if (p1Age <1 || p1Age >120)
                                    {

                                        Console.WriteLine(" invalid age ");
                                    }
                                    Console.WriteLine(" enter your phone");
                                    string phone = Console.ReadLine();

                                    if(!p1Active)
                                    {
                                        p1Name = Name;
                                        p1Age = age;
                                        p1Phone = phone;
                                        p1Active = true;
                                             }
                                    else if (!p2Active)
                                    {
                                        p2Name = Name;
                                        p2Age = age;
                                        p2Phone = phone;
                                        p2Active = true;
                                    }

                                    else if (!p3Active)
                                    {
                                        p3Name = Name;
                                        p3Age = age;
                                        p3Phone = phone;
                                        p3Active = true;
                                    }
                                    patientCount++;
                                    Console.WriteLine(" Patient added successfully ");
   

                            break;


                                   // DISPLAY ALL Patients


                                case 2:

                                    int displayNum = 1;

                                    Console.WriteLine("2)Display All Patients");

                                    if (patientCount == 0)
                                    {
                                        Console.WriteLine("No patients registered");
                                    }

                                    else
                                    {
                                        if (p1Active = true) ;
                                    {


                                        Console.WriteLine("Patient #1" + displayNum);
                                        Console.WriteLine("name" + p1Name);
                                        Console.WriteLine("age" + p1Age);
                                        Console.WriteLine("phone" + p1Phone);

                                            displayNum++;

                                    }

                                        if (p2Active = true) ;

                                            Console.WriteLine("Patient #2" + displayNum);
                                            Console.WriteLine("name" + p2Name);
                                            Console.WriteLine("age" + p2Age);
                                            Console.WriteLine("phone" + p2Phone);

                                            displayNum++;
                                        }

                                        if (p3Active = true) ;
                                        {
                                            Console.WriteLine("Patient #3" + displayNum);
                                            Console.WriteLine("name" + p3Name);
                                            Console.WriteLine("age " + p3Age);
                                            Console.WriteLine("phone" + p3Phone);

                                            displayNum++;
                                        }

                                    }//else

                        
                        break;

                        

                    case 3:
                                    Console.WriteLine("3)Update Patient Phone");

                                    // UPDATE Patient Phone
                                    Console.WriteLine("enter patient name");
                                    string name = Console.ReadLine();

                                if (p1Active && p1Name == name)

                                {
                                    Console.WriteLine("enter new phone");
                                    string Newphone = Console.ReadLine();
                                    p1Phone = Newphone;

                                    Console.WriteLine("Updated");

                                }



                                else if (p2Active && p2Name == name) 
                                {
                                    Console.WriteLine("enter new phone");
                                    string Newphone = Console.ReadLine();
                                    p2Phone = Newphone;

                                    Console.WriteLine("Updated");
                                }

                                else if (p3Active && p3Name == name)
                                {
                                    Console.WriteLine("enter new phone");
                                    string Newphone = Console.ReadLine();
                                    p3Phone = Newphone;

                                    Console.WriteLine("Updated");
                                }
                                else
                                {
                                    Console.WriteLine("patient not found");

                                }

                                break;

                                case 4:

                              //DELETE Patient


                                    Console.WriteLine("4)Delete Patient");

                                Console.WriteLine("enter patient name");
                                string Name = Console.ReadLine();

                                if (p1Active && p1Name == name)

                                {
                                    p1Active = false;
                                    p1Name = "";
                                     p1Age = 0;
                                    p1Phone = "";

                                    patientCount--;

                                }
                                else if (p2Active && p2Name == name) 

                                {

                                    p2Active = false;
                                    p2Name = "";
                                     p2Age = 0;
                                    p2Phone = "";

                                    patientCount--;
                                }

                                  else if (p3Active && p3Name == name) 

                                {

                                    p3Active = false;
                                    p3Name = "";
                                     p3Age = 0;
                                    p3Phone = "";

                                    patientCount--;
                                }

                                 else

                                {
                                    Console.WriteLine("Patient not found");


                                }



                                break;

                                case 0:

                                    Console.WriteLine("0)Back to Main Menu ");
                                    break;

                                default:

                                    Console.WriteLine(" do NOT exit the program");

                                    break;
                            }//swtich

                        } //while

                        break;//paitent sub menu


                    // Doctor Management Sub - Menu

                    case 2:
                        while (true)

                        {

                            Console.Clear();
                            Console.WriteLine("Doctor Management");
                            Console.WriteLine("1)Add New Doctor ");
                            Console.WriteLine("2)Display All Doctors");
                            Console.WriteLine("3)Update Consultation Fee");
                            Console.WriteLine("4)Delete Doctor");
                            Console.WriteLine("0. Back to Main Menu");

                            Console.WriteLine("Enter Your  choice:  ");

                            int doctor_choice = Convert.ToInt32(Console.ReadLine());

                            switch (doctor_choice)
                            {


                                case 1:
                                    Console.WriteLine("1)Add New Doctor ");
                                    break;

                                case 2:
                                    Console.WriteLine("2)Display All Doctors");
                                    break;

                                case 3:
                                    Console.WriteLine("3)Update Consultation Fee");
                                    break;

                                case 4:
                                    Console.WriteLine("4)Delete Doctor");
                                    break;
                                case 0:
                                    Console.WriteLine("0. Back to Main Menu");
                                    break;
                                default:
                                    Console.WriteLine(" do NOT exit the program");
                                    break;

                            }//switch

                        }//while
                        break;//doctor sub menu



                    // Appointment Management Sub - Menu

                    case 3:
                        while (true)

                        {
                            Console.Clear();
                            Console.WriteLine("1)Book New Appointment");
                            Console.WriteLine("2)Display All Appointments");
                            Console.WriteLine("3)Update Appointment Status");
                            Console.WriteLine("4)Cancel Appointment");
                            Console.WriteLine("0)Back to Main Menu");

                            Console.WriteLine("Enter Your  choice:  ");

                            int APPOINTMENT_choice = Convert.ToInt32(Console.ReadLine());

                            switch (APPOINTMENT_choice)
                            {

                                case 1:
                                    Console.WriteLine("1)Book New Appointment");
                                    break;

                                case 2:
                                    Console.WriteLine("2)Display All Appointments");
                                    break;

                                case 3:
                                    Console.WriteLine("3)Update Appointment Status");
                                    break;

                                case 4:
                                    Console.WriteLine("4)Cancel Appointment");
                                    break;

                                case 0:
                                    Console.WriteLine("0)Back to Main Menu");

                                    break;

                                default:
                                    Console.WriteLine(" do NOT exit the program");

                                    break;

                            }//switch
                        }//while

                        break;// APPOINTMENT sub menu


                    case 0:

                        Console.WriteLine("0) Exit");

                        break;

                    default:

                        Console.WriteLine(" do NOT exit the program");

                        break;

                }//main switch

            }//main while

















        }
    }
}
