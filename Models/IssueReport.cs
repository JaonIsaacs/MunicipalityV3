using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityV3.Models
{
    public class IssueReport
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<string> Attachments { get; set; }
        public DateTime SubmittedAt { get; set; }

        public IssueReport()
        {
            Attachments = new List<string>();
            SubmittedAt = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{SubmittedAt:g} | {Category} at {Location}";
        }
    }
}
