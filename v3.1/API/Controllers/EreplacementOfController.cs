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
	public class EreplacementOfsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EreplacementOf> lEreplacementOfs = await db.EreplacementOf.GetAllCompanyEreplacementOfs(id);
				 //return JsonConvert.SerializeObject(lEreplacementOfs.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EreplacementOf ereplacementof)
			{
				 //Create
				 db.EreplacementOf.Add(ereplacementof);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ereplacementof);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EreplacementOf ereplacementof)
			{
				 //Update
				 db.EreplacementOf.Update(ereplacementof);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EreplacementOf ereplacementof)
			{
				 db.EreplacementOf.Remove(ereplacementof);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
