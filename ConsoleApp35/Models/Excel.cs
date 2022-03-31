using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp35.Models
{
    class Excel:Iprintable
    {
        public string FileName { get; set; }
        public int ColumnCount { get; set; }
        public int RowCount { get; set; }
        
        public Excel(string filename,int columncount,int rowcount)
        {
            FileName = filename;
            ColumnCount = columncount;
            RowCount = rowcount;
        }

        public void Print()
        {
            Console.WriteLine($"filename:{FileName},columncount:{ColumnCount},rowcount:{RowCount}");
        }
    }
}
