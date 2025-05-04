using Core.Entities;

namespace Entities
{
    public class Blacklist : BaseEntity<Guid>
    {
        public Guid ApplicantId { get; set; }
        public string Reason { get; set; }
        public DateTime Date { get; set; }

        public virtual Applicant? Applicant { get; set; }

        public Blacklist()
        {
            //
        }

        public Blacklist(Guid applicantId, string reason, DateTime date)
        {
            ApplicantId = applicantId;
            Reason = reason;
            Date = date;
        }
    }
}
