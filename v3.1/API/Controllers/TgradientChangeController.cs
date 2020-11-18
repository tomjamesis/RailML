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
	public class TgradientChangesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TgradientChange> lTgradientChanges = await db.TgradientChange.GetAllCompanyTgradientChanges(id);
				 //return JsonConvert.SerializeObject(lTgradientChanges.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TgradientChange tgradientchange)
			{
				 //Create
				 db.TgradientChange.Add(tgradientchange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tgradientchange);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TgradientChange tgradientchange)
			{
				 //Update
				 db.TgradientChange.Update(tgradientchange);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TgradientChange tgradientchange)
			{
				 db.TgradientChange.Remove(tgradientchange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
