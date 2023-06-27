using System.Dynamic;

namespace InterestingDependencyInjection.Analyze
{
    public interface IAnalyze
    {
       
        ServiceResult<ExpandoObject> Create<T>(T request) where T : BaseServiceRequest;
        ServiceResult<ExpandoObject> Update<T1>(T1 request) where T1 : BaseServiceRequest;
        ServiceResult<IdAnalize> Delete(string analizeId);
        ServiceResult<IdAnalize> Get(string analizeId);
    }
}
