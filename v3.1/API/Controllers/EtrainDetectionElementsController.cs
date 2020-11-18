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
	public class EtrainDetectionElementssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtrainDetectionElements> lEtrainDetectionElementss = await db.EtrainDetectionElements.GetAllCompanyEtrainDetectionElementss(id);
				 //return JsonConvert.SerializeObject(lEtrainDetectionElementss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtrainDetectionElements etraindetectionelements)
			{
				 //Create
				 db.EtrainDetectionElements.Add(etraindetectionelements);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etraindetectionelements);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtrainDetectionElements etraindetectionelements)
			{
				 //Update
				 db.EtrainDetectionElements.Update(etraindetectionelements);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtrainDetectionElements etraindetectionelements)
			{
				 db.EtrainDetectionElements.Remove(etraindetectionelements);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
