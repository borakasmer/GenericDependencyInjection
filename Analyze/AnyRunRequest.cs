namespace InterestingDependencyInjection.Analyze
{
    public class AnyRunRequest: BaseServiceRequest
    {        
        public int AnyRunId { get; set; }
        public int ScheduleTypeId { get; set; }
        public DateTime? ScheduledDate { get; set; }
        public int Duration { get; set; }
        public byte[] Data { get; set; }
    }
}
