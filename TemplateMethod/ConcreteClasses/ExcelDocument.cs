using System;
using TemplateMethod.TemplateClasses;

namespace TemplateMethod.ConcreteClasses
{
    internal class ExcelDocument : BaseDocument
    {
        protected override void CloseFile()
        {
            Console.WriteLine($"Closing a Excel document");
        }

        protected override string ExtractData()
        {
            Console.WriteLine($"Extracting a Excel document");
            return "excel data";
        }

        protected override void OpenFile()
        {
            Console.WriteLine($"Opening a Excel document");
        }
    }
}
