using System;
using Adapter.ExternalSystem;
using Adapter.Interfaces;
using Adapter.Models;

namespace Adapter.Adapters
{
    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
    public class ReportingAdapter : IReporting
    {
        private readonly ReportingApi _reportingApi;

        public ReportingAdapter()
        {
            _reportingApi = new ReportingApi();
        }

        public SpecifiedReport GetSpecifiedReport(Guid reportId)
        {
            var report = _reportingApi.GetFullReport(reportId);

            if (report == null)
            {
                throw new ArgumentNullException($"Report information for id '{reportId}', can't be null");
            }

            return new SpecifiedReport
            {
                Title = report.Title,
                Details = report.Details
            };
        }
    }
}