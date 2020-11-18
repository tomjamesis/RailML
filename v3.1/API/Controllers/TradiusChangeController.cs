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
	public class TradiusChangesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TradiusChange> lTradiusChanges = await db.TradiusChange.GetAllCompanyTradiusChanges(id);
				 //return JsonConvert.SerializeObject(lTradiusChanges.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TradiusChange tradiuschange)
			{
				 //Create
				 db.TradiusChange.Add(tradiuschange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tradiuschange);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TradiusChange tradiuschange)
			{
				 //Update
				 db.TradiusChange.Update(tradiuschange);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TradiusChange tradiuschange)
			{
				 db.TradiusChange.Remove(tradiuschange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
