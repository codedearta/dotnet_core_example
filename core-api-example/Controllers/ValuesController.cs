using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mvc_api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public async Task<dynamic> Get()
        {
            return await Task.Run(() => System.Net.HttpWebRequest.Create("https://zuehlke.com").GetResponseAsync());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public dynamic Get(int id)
        {
            return System.Net.HttpWebRequest.Create("https://zuehlke.com").GetResponseAsync().Result;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
