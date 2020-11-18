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
	public class TtrainProtectionElementsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtrainProtectionElement> lTtrainProtectionElements = await db.TtrainProtectionElement.GetAllCompanyTtrainProtectionElements(id);
				 //return JsonConvert.SerializeObject(lTtrainProtectionElements.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtrainProtectionElement ttrainprotectionelement)
			{
				 //Create
				 db.TtrainProtectionElement.Add(ttrainprotectionelement);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttrainprotectionelement);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtrainProtectionElement ttrainprotectionelement)
			{
				 //Update
				 db.TtrainProtectionElement.Update(ttrainprotectionelement);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtrainProtectionElement ttrainprotectionelement)
			{
				 db.TtrainProtectionElement.Remove(ttrainprotectionelement);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
