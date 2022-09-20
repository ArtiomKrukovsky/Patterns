using System;
using TemplateMethod.ConcreteClasses;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wordDocument = new WordDocument();
            wordDocument.Process();

            var excelDocument = new ExcelDocument();
            excelDocument.Process();

            Console.ReadLine();
        }
    }
}
