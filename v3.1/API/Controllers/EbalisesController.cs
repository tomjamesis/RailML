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
	public class EbalisessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Ebalises> lEbalisess = await db.Ebalises.GetAllCompanyEbalisess(id);
				 //return JsonConvert.SerializeObject(lEbalisess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Ebalises ebalises)
			{
				 //Create
				 db.Ebalises.Add(ebalises);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ebalises);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Ebalises ebalises)
			{
				 //Update
				 db.Ebalises.Update(ebalises);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Ebalises ebalises)
			{
				 db.Ebalises.Remove(ebalises);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
