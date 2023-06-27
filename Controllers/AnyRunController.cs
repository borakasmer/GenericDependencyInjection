using InterestingDependencyInjection.Analyze;
using Microsoft.AspNetCore.Mvc;

namespace InterestingDependencyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnyRunController : ControllerBase
    {
        readonly IAnalyzeAdaptor<AnyRunAnalyze> _analyzeAdaptor;
        public AnyRunController(IAnalyzeAdaptor<AnyRunAnalyze> analyzeAdaptor)
        {
            _analyzeAdaptor = analyzeAdaptor;
        }

        [HttpPost]
        [Route("create")]
        public bool CreateAnalyze(AnyRunRequest request)
        {
            var result = _analyzeAdaptor.Create(request);
            return result.IsSuccess;
        }
        [HttpPost]
        [Route("delete")]
        public bool UpdateAnalyze(AnyRunRequest updateRequest)
        {
            var result = _analyzeAdaptor.Update(updateRequest);
            return result.IsSuccess;
        }
    }
}