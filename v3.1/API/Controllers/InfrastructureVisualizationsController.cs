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
	public class InfrastructureVisualizationssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<InfrastructureVisualizations> lInfrastructureVisualizationss = await db.InfrastructureVisualizations.GetAllCompanyInfrastructureVisualizationss(id);
				 //return JsonConvert.SerializeObject(lInfrastructureVisualizationss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]InfrastructureVisualizations infrastructurevisualizations)
			{
				 //Create
				 db.InfrastructureVisualizations.Add(infrastructurevisualizations);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(infrastructurevisualizations);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]InfrastructureVisualizations infrastructurevisualizations)
			{
				 //Update
				 db.InfrastructureVisualizations.Update(infrastructurevisualizations);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]InfrastructureVisualizations infrastructurevisualizations)
			{
				 db.InfrastructureVisualizations.Remove(infrastructurevisualizations);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
