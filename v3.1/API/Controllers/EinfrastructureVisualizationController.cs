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
	public class EinfrastructureVisualizationsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EinfrastructureVisualization> lEinfrastructureVisualizations = await db.EinfrastructureVisualization.GetAllCompanyEinfrastructureVisualizations(id);
				 //return JsonConvert.SerializeObject(lEinfrastructureVisualizations.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EinfrastructureVisualization einfrastructurevisualization)
			{
				 //Create
				 db.EinfrastructureVisualization.Add(einfrastructurevisualization);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(einfrastructurevisualization);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EinfrastructureVisualization einfrastructurevisualization)
			{
				 //Update
				 db.EinfrastructureVisualization.Update(einfrastructurevisualization);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EinfrastructureVisualization einfrastructurevisualization)
			{
				 db.EinfrastructureVisualization.Remove(einfrastructurevisualization);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
