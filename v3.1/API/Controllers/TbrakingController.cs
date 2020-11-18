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
	public class TbrakingsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tbraking> lTbrakings = await db.Tbraking.GetAllCompanyTbrakings(id);
				 //return JsonConvert.SerializeObject(lTbrakings.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tbraking tbraking)
			{
				 //Create
				 db.Tbraking.Add(tbraking);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tbraking);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tbraking tbraking)
			{
				 //Update
				 db.Tbraking.Update(tbraking);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tbraking tbraking)
			{
				 db.Tbraking.Remove(tbraking);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
