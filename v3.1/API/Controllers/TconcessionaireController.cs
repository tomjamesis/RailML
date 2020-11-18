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
	public class TconcessionairesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tconcessionaire> lTconcessionaires = await db.Tconcessionaire.GetAllCompanyTconcessionaires(id);
				 //return JsonConvert.SerializeObject(lTconcessionaires.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tconcessionaire tconcessionaire)
			{
				 //Create
				 db.Tconcessionaire.Add(tconcessionaire);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tconcessionaire);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tconcessionaire tconcessionaire)
			{
				 //Update
				 db.Tconcessionaire.Update(tconcessionaire);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tconcessionaire tconcessionaire)
			{
				 db.Tconcessionaire.Remove(tconcessionaire);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
