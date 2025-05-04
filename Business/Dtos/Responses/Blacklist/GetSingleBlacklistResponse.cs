namespace Business.Dtos.Responses.Blacklist
{
    public class GetSingleBlacklistResponse
    {
        public Guid ApplicantId { get; set; }
        public string Reason { get; set; }
        public DateTime Date { get; set; }
    }
}
