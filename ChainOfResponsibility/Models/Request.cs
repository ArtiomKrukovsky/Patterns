using System.Diagnostics.CodeAnalysis;

namespace ChainOfResponsibility.Models
{
    // Request class
    public class Request
    {
        public required string Context { get; set; }

        [SetsRequiredMembers]
        public Request(string context)
        {
            Context = context;
        }
    }
}
