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
	public class ElocallyControlledAreasController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<ElocallyControlledArea> lElocallyControlledAreas = await db.ElocallyControlledArea.GetAllCompanyElocallyControlledAreas(id);
				 //return JsonConvert.SerializeObject(lElocallyControlledAreas.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]ElocallyControlledArea elocallycontrolledarea)
			{
				 //Create
				 db.ElocallyControlledArea.Add(elocallycontrolledarea);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(elocallycontrolledarea);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]ElocallyControlledArea elocallycontrolledarea)
			{
				 //Update
				 db.ElocallyControlledArea.Update(elocallycontrolledarea);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]ElocallyControlledArea elocallycontrolledarea)
			{
				 db.ElocallyControlledArea.Remove(elocallycontrolledarea);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
