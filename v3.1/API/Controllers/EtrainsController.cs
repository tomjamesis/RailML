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
	public class EtrainssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Etrains> lEtrainss = await db.Etrains.GetAllCompanyEtrainss(id);
				 //return JsonConvert.SerializeObject(lEtrainss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Etrains etrains)
			{
				 //Create
				 db.Etrains.Add(etrains);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etrains);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Etrains etrains)
			{
				 //Update
				 db.Etrains.Update(etrains);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Etrains etrains)
			{
				 db.Etrains.Remove(etrains);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
