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
	public class EtransformersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Etransformer> lEtransformers = await db.Etransformer.GetAllCompanyEtransformers(id);
				 //return JsonConvert.SerializeObject(lEtransformers.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Etransformer etransformer)
			{
				 //Create
				 db.Etransformer.Add(etransformer);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etransformer);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Etransformer etransformer)
			{
				 //Update
				 db.Etransformer.Update(etransformer);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Etransformer etransformer)
			{
				 db.Etransformer.Remove(etransformer);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
