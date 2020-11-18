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
	public class TdesignatorsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tdesignator> lTdesignators = await db.Tdesignator.GetAllCompanyTdesignators(id);
				 //return JsonConvert.SerializeObject(lTdesignators.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tdesignator tdesignator)
			{
				 //Create
				 db.Tdesignator.Add(tdesignator);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tdesignator);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tdesignator tdesignator)
			{
				 //Update
				 db.Tdesignator.Update(tdesignator);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tdesignator tdesignator)
			{
				 db.Tdesignator.Remove(tdesignator);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
