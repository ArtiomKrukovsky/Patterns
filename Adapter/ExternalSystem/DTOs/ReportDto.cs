using System;

namespace Adapter.ExternalSystem.DTOs
{
    public class ReportDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime CreatedDtm { get; set; }
    }
}