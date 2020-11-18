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
	public class TadditionalNamesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TadditionalName> lTadditionalNames = await db.TadditionalName.GetAllCompanyTadditionalNames(id);
				 //return JsonConvert.SerializeObject(lTadditionalNames.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TadditionalName tadditionalname)
			{
				 //Create
				 db.TadditionalName.Add(tadditionalname);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tadditionalname);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TadditionalName tadditionalname)
			{
				 //Update
				 db.TadditionalName.Update(tadditionalname);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TadditionalName tadditionalname)
			{
				 db.TadditionalName.Remove(tadditionalname);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
