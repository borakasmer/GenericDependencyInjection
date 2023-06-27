namespace InterestingDependencyInjection.Analyze
{
    using System.Collections.Generic;

    public class ServiceResult
    {
        public ResultStatus Status { get; set; }
        public string Message { get; set; }
        public List<string> ValidationMessages { get; set; } = new List<string>();
        public bool IsSuccess { get; set; }
    }

    public class ServiceResult<T> : ServiceResult where T : class
    {
        public T Data { get; set; }
    }

    public enum ResultStatus
    {
        Successful,
        Created, 
        Failed,
        BadRequest
    }

    public class IdAnalize
    {
        public string AnalizeId { get; set; } = string.Empty;
    }
}
