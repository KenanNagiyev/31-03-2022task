using System;
using ConsoleApp35.Models;
namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            Excel exc = new Excel("Excel", 8, 10);
            Word w = new Word("Word", 7);
            Pdf p = new Pdf("Pdf", 32);

            PrintFile<Excel> printExc = new PrintFile<Excel>();
            PrintFile<Word> printW = new PrintFile<Word>();
            PrintFile<Pdf> printP = new PrintFile<Pdf>();

            printExc.Print(exc);
            printW.Print(w);
            printP.Print(p);
        }
    }
}
