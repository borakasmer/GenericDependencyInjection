using System.Dynamic;

namespace InterestingDependencyInjection.Analyze
{
    public class AnalyzeAdaptor<T> : IAnalyzeAdaptor<T> where T : IAnalyze
    {
        readonly T _analyze;

        public AnalyzeAdaptor(T analyze)
        {
            _analyze = analyze;
        }
        public ServiceResult<ExpandoObject> Create<T1>(T1 request) where T1 : BaseServiceRequest
        {
            return _analyze.Create(request);
        }

        public ServiceResult<IdAnalize> Delete(string analizeId)
        {
            return _analyze.Delete(analizeId);
        }

        public ServiceResult<IdAnalize> Get(string analizeId)
        {
            return _analyze.Get(analizeId);
        }

        public ServiceResult<ExpandoObject> Update<T1>(T1 request) where T1 : BaseServiceRequest
        {
            return _analyze.Update(request);
        }
    }
}
