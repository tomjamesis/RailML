using Models.DB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
	[Route("api/[controller]")]
	//[Authorize]
	[ApiController]
	public class TstandardDeviationTimessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TstandardDeviationTimes> lTstandardDeviationTimess = await db.TstandardDeviationTimes.GetAllCompanyTstandardDeviationTimess(id);
				 //return JsonConvert.SerializeObject(lTstandardDeviationTimess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TstandardDeviationTimes tstandarddeviationtimes)
			{
				 //Create
				 db.TstandardDeviationTimes.Add(tstandarddeviationtimes);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tstandarddeviationtimes);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TstandardDeviationTimes tstandarddeviationtimes)
			{
				 //Update
				 db.TstandardDeviationTimes.Update(tstandarddeviationtimes);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TstandardDeviationTimes tstandarddeviationtimes)
			{
				 db.TstandardDeviationTimes.Remove(tstandarddeviationtimes);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
