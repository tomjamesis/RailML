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
	public class TtrainDetectorsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtrainDetector> lTtrainDetectors = await db.TtrainDetector.GetAllCompanyTtrainDetectors(id);
				 //return JsonConvert.SerializeObject(lTtrainDetectors.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtrainDetector ttraindetector)
			{
				 //Create
				 db.TtrainDetector.Add(ttraindetector);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttraindetector);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtrainDetector ttraindetector)
			{
				 //Update
				 db.TtrainDetector.Update(ttraindetector);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtrainDetector ttraindetector)
			{
				 db.TtrainDetector.Remove(ttraindetector);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
