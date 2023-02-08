using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHomework
{
    internal class InternationalPasport
    {
        string user_fullname;
        string passport_number;
        ushort issue_day;
        ushort issue_month;
        ushort issue_year;


        public InternationalPasport(string user_fullname, string passport_number, ushort issue_day, ushort issue_month, ushort issue_year)
        {


            this.user_fullname = user_fullname;

            if (passport_number.All(char.IsDigit) != true)
                throw new Exception("Passport number contains non-digit characters");
            else
                this.passport_number = passport_number;

            if (issue_year > DateTime.Now.Year)
                throw new Exception("Time Travel is not allowed");
            else
                this.issue_year = issue_year;
            

            if (issue_month > 12 || issue_month < 0)
                throw new Exception("Wrong issue month value");
            else if (issue_year == DateTime.Now.Year && issue_month > DateTime.Now.Month)
                throw new Exception("Time Travel is not allowed, not too far, though");
            else
                this.issue_month = issue_month;


            if (issue_day > DaysInMonth() || issue_day < 0)
                throw new Exception("Wrong issue day value");
            else
                this.issue_day = issue_day;
        }

        bool IsLeap()
        {
            if (issue_year % 4 == 0) return true;
            return false;
        }

        short DaysInMonth()
        {
            if (issue_month == 1 || issue_month == 3 || issue_month == 5 || issue_month == 7 || issue_month == 8 || issue_month == 10 || issue_month == 12)
            { //Checking months with 31 days
                return 31;
            }
            if (issue_month == 4 || issue_month == 6 || issue_month == 9 || issue_month == 11)
            { //Checking months with 30 days
                return 30;
            }
            if (issue_month == 2)
            {
                if (IsLeap()) return 29; // If Leap, returns 29, otherwise returns 28
                else return 28;
            }
            return -1;

        }
    }
}
