using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArea.Models
{
    public class Triangle
    {
        public int Cote1 { get; set; }
        public int Cote2 { get; set; }
        public int Cote3 { get; set; }

        public Triangle(int cote1, int cote2, int cote3)
        {
            Cote1 = cote1;
            Cote2 = cote2;
            Cote3 = cote3;
        }
    }
}
