using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MiniProjAPI.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FName { get; set; }
        public string  LName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int Zipcode { get; set; }
        public string Email { get; set; }
    }
}
 