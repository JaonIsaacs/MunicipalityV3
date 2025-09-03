using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityV3.Models
{
    public class IssueReport
    {
        public Guid Id { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public LinkedList<string> Attachments { get; set; }
        public DateTime SubmittedAt { get; set; }
        public string Status { get; set; }

        public IssueReport()
        {
            Id = Guid.NewGuid();
            Attachments = new LinkedList<string>();
            SubmittedAt = DateTime.Now;
            Status = "Pending";
        }

        public override string ToString()
        {
            return $"{Category} @ {Location} ({Status}) - {SubmittedAt:g}";
        }
    }
}
