using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp35.Models
{
    class Word : Iprintable
    {
        public string FileName { get; set; }
        public int WordCount { get; set; }
        public Word(string filename,int wordcount)
        {
            FileName = filename;
            WordCount = wordcount;
        }
        public void Print()
        {
            Console.WriteLine($"filename: {FileName}, wordcount:{WordCount}");
        }
    }
}
