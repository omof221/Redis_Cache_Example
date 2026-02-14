using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace InnMemoryCaching.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        readonly IMemoryCache _memoryCache;

        public ValueController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        [HttpGet("set/{name}")]
        public void Set(string name)
        {
            _memoryCache.Set("key", "name", TimeSpan.FromSeconds(30));

        }
        [HttpGet]

        public string Get()
        {
            if (!_memoryCache.TryGetValue("key", out string value))
            {
                return _memoryCache.Get<string>("key");
            }
            return "";
        }
    }
}
