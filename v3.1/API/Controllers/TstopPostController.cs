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
	public class TstopPostsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TstopPost> lTstopPosts = await db.TstopPost.GetAllCompanyTstopPosts(id);
				 //return JsonConvert.SerializeObject(lTstopPosts.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TstopPost tstoppost)
			{
				 //Create
				 db.TstopPost.Add(tstoppost);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tstoppost);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TstopPost tstoppost)
			{
				 //Update
				 db.TstopPost.Update(tstoppost);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TstopPost tstoppost)
			{
				 db.TstopPost.Remove(tstoppost);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
