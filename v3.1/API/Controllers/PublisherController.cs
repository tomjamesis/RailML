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
	public class PublishersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Publisher> lPublishers = await db.Publisher.GetAllCompanyPublishers(id);
				 //return JsonConvert.SerializeObject(lPublishers.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Publisher publisher)
			{
				 //Create
				 db.Publisher.Add(publisher);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(publisher);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Publisher publisher)
			{
				 //Update
				 db.Publisher.Update(publisher);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Publisher publisher)
			{
				 db.Publisher.Remove(publisher);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
