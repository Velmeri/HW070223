using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW070223
{
    internal class Journal
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Journal(string name, int year, string description, string phoneNumber, string email)
        {
            Name = name;
            Year = year;
            Description = description;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
