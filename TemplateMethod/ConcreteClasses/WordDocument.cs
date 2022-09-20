using System;
using TemplateMethod.TemplateClasses;

namespace TemplateMethod.ConcreteClasses
{
    internal class WordDocument : BaseDocument
    {
        protected override void CloseFile()
        {
            Console.WriteLine($"Closing a Word document");
        }

        protected override string ExtractData()
        {
            Console.WriteLine($"Extracting a Word document");
            return "word data";
        }

        protected override void OpenFile()
        {
            Console.WriteLine($"Opening a Word document");
        }
    }
}
