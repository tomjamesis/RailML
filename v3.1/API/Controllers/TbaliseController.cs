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
	public class TbalisesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tbalise> lTbalises = await db.Tbalise.GetAllCompanyTbalises(id);
				 //return JsonConvert.SerializeObject(lTbalises.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tbalise tbalise)
			{
				 //Create
				 db.Tbalise.Add(tbalise);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tbalise);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tbalise tbalise)
			{
				 //Update
				 db.Tbalise.Update(tbalise);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tbalise tbalise)
			{
				 db.Tbalise.Remove(tbalise);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
