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
	public class EannotationssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Eannotations> lEannotationss = await db.Eannotations.GetAllCompanyEannotationss(id);
				 //return JsonConvert.SerializeObject(lEannotationss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Eannotations eannotations)
			{
				 //Create
				 db.Eannotations.Add(eannotations);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eannotations);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Eannotations eannotations)
			{
				 //Update
				 db.Eannotations.Update(eannotations);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Eannotations eannotations)
			{
				 db.Eannotations.Remove(eannotations);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
