using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.TemplateClasses
{
    public abstract class BaseDocument
    {
        public void Process()
        {
            OpenFile();
            var fileData = ExtractData();
            SendReport(fileData);
            CloseFile();
        }

        protected abstract void OpenFile();
        protected abstract string ExtractData();
        protected abstract void CloseFile();

        protected void SendReport(string fileData)
        {
            Console.WriteLine($"Send a report, file data: {fileData}");
        }
    }
}
