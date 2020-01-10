using System;

namespace StateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new Document();
            doc.Approve();
            doc.Title = "aaa";
            doc.Archive();
            Console.WriteLine(doc.Validate());
        }
    }
}
