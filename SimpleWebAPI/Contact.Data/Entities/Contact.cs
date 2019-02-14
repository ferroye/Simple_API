using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Data.Entities
{
    public class Contact
    {
        public string contactName { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public int zipcode { get; set; }
    }
}
