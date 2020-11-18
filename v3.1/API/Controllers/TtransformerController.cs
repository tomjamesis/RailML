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
	public class TtransformersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Ttransformer> lTtransformers = await db.Ttransformer.GetAllCompanyTtransformers(id);
				 //return JsonConvert.SerializeObject(lTtransformers.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Ttransformer ttransformer)
			{
				 //Create
				 db.Ttransformer.Add(ttransformer);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttransformer);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Ttransformer ttransformer)
			{
				 //Update
				 db.Ttransformer.Update(ttransformer);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Ttransformer ttransformer)
			{
				 db.Ttransformer.Remove(ttransformer);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
