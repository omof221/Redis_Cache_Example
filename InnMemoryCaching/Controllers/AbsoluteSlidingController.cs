using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace InnMemoryCaching.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbsoluteSlidingController : ControllerBase
    {
        readonly IMemoryCache _memoryCache;

        public AbsoluteSlidingController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }
        [HttpGet("setDate")]
        public void SetDate()
        {
            var cacheEntryOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(30),
                SlidingExpiration = TimeSpan.FromSeconds(5)
            };

            _memoryCache.Set<DateTime>("date", DateTime.Now, cacheEntryOptions);
        }

        [HttpGet("getDate")]
        public DateTime GetDate()
        {
            return _memoryCache.Get<DateTime>("date");
        }

    }
}
