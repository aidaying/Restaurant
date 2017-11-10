using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class Member
    {
        public int Id { get; set; }
        public String Username { get; set; }
        public int Mobile { get; set; }
        public String Email { get; set; }
        public String Street { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public int PostCode { get; set; }
    }
}
