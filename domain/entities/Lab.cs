using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.entities
{
    public class Lab
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string materials { get; set; }
        public byte[] exercises { get; set; }
        
    }
}
