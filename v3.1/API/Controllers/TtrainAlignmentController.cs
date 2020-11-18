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
	public class TtrainAlignmentsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtrainAlignment> lTtrainAlignments = await db.TtrainAlignment.GetAllCompanyTtrainAlignments(id);
				 //return JsonConvert.SerializeObject(lTtrainAlignments.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtrainAlignment ttrainalignment)
			{
				 //Create
				 db.TtrainAlignment.Add(ttrainalignment);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttrainalignment);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtrainAlignment ttrainalignment)
			{
				 //Update
				 db.TtrainAlignment.Update(ttrainalignment);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtrainAlignment ttrainalignment)
			{
				 db.TtrainAlignment.Remove(ttrainalignment);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
