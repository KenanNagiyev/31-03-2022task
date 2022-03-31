using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp35.Models
{
    class Pdf : Iprintable
    {
        public string FileName { get; set; }
        public int PageCount { get; set; }

        public Pdf(string filename, int pagecount)
        {
            FileName = filename;
            PageCount = pagecount;
        }

        public void Print()
        {
            Console.WriteLine($"filename:{FileName},pagecount:{PageCount}");
        }
    }
}
