using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarleyStonearrowAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Future upgrades = attempt to utilize Dictionary(int, List<string>)
            // Dictionary(Student ID, Student info in a list)
            // Declare lists of all student values
            List<string> studentIDs = new List<string>();
            List<string> studentNames = new List<string>();
            List<string> studentEmails = new List<string>();
            List<string> phoneNumbers = new List<string>();
            List<string> studentMajors = new List<string>();
            List<string> startDates = new List<string>();
            List<string> estGradDates = new List<string>();
            List<string> mailAddresses = new List<string>();
            List<string> states = new List<string>();
            List<string> countries = new List<string>();
            List<bool> enableHidden = new List<bool>();
            List<string> activityLog = new List<string>();
            // Declare local variables 
            string name, major, email, phoneNumber, hiddenInput, startDate, estGradDate,
                mailAddress, state, country, log = "";
            bool hidden;
            int entries;

            // Ask user how many entries to input for loop
            Console.WriteLine("How many entries do you wish to enter?");
            entries = int.Parse(Console.ReadLine());

            // Loop through user creation
            for(int i = 0; i < entries; i++)
            {
                Console.WriteLine("Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Major: ");
                major = Console.ReadLine();
                Console.WriteLine("Email: ");
                email = Console.ReadLine();
                Console.WriteLine("Phone Numbers: ");
                phoneNumber = Console.ReadLine();
                Console.WriteLine("Start Date: (MM/DD/YYYY)");
                startDate = Console.ReadLine();
                Console.WriteLine("Anticipated Graduation Date: (MM/DD/YYYY)");
                estGradDate = Console.ReadLine();
                Console.WriteLine("Mailing Address: ");
                mailAddress = Console.ReadLine();
                Console.WriteLine("State/Province/Territory: ");
                state = Console.ReadLine();
                Console.WriteLine("Country: ");
                country = Console.ReadLine();
                Console.WriteLine("Enable hidden? Y/N: ");
                hiddenInput = Console.ReadLine();
                if (hiddenInput == "Y" || hiddenInput == "y")
                {
                    hidden = true;
                }
                else
                {
                    hidden = false;
                }
                Console.WriteLine(" ");

                // Send values to newStudent (Student.cs)
                Student newStudent = new Student(i+1, name, email, phoneNumber, major, startDate, estGradDate, 
                    mailAddress, state, country, hidden, log);
                // Add values to lists
                studentIDs.Add(newStudent.studentID.ToString());
                studentNames.Add(newStudent.Name);
                studentMajors.Add(newStudent.Major);
                studentEmails.Add(newStudent.Email);
                phoneNumbers.Add(newStudent.PhoneNumber);
                startDates.Add(newStudent.StartDate);
                estGradDates.Add(newStudent.EstGradDate);
                mailAddresses.Add(newStudent.MailAddress);
                states.Add(newStudent.State);
                countries.Add(newStudent.Country);
                enableHidden.Add(newStudent.hidden);
                activityLog.Add(newStudent.log);
            }
            
            // Loop through the number of ID's (# of students) and output a formatted output
            for (int i = 0; i < studentIDs.Count; i++)
            {
                Console.WriteLine($"ID: \t\t\t\t{studentIDs[i]}");
                Console.WriteLine($"Name: \t\t\t\t{studentNames[i]}");
                Console.WriteLine($"Email: \t\t\t\t{studentEmails[i]}");
                // if the hidden value is set to false, display the below info
                if (enableHidden[i] != true)
                {
                    Console.WriteLine($"Phone Number: \t\t{phoneNumbers[i]}");
                    Console.WriteLine($"Major: \t\t\t\t{studentMajors[i]}");
                    Console.WriteLine($"Start Date: \t\t\t{startDates[i]}");
                    Console.WriteLine($"Est. Graduation Date: \t\t{estGradDates[i]}");
                    Console.WriteLine($"Mailing Address: \t\t{mailAddresses[i]}");
                    Console.WriteLine($"State/Territory/Province: \t{states[i]}");
                    Console.WriteLine($"Country: \t\t\t{countries[i]}");
                }
                // separate user output
                Console.WriteLine(" ");
            }
            // format an activity log
            Console.WriteLine($"Activity Log");
            Console.WriteLine("------------");
            // loop through number of students and output activity log list
            for(int i = 0; i < studentIDs.Count; i++)
            {
                Console.WriteLine(activityLog[i]);
            }
            Console.ReadLine();
        }
    }
}