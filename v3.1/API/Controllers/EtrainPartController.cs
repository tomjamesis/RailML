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
	public class EtrainPartsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtrainPart> lEtrainParts = await db.EtrainPart.GetAllCompanyEtrainParts(id);
				 //return JsonConvert.SerializeObject(lEtrainParts.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtrainPart etrainpart)
			{
				 //Create
				 db.EtrainPart.Add(etrainpart);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etrainpart);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtrainPart etrainpart)
			{
				 //Update
				 db.EtrainPart.Update(etrainpart);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtrainPart etrainpart)
			{
				 db.EtrainPart.Remove(etrainpart);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
