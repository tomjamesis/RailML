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
	public class TmaxTrainCurrentValidForsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TmaxTrainCurrentValidFor> lTmaxTrainCurrentValidFors = await db.TmaxTrainCurrentValidFor.GetAllCompanyTmaxTrainCurrentValidFors(id);
				 //return JsonConvert.SerializeObject(lTmaxTrainCurrentValidFors.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TmaxTrainCurrentValidFor tmaxtraincurrentvalidfor)
			{
				 //Create
				 db.TmaxTrainCurrentValidFor.Add(tmaxtraincurrentvalidfor);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tmaxtraincurrentvalidfor);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TmaxTrainCurrentValidFor tmaxtraincurrentvalidfor)
			{
				 //Update
				 db.TmaxTrainCurrentValidFor.Update(tmaxtraincurrentvalidfor);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TmaxTrainCurrentValidFor tmaxtraincurrentvalidfor)
			{
				 db.TmaxTrainCurrentValidFor.Remove(tmaxtraincurrentvalidfor);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
