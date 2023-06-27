namespace InterestingDependencyInjection.Analyze
{
    public class VirusTotalRequest : BaseServiceRequest
    {
        public int VirusTotalId { get; set; }
        public int RepatCount { get; set; }
        public bool isAttachmentInclude { get; set; }
        public byte[] Data { get; set; }
    }
}
