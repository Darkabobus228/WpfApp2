using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    public class Inventory
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }
        public double Prise { get; set; }
        public bool IsAvailable { get; set; }
        public int Discount { get; set; }
        public Company? Company { get; set; }
    }
}
