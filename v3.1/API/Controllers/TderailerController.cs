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
	public class TderailersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tderailer> lTderailers = await db.Tderailer.GetAllCompanyTderailers(id);
				 //return JsonConvert.SerializeObject(lTderailers.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tderailer tderailer)
			{
				 //Create
				 db.Tderailer.Add(tderailer);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tderailer);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tderailer tderailer)
			{
				 //Update
				 db.Tderailer.Update(tderailer);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tderailer tderailer)
			{
				 db.Tderailer.Remove(tderailer);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
