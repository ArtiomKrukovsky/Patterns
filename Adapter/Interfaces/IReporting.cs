using System;
using Adapter.Models;

namespace Adapter.Interfaces
{
    // The Target defines the domain-specific interface used by the client code.
    public interface IReporting
    {
        SpecifiedReport GetSpecifiedReport(Guid reportId);
    }
}