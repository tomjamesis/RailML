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
	public class TinfrastructureVisualizationsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TinfrastructureVisualization> lTinfrastructureVisualizations = await db.TinfrastructureVisualization.GetAllCompanyTinfrastructureVisualizations(id);
				 //return JsonConvert.SerializeObject(lTinfrastructureVisualizations.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TinfrastructureVisualization tinfrastructurevisualization)
			{
				 //Create
				 db.TinfrastructureVisualization.Add(tinfrastructurevisualization);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tinfrastructurevisualization);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TinfrastructureVisualization tinfrastructurevisualization)
			{
				 //Update
				 db.TinfrastructureVisualization.Update(tinfrastructurevisualization);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TinfrastructureVisualization tinfrastructurevisualization)
			{
				 db.TinfrastructureVisualization.Remove(tinfrastructurevisualization);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
