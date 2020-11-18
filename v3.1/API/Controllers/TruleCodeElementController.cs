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
	public class TruleCodeElementsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TruleCodeElement> lTruleCodeElements = await db.TruleCodeElement.GetAllCompanyTruleCodeElements(id);
				 //return JsonConvert.SerializeObject(lTruleCodeElements.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TruleCodeElement trulecodeelement)
			{
				 //Create
				 db.TruleCodeElement.Add(trulecodeelement);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(trulecodeelement);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TruleCodeElement trulecodeelement)
			{
				 //Update
				 db.TruleCodeElement.Update(trulecodeelement);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TruleCodeElement trulecodeelement)
			{
				 db.TruleCodeElement.Remove(trulecodeelement);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
