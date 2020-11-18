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
	public class TmetadatasController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tmetadata> lTmetadatas = await db.Tmetadata.GetAllCompanyTmetadatas(id);
				 //return JsonConvert.SerializeObject(lTmetadatas.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tmetadata tmetadata)
			{
				 //Create
				 db.Tmetadata.Add(tmetadata);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tmetadata);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tmetadata tmetadata)
			{
				 //Update
				 db.Tmetadata.Update(tmetadata);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tmetadata tmetadata)
			{
				 db.Tmetadata.Remove(tmetadata);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
