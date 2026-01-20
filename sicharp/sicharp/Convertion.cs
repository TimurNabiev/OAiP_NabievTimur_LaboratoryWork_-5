using System;
using System.Collections.Generic;
using System.Text;

namespace sicharp { 
    public class Convertion
{
            public int Time { get; set; }
            public int Price {  get; set; }
            public int cost()
            {
                return Price * Time;
            }
    }
}
