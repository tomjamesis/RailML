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
	public class EstopPostssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EstopPosts> lEstopPostss = await db.EstopPosts.GetAllCompanyEstopPostss(id);
				 //return JsonConvert.SerializeObject(lEstopPostss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EstopPosts estopposts)
			{
				 //Create
				 db.EstopPosts.Add(estopposts);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(estopposts);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EstopPosts estopposts)
			{
				 //Update
				 db.EstopPosts.Update(estopposts);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EstopPosts estopposts)
			{
				 db.EstopPosts.Remove(estopposts);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
