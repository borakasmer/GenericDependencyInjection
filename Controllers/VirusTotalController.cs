using InterestingDependencyInjection.Analyze;
using Microsoft.AspNetCore.Mvc;

namespace InterestingDependencyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VirusTotalController : ControllerBase
    {
        readonly IAnalyzeAdaptor<VirusTotalAnalyze> _analyzeAdaptor;
        public VirusTotalController(IAnalyzeAdaptor<VirusTotalAnalyze> analyzeAdaptor)
        {
            _analyzeAdaptor = analyzeAdaptor;
        }

        [HttpPost]
        [Route("create")]
        public bool CreateAnalyze(VirusTotalRequest request)
        {
            var result = _analyzeAdaptor.Create(request);
            return result.IsSuccess;
        }
        [HttpPost]
        [Route("delete")]
        public bool UpdateAnalyze(VirusTotalRequest updateRequest)
        {
            var result = _analyzeAdaptor.Update(updateRequest);
            return result.IsSuccess;
        }
    }
}