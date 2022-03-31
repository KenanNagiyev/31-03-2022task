using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp35.Models
{
    interface Iprintable
    {
        public string FileName { get; set; }

        public void Print();
    }
}
