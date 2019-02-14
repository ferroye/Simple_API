using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Data.Dtos
{
    public class ContactDto
    {
        public string contactName { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public int zipcode { get; set; }
        public string contactNote { get; set; }
    }
}
