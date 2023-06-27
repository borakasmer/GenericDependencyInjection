namespace InterestingDependencyInjection.Analyze
{
    public class BaseServiceRequest
    {
        public string Name { get; set; }
        public int SendingLimit { get; set; }
        public bool ExcludeFromReports { get; set; }
    }
}
