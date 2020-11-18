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
	public class EsignalssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Esignals> lEsignalss = await db.Esignals.GetAllCompanyEsignalss(id);
				 //return JsonConvert.SerializeObject(lEsignalss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Esignals esignals)
			{
				 //Create
				 db.Esignals.Add(esignals);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(esignals);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Esignals esignals)
			{
				 //Update
				 db.Esignals.Update(esignals);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Esignals esignals)
			{
				 db.Esignals.Remove(esignals);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
