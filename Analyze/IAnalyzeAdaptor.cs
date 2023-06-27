using System.Dynamic;

namespace InterestingDependencyInjection.Analyze
{
    public interface IAnalyzeAdaptor<T> where T : IAnalyze
    {
        ServiceResult<ExpandoObject> Create<T1>(T1 request) where T1 : BaseServiceRequest;
        ServiceResult<ExpandoObject> Update<T1>(T1 request) where T1 : BaseServiceRequest;
        ServiceResult<IdAnalize> Delete(string analizeId);
        ServiceResult<IdAnalize> Get(string analizeId);
    }
}
