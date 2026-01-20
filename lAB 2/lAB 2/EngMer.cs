using System;
using System.Collections.Generic;
using System.Text;

namespace lAB_2
{
    public class EngMer
    {
        public double Funt {get; set; }
        public double Inch { get; set; }
        public double Multiplication()
        {
            return Funt * Inch;
        }
        public double Complicated()
        {
            return Funt + Inch;
        }
        public double subtraction()
        {
            return Inch - Funt;
        }
        public double Division()
        {
            return Inch / Funt;
        }
        public string Comparison()
        {
            if (Funt < Inch)
                return "Дюймов больше";
            else if (Funt > Inch)
                return "Фунтов больше";
            else
                return "Они равны";
        }
    }
}
