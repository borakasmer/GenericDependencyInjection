using System.Dynamic;

namespace InterestingDependencyInjection.Analyze
{
    public class AnyRunAnalyze : IAnalyze
    {
        public ServiceResult<ExpandoObject> Create<T>(T request) where T : BaseServiceRequest
        {
            //Create Analize Operation
            var serviceRequest = request as AnyRunRequest;
            Console.WriteLine($"Create AnyRun Analyze {serviceRequest.AnyRunId}");        
            return new ServiceResult<ExpandoObject>() { IsSuccess = true };
        }

        public ServiceResult<IdAnalize> Delete(string analizeId)
        {
            //Delete Analize Operation           
            Console.WriteLine("Delete AnyRun Analyze");
            return new ServiceResult<IdAnalize>();
        }

        public ServiceResult<IdAnalize> Get(string analizeId)
        {
            //Get Analize Operation
            Console.WriteLine("Get AnyRun Analyze");
            return new ServiceResult<IdAnalize>();
        }

        public ServiceResult<ExpandoObject> Update<T1>(T1 request) where T1 : BaseServiceRequest
        {
            //Update Analize Operation
            var serviceRequest = request as AnyRunRequest;
            Console.WriteLine($"Update AnyRun Analyze: {serviceRequest.AnyRunId}");
            return new ServiceResult<ExpandoObject>() { IsSuccess = true };
        }
    }
}
