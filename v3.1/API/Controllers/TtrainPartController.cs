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
	public class TtrainPartsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtrainPart> lTtrainParts = await db.TtrainPart.GetAllCompanyTtrainParts(id);
				 //return JsonConvert.SerializeObject(lTtrainParts.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtrainPart ttrainpart)
			{
				 //Create
				 db.TtrainPart.Add(ttrainpart);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttrainpart);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtrainPart ttrainpart)
			{
				 //Update
				 db.TtrainPart.Update(ttrainpart);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtrainPart ttrainpart)
			{
				 db.TtrainPart.Remove(ttrainpart);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
