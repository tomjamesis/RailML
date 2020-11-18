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
	public class EelectrificationChangessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EelectrificationChanges> lEelectrificationChangess = await db.EelectrificationChanges.GetAllCompanyEelectrificationChangess(id);
				 //return JsonConvert.SerializeObject(lEelectrificationChangess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EelectrificationChanges eelectrificationchanges)
			{
				 //Create
				 db.EelectrificationChanges.Add(eelectrificationchanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eelectrificationchanges);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EelectrificationChanges eelectrificationchanges)
			{
				 //Update
				 db.EelectrificationChanges.Update(eelectrificationchanges);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EelectrificationChanges eelectrificationchanges)
			{
				 db.EelectrificationChanges.Remove(eelectrificationchanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
