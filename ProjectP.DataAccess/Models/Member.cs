using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectP.DataAccess.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string PhoneNumber { get; set; }
        public string VkProfileUrl { get; set; }
        public string TelegramProfileUrl { get; set; }
        public string EducationalInstitution { get; set; }
        public string Workplace { get; set; }
    }
}
