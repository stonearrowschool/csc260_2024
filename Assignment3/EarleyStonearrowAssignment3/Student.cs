using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EarleyStonearrowAssignment3
{
    internal class Student
    {
        // Declare variables, including a readonly
        public readonly int studentID;
        public string name, major, startDate, estGradDate, mailAddress, state, country, 
            email, phoneNumber, log;
        public bool hidden;

        // Parameterized Constructor
        public Student(int pStudentID, string pName, string pEmail, string pPhoneNumber, 
            string pMajor, string pStartDate, string pEstGradDate, string pMailAddress, 
            string pState,  string pCountry, bool pHidden, string pLog)
        {
            studentID = pStudentID;
            hidden = pHidden;
            log = pLog;
            Name = pName;
            Email = pEmail;
            PhoneNumber = pPhoneNumber;
            Major = pMajor;
            StartDate = pStartDate;
            EstGradDate = pEstGradDate;
            MailAddress = pMailAddress;
            State = pState;
            Country = pCountry;
        }
        // Properties in alphabetical order
        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                log += $"Country of {country} added to {name}\n";
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                log += $"Email of {email} added to {name}\n";
            }
        }

        public string EstGradDate
        {
            get
            {
                return estGradDate;
            }
            set
            {
                // Check date/time format is matching one of these patterns
                var formats = new[] { "M/d/yyyy", "M/dd/yyyy", "MM/d/yyyy", "MM/dd/yyyy" };
                DateTime dt;
                if (DateTime.TryParseExact(value, formats, null, DateTimeStyles.None, out dt))
                {
                    estGradDate = value;
                    log += $"Est. Graduation Date of {estGradDate} added to {name}\n";
                }
                else
                {
                    estGradDate = null;
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                log += $"Name of {name} added to Student ID {studentID}\n";
            }

        }
        
        public string MailAddress
        {
            get
            {
                return mailAddress;
            }
            set
            {
                mailAddress = value;
                log += $"Mailing Address of {mailAddress} added to {name}\n";
            }
        }
        public string Major
        {
            get
            {
                return major;
            }
            set
            {
                major = value;
                log += $"Major of {major} added to {name}\n";
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                // set phone regex pattern
                string pattern = @"[0-9]{10}";
                // strip out common special characters used in phone numbers to get just digits
                string strippedVal = value.Replace("-", "");
                strippedVal = strippedVal.Replace("(", "");
                strippedVal = strippedVal.Replace(")", "");
                strippedVal = strippedVal.Replace(".", "");
                strippedVal = strippedVal.Replace(" ", "");

                //match the just digits to the regex
                Match match = Regex.Match(strippedVal, pattern, RegexOptions.IgnoreCase);
                if (match.Success && strippedVal.Length < 11)
                {
                    phoneNumber = value;
                    log += $"Phone Number of {phoneNumber} added to {name}\n";
                }
                else
                {
                    phoneNumber = null;
                }
            }
        }

        public string StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                // Check date/time format is matching one of these patterns
                var formats = new[] { "M/d/yyyy", "M/dd/yyyy", "MM/d/yyyy", "MM/dd/yyyy" };
                DateTime dt;
                if (DateTime.TryParseExact(value, formats, null, DateTimeStyles.None, out dt))
                {
                    startDate = value;
                    log += $"Start Date of {startDate} added to {name}\n";
                }
                else
                {
                    startDate = null;
                }
            }
        }

        public string State
        {
            get { return state; }
            set
            {
                state = value;
                log += $"State of {state} added to {name}\n";
            }
        }
    }
}