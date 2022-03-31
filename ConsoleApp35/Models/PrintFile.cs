using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp35.Models
{
    class PrintFile<T>
        where T:Iprintable
    {
        public void Print(T file)
        {
            file.Print();
        }
    }
}
