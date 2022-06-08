using System;
using Adapter.ExternalSystem.DTOs;

namespace Adapter.ExternalSystem
{
    // This class imitate external lib/system 
    // The Adaptee contains some useful behavior, but its interface is
    // incompatible with the existing client code. The Adaptee needs some
    // adaptation before the client code can use it.
    public class ReportingApi
    {
        public ReportDto GetFullReport(Guid reportId)
        {
            // some logic 

            return new ReportDto
            {
                Id = new Guid(),
                Title = "News",
                Details = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, " +
                    "consectetur, adipisci velit"
            };
        }
    }
}