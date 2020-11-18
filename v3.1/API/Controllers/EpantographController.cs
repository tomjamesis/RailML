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
	public class EpantographsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Epantograph> lEpantographs = await db.Epantograph.GetAllCompanyEpantographs(id);
				 //return JsonConvert.SerializeObject(lEpantographs.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Epantograph epantograph)
			{
				 //Create
				 db.Epantograph.Add(epantograph);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(epantograph);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Epantograph epantograph)
			{
				 //Update
				 db.Epantograph.Update(epantograph);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Epantograph epantograph)
			{
				 db.Epantograph.Remove(epantograph);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
