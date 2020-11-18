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
	public class EpropulsionsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Epropulsion> lEpropulsions = await db.Epropulsion.GetAllCompanyEpropulsions(id);
				 //return JsonConvert.SerializeObject(lEpropulsions.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Epropulsion epropulsion)
			{
				 //Create
				 db.Epropulsion.Add(epropulsion);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(epropulsion);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Epropulsion epropulsion)
			{
				 //Update
				 db.Epropulsion.Update(epropulsion);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Epropulsion epropulsion)
			{
				 db.Epropulsion.Remove(epropulsion);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
