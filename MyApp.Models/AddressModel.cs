using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class AddressModel
    {
        public int Id { get; set; }
        public byte[] Details { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
