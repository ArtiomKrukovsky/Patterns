using System;
using Adapter.Adapters;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var reportId = Guid.NewGuid();
            var adapter = new ReportingAdapter();

            var report = adapter.GetSpecifiedReport(reportId);

            Console.WriteLine(report);
        }
    }
}
