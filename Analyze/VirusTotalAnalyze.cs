using System.Dynamic;

namespace InterestingDependencyInjection.Analyze
{
    public class VirusTotalAnalyze : IAnalyze
    {
        public ServiceResult<ExpandoObject> Create<T>(T request) where T : BaseServiceRequest
        {
            //Create Analize Operation
            var serviceRequest = request as VirusTotalRequest;            
            Console.WriteLine($"Create VirusTotalAnalyze Analyze {serviceRequest.VirusTotalId}");
            return new ServiceResult<ExpandoObject>() { IsSuccess = true };
        }

        public ServiceResult<IdAnalize> Delete(string analizeId)
        {
            //Delete Analize Operation
            Console.WriteLine("Delete VirusTotalAnalyze Analyze");
            return new ServiceResult<IdAnalize>();
        }

        public ServiceResult<IdAnalize> Get(string analizeId)
        {
            //Get Analize Operation
            Console.WriteLine("Get VirusTotalAnalyze Analyze");
            return new ServiceResult<IdAnalize>();
        }

        public ServiceResult<ExpandoObject> Update<T1>(T1 request) where T1 : BaseServiceRequest
        {
            //Update Analize Operation
            var serviceRequest = request as VirusTotalRequest;
            Console.WriteLine($"Update VirusTotalAnalyze Analyze {serviceRequest.VirusTotalId}");
            return new ServiceResult<ExpandoObject>() { IsSuccess = true };
        }
    }
}
